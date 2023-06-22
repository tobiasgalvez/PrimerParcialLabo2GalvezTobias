using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    internal class ManejadorSQLTorneos : IManejadorSQL<Torneo>
    {
        private readonly string _connectionString;

        public ManejadorSQLTorneos(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Torneo>> LeerDatosAsync()
        {
            List<Torneo> torneos = new List<Torneo>();
            List<Equipo> equiposDelTorneo = new List<Equipo>();
            List<Partido> partidosDelTorneo = new List<Partido>();

            IManejadorSQL<Equipo> sqlEquipos = new ManejadorSqlEquipos(_connectionString);
            IManejadorSQL<Partido> sqlPartidos = new ManejadorSQLResultados(_connectionString);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM torneos", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            torneos.Add(new Torneo(reader.GetString(1)));
                        }
                    }
                }
            }

            equiposDelTorneo = await sqlEquipos.LeerDatosAsync();
            partidosDelTorneo = await sqlPartidos.LeerDatosAsync();

            AsignarEquiposATorneos(torneos, equiposDelTorneo);
            AsignarPartidosATorneos(torneos, partidosDelTorneo);




            return torneos;
        }
        public async Task AgregarDatoAsync(Torneo torneo)
        {
           
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("INSERT INTO torneos (nombre, cantidad_equipos) VALUES (@Nombre, @CantidadEquipos)", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", torneo.Nombre);
                    command.Parameters.AddWithValue("@CantidadEquipos", torneo.CantidadEquipos);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task ModificarDatoAsync(Torneo torneoOriginal, Torneo torneoModificado)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("UPDATE torneos SET Nombre = @NombreModificado WHERE Nombre = @NombreOriginal", connection))
                {
                    command.Parameters.AddWithValue("@NombreOriginal",torneoOriginal.Nombre);
                    command.Parameters.AddWithValue("@NombreModificado", torneoModificado.Nombre);
                    

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarDatoAsync(Torneo torneo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("DELETE FROM torneos WHERE Nombre = @Nombre", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", torneo.Nombre);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private void AsignarEquiposATorneos(List<Torneo> torneos, List<Equipo> equipos)
        {
            foreach (var equipo in equipos)
            {
                foreach (var torneo in torneos)
                {
                    if (equipo.Liga == torneo.Nombre)
                    {
                        torneo.ListaDeEquipos.Add(equipo);
                        torneo.CantidadEquipos++;
                    }
                }
            }



            //    using (SqlConnection connection = new SqlConnection(_connectionString))
            //    {
            //        await connection.OpenAsync();

            //        using (SqlCommand command = new SqlCommand("SELECT id FROM equipos WHERE id_torneo = @idTorneo", connection))
            //        {
            //            command.Parameters.AddWithValue("@idTorneo", idTorneo);
            //            object result = await command.ExecuteScalarAsync();
            //            return result.ToString();
            //        }
            //    }
            //}

        }

        private void AsignarPartidosATorneos(List<Torneo> torneos, List<Partido> partidos)
        {
            foreach (var partido in partidos)
            {
                foreach (var torneo in torneos)
                {
                    if (partido.Torneo == torneo.Nombre)
                    {
                        torneo.ListaDePartidos.Add(partido);
                        torneo.CantidadPartidos++;
                    }
                }
            }
        }
    }
}

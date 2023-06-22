using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    public class ManejadorSqlEquipos : IManejadorSQL<Equipo>
    {
        private readonly string _connectionString;

        public ManejadorSqlEquipos(string connectionString)
        {
            _connectionString = connectionString;
        }


        public async Task<List<Equipo>> LeerDatosAsync()
        {
            List<Equipo> equipos = new List<Equipo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Equipos", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string nombreTorneo = await ObtenerNombreTorneoAsync(reader.GetInt32(2));
                            equipos.Add(new Equipo(reader.GetString(1), nombreTorneo));
                        }
                    }
                }
            }

            return equipos;
        }

        private async Task<string> ObtenerNombreTorneoAsync(int idTorneo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT nombre FROM torneos WHERE ID = @idTorneo", connection))
                {
                    command.Parameters.AddWithValue("@idTorneo", idTorneo);
                    object result = await command.ExecuteScalarAsync();
                    return result.ToString();
                }
            }
        }
        public async Task AgregarDatoAsync(Equipo equipo)
        {
            int idTorneo = await ObtenerIdTorneoAsync(equipo.Liga);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("INSERT INTO equipos (nombre, id_Torneo) VALUES (@Nombre, @IdTorneo)", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    command.Parameters.AddWithValue("@IdTorneo", idTorneo);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task ModificarDatoAsync(Equipo equipoOriginal, Equipo equipoModificado)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("UPDATE Equipos SET Nombre = @NombreModificado, Liga = @LigaModificada WHERE Nombre = @NombreOriginal AND Liga = @LigaOriginal", connection))
                {
                    command.Parameters.AddWithValue("@NombreOriginal", equipoOriginal.Nombre);
                    command.Parameters.AddWithValue("@LigaOriginal", equipoOriginal.Liga);
                    command.Parameters.AddWithValue("@NombreModificado", equipoModificado.Nombre);
                    command.Parameters.AddWithValue("@LigaModificada", equipoModificado.Liga);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarDatoAsync(Equipo equipo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("DELETE FROM Equipos WHERE Nombre = @Nombre AND Liga = @Liga", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    command.Parameters.AddWithValue("@Liga", equipo.Liga);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private async Task<int> ObtenerIdTorneoAsync(string nombreTorneo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT ID FROM Torneos WHERE Nombre = @NombreTorneo", connection))
                {
                    command.Parameters.AddWithValue("@NombreTorneo", nombreTorneo);
                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }

                    throw new ArgumentException("El nombre del torneo no existe.");
                }
            }
        }
    }
}

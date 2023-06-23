using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases.ManejadorSQL
{
    public class ManejadorSQLResultados : IManejadorSQL<Partido>
    {
        private readonly string _connectionString;

        public ManejadorSQLResultados(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Partido>> LeerDatosAsync()
        {
            List<Partido> partidos = new List<Partido>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM partidos", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Equipo equipoLocal = await ObtenerEquipoAsync(reader.GetInt32(1));
                            Equipo equipoVisitante = await ObtenerEquipoAsync(reader.GetInt32(2));
                            string nombreTorneo = await ObtenerNombreTorneoAsync(reader.GetInt32(6));
                            partidos.Add(new Partido(equipoLocal, equipoVisitante, Enum.Parse<EResultado>(reader.GetString(3)), reader.GetInt32(4), reader.GetInt32(5), nombreTorneo, reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10)));
                        }
                    }
                }
            }

            return partidos;
        }


        public async Task AgregarDatoAsync(Partido partido)
        {
            //int idEquipo = await ObtenerIdEquipoAsync(jugador.Equipo);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("INSERT INTO partidos (id_equipoLocal, " +
                    "id_equipoVisitante, resultado, golesLocal, golesVisitante, id_torneo, " +
                    "tarjetasAmarillasLocal, tarjetasAmarillasVisitante, tarjetasRojasLocal, " +
                    "tarjetasRojasVisitante) VALUES (@IdEquipoLocal, @IdEquipoVisitante, @Resultado, " +
                    "@GolesLocal, @GolesVisitante, @IdTorneo, @AmarillasLocal, @AmarillasVisitante, @RojasLocal, " +
                    "@RojasVisitante)", connection))
                {
                    int idEquipoLocal = await ObtenerIdEquipoAsync(partido.EquipoLocal.Nombre);
                    int idEquipoVisitante = await ObtenerIdEquipoAsync(partido.EquipoVisitante.Nombre);
                    int idTorneo = await ObtenerIdTorneoAsync(partido.Torneo);

                    command.Parameters.AddWithValue("@IdEquipoLocal", idEquipoLocal);
                    command.Parameters.AddWithValue("@IdEquipoVisitante", idEquipoVisitante);
                    command.Parameters.AddWithValue("@Resultado", partido.Resultado);
                    command.Parameters.AddWithValue("@GolesLocal", partido.GolesLocal);
                    command.Parameters.AddWithValue("@GolesVisitante", partido.GolesVisitante);
                    command.Parameters.AddWithValue("@IdTorneo", idTorneo);
                    command.Parameters.AddWithValue("@AmarillasLocal", partido.TarjetasAmarillasLocal);
                    command.Parameters.AddWithValue("@AmarillasVisitante", partido.TarjetasAmarillasVisitante);
                    command.Parameters.AddWithValue("@RojasLocal", partido.TarjetasRojasLocal);
                    command.Parameters.AddWithValue("@RojasVisitante", partido.TarjetasRojasVisitante);



                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarDatoAsync(Partido partido)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("DELETE FROM partidos WHERE id_equipoLocal = @IdEquipoLocal, id_equipoVisitante = @IdEquipoVisitante, resultado = @Resultado, golesLocal = @GolesLocal, golesVisitante = @GolesVisitante", connection))
                {
                    int idEquipoLocal = await ObtenerIdEquipoAsync(partido.EquipoLocal.Nombre);
                    int idEquipoVisitante = await ObtenerIdEquipoAsync(partido.EquipoVisitante.Nombre);

                    command.Parameters.AddWithValue("@IdEquipoLocal", idEquipoLocal);
                    command.Parameters.AddWithValue("@IdEquipoVisitante", idEquipoVisitante);
                    command.Parameters.AddWithValue("@Resultado", partido.Resultado);
                    command.Parameters.AddWithValue("@GolesLocal", partido.GolesLocal);
                    command.Parameters.AddWithValue("@GolesVisitante", partido.GolesVisitante);


                    await command.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task ModificarDatoAsync(Partido partidoOriginal, Partido partidoModificado)
        {

        }


        private async Task<int> ObtenerIdEquipoAsync(string nombreEquipo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT id FROM equipos WHERE nombre = @NombreEquipo", connection))
                {
                    command.Parameters.AddWithValue("@NombreEquipo", nombreEquipo);
                    object result = await command.ExecuteScalarAsync();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }

                    throw new ArgumentException("El nombre del equipo no existe.");
                }
            }
        }

        private async Task<int> ObtenerIdTorneoAsync(string nombreTorneo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT id FROM torneos WHERE nombre = @NombreTorneo", connection))
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

        public async Task<Equipo> ObtenerEquipoAsync(int equipoId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM equipos WHERE id = @equipoId", connection))
                {
                    command.Parameters.AddWithValue("@equipoId", equipoId);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            Equipo equipo = new Equipo();
                            equipo.Nombre = reader.GetString(1);
                            equipo.Liga = await ObtenerNombreTorneoAsync(reader.GetInt32(2));

                            return equipo;
                        }
                    }
                }
            }

            throw new Exception("No se encontró el equipo");
        }

        private async Task<string> ObtenerNombreTorneoAsync(int idTorneo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT nombre FROM torneos WHERE id = @IdTorneo", connection))
                {
                    command.Parameters.AddWithValue("@IdTorneo", idTorneo);
                    object result = await command.ExecuteScalarAsync();
                    return result.ToString();
                }
            }
        }
    }
}

using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    public class ManejadorSQLJugadores : IManejadorSQL<Jugador>
    {

        private readonly string _connectionString;

        public ManejadorSQLJugadores(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Jugador>> LeerDatosAsync()
        {
            List<Jugador> jugadores = new List<Jugador>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM jugadores WHERE is_deleted = 0", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string nombreEquipo = await ObtenerNombreEquipoAsync(reader.GetInt32(6));
                            jugadores.Add(new Jugador(reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4),reader.GetString(5),nombreEquipo));
                        }
                    }
                }
            }

            return jugadores;
        }

        private async Task<string> ObtenerNombreEquipoAsync(int idEquipo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT nombre FROM equipos WHERE id = @idEquipo", connection))
                {
                    command.Parameters.AddWithValue("@idEquipo", idEquipo);
                    object result = await command.ExecuteScalarAsync();
                    return result.ToString();
                }
            }
        }


        public async Task AgregarDatoAsync(Jugador jugador)
        {
            int idEquipo = await ObtenerIdEquipoAsync(jugador.Equipo);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("INSERT INTO jugadores (nombre, apellido, fecha_nacimiento, dni, posicion, id_equipo) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Dni, @Posicion, @IdEquipo)", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                    command.Parameters.AddWithValue("@Apellido", jugador.Apellido);
                    command.Parameters.AddWithValue("@FechaNacimiento", jugador.FechaDeNacimiento);
                    command.Parameters.AddWithValue("@Dni", jugador.Dni);
                    command.Parameters.AddWithValue("@Posicion", jugador.Posicion);
                    command.Parameters.AddWithValue("@IdEquipo", idEquipo);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarDatoAsync(Jugador jugador)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("UPDATE jugadores SET is_deleted = 1 WHERE dni = @Dni", connection))
                {
                    command.Parameters.AddWithValue("@Dni", jugador.Dni);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task ModificarDatoAsync(Jugador jugadorOriginal, Jugador jugadorModificado)
        { 
            int idEquipoModificado = await ObtenerIdEquipoAsync(jugadorModificado.Equipo);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("UPDATE jugadores SET nombre = @NombreModificado, apellido = @ApellidoModificado, dni = @DniModificado, posicion = @PosicionModificado, id_equipo = @IdEquipoModificado      WHERE dni = @DniOriginal", connection))
                {
                    command.Parameters.AddWithValue("@NombreModificado", jugadorModificado.Nombre);
                    command.Parameters.AddWithValue("@ApellidoModificado", jugadorModificado.Apellido);

                    command.Parameters.AddWithValue("@DniOriginal", jugadorOriginal.Dni);
                    command.Parameters.AddWithValue("@DniModificado", jugadorModificado.Dni);

                    command.Parameters.AddWithValue("@PosicionModificado", jugadorModificado.Posicion);
                    command.Parameters.AddWithValue("@IdEquipoModificado", idEquipoModificado);


                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private async Task<int> ObtenerIdEquipoAsync(string nombreEquipo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT id FROM equipos WHERE Nombre = @NombreEquipo", connection))
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
    }
}

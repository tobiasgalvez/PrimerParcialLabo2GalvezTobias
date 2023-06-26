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
            List<Jugador> jugadores = new List<Jugador>();
            List<Partido> partidos = new List<Partido>();

            ManejadorSQLJugadores sqlJugadores = new ManejadorSQLJugadores(_connectionString);
            ManejadorSQLResultados sqlResultados = new ManejadorSQLResultados(_connectionString);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Equipos WHERE is_deleted = 0", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            string nombreTorneo = await ObtenerNombreTorneoAsync(reader.GetInt32(3));
                            equipos.Add(new Equipo(reader.GetString(1), nombreTorneo));
                        }
                    }
                }
            }

            jugadores = await sqlJugadores.LeerDatosAsync();
            partidos = await sqlResultados.LeerDatosAsync();
            
            List<Equipo> equiposAux = equipos;

            AsignarJugadoresAEquipos(equiposAux, jugadores);
            AsignarResultadosAEquipos(equiposAux, partidos);

            foreach (var item in equiposAux)
            {
                await ModificarDatoAsync(item, item);

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

                using (SqlCommand command = new SqlCommand("INSERT INTO equipos (nombre, id_liga) VALUES (@Nombre, @IdTorneo)", connection))
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

                using (SqlCommand command = new SqlCommand("UPDATE Equipos SET nombre = @NombreModificado, cantidad_jugadores = @CantidadJugadoresModificada,  id_liga = @IdLigaModificada  WHERE nombre = @NombreOriginal AND id_liga = @IdLigaOriginal", connection))
                {
                    int idLigaOriginal = await ObtenerIdTorneoAsync(equipoOriginal.Liga);
                    int idLigaModificado = await ObtenerIdTorneoAsync(equipoModificado.Liga);

                    command.Parameters.AddWithValue("@NombreOriginal", equipoOriginal.Nombre);
                    command.Parameters.AddWithValue("@IdLigaOriginal", idLigaOriginal);

                    command.Parameters.AddWithValue("@NombreModificado", equipoModificado.Nombre);
                    command.Parameters.AddWithValue("@CantidadJugadoresModificada", equipoModificado.CantidadJugadores);
                    command.Parameters.AddWithValue("@IdLigaModificada", idLigaModificado);


                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarDatoAsync(Equipo equipo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("UPDATE equipos SET is_deleted = 1 WHERE nombre = @Nombre", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", equipo.Nombre);

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

                    throw new Exception("El nombre del torneo no existe.");
                }
            }
        }



        /// <summary>
        /// Método por el cual se asignan jugadores a los equiposs
        /// </summary>
        /// <param name="equipos">lista de equipos</param>
        /// <param name="jugadores">lista de jugadores</param>
        private static void AsignarJugadoresAEquipos(List<Equipo> equipos, List<Jugador> jugadores)
        {
            foreach (var jugador in jugadores)
            {
                foreach (var equipo in equipos)
                {
                    if (jugador.Equipo == equipo.Nombre)
                    {
                        equipo.ListaJugadores.Add(jugador);
                        equipo.CantidadJugadores++;
                    }
                }
            }
        }

        /// <summary>
        /// Método por el cual se asignan los resultados a los equipos
        /// </summary>
        /// <param name="equipos">lista de equipos</param>
        /// <param name="partidos">lista de partidos</param>
        private static void AsignarResultadosAEquipos(List<Equipo> equipos, List<Partido> partidos)
        {
            foreach (var partido in partidos)
            {
                foreach (var equipo in equipos)
                {
                    if (partido.EquipoLocal.Nombre == equipo.Nombre)
                    {
                        equipo.PartidosJugados++;
                        equipo.Goles += partido.GolesLocal;
                        //equipo.Goles += partido.EquipoLocal.Goles;
                        equipo.TarjetasAmarillas += partido.TarjetasAmarillasLocal;
                        equipo.TarjetasRojas += partido.TarjetasRojasLocal;
                        if (partido.Resultado == Enumerados.EResultado.Local)
                            equipo.PartidosGanados++;
                        else if (partido.Resultado == Enumerados.EResultado.Empate)
                            equipo.PartidosEmpatados++;
                        else
                            equipo.PartidosPerdidos++;
                    }
                    if (partido.EquipoVisitante.Nombre == equipo.Nombre)
                    {
                        equipo.PartidosJugados++;
                        equipo.Goles += partido.GolesVisitante;
                        //equipo.Goles += partido.EquipoVisitante.Goles; POR QUÉ NO FUNCIONA?
                        equipo.TarjetasAmarillas += partido.TarjetasAmarillasVisitante;
                        equipo.TarjetasRojas += partido.TarjetasRojasVisitante;
                        if (partido.Resultado == Enumerados.EResultado.Visitante)
                            equipo.PartidosGanados++;
                        else if (partido.Resultado == Enumerados.EResultado.Empate)
                            equipo.PartidosEmpatados++;
                        else
                            equipo.PartidosPerdidos++;
                    }
                }
            }
        }


    }
}

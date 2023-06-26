using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.ManejadorCsv;
using BibliotecaDeClases.ManejadorSQL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Sistema
    {
        private static string _connection = @"Server=.;Database=aplicacion;Trusted_Connection=True;";

        private static List<Usuario> _listaDeUsuarios;
        private static IManejadorSQL<Usuario> _sqlUsuarios;

        private static IManejadorSQL<Equipo> _sqlEquipos;

        private static IManejadorSQL<Jugador> _sqlJugadores;


        static Sistema()
        {
            _listaDeUsuarios = new List<Usuario>();
            _sqlUsuarios = new ManejadorSQLUsuarios(_connection);
            _sqlEquipos = new ManejadorSqlEquipos(_connection);
            _sqlJugadores = new ManejadorSQLJugadores(_connection);

        }

        public static List<Usuario> ListaDeUsuarios { get => _listaDeUsuarios; set => _listaDeUsuarios = value; }
        public static IManejadorSQL<Usuario> SqlUsuarios { get => _sqlUsuarios; set => _sqlUsuarios = value; }


        /// <summary>
        /// Método por el cual se verifica si un usuario es válido o no
        /// </summary>
        /// <param name="usuario">usuario ingresado</param>
        /// <param name="contraseña">contraseña ingresada</param>
        /// <returns>un usuario</returns>
        /// <exception cref="Exception"></exception>
        public static Usuario VerificarUsuarioExcepciones(string usuario, string contraseña)
        {
            string mensaje = "Error, datos ingresados invalidos";
            Validacion.ValidarString(usuario);
            Validacion.ValidarString(contraseña);
            
                foreach (Usuario item in _listaDeUsuarios)
                {
                    if (item.User.Trim() == usuario.Trim())
                    {
                        if (item.Contraseña.Trim() == contraseña.Trim())
                        {
                            return item;
                        }
                        throw new Exception(mensaje);
                    }
                }
                throw new Exception(mensaje);
        }

        /// <summary>
        /// Método por el cual se da un resumen de la aplicación
        /// </summary>
        /// <returns>resumen</returns>
        public static string InformacionAplicacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ésta es una aplicación de torneos de fútbol!!!");
            sb.AppendLine();
            sb.AppendLine("Acá se van a poder agregar jugadores, equipos, torneos y resultados");
            sb.AppendLine();
            sb.AppendLine("También vas a poder consultar nuestro ránking de equipos, en el cual tenemos los equipos con más partidos jugados, los equipos con más goles y mucho más!!!");
        
            return sb.ToString();
        }


        /// <summary>
        /// Método por el cual se actualiza el nombre del torneo en la lista de equipos
        /// </summary>
        /// <param name="nombreAnteriorTorneo">nombre anterior del torneo</param>
        /// <param name="torneoModificado">torneo con nombre modificado</param>
        public static async Task ModificarTorneoEnListaDeEquipos(string nombreAnteriorTorneo, Torneo torneoModificado, List<Equipo> listaEquipos)
        {
            foreach (var item in listaEquipos)
            {
                Equipo equipoNombreTorneoModificado;
                if (nombreAnteriorTorneo == item.Liga)
                {
                    equipoNombreTorneoModificado = item;
                    equipoNombreTorneoModificado.Liga = torneoModificado.Nombre;
                    await _sqlEquipos.ModificarDatoAsync(item, equipoNombreTorneoModificado);
                }
            }
        }

        /// <summary>
        /// Método por el cual se actualiza el nombre del equipo  en la lista de jugadores
        /// </summary>
        /// <param name="nombreAnteriorEquipo">nombre anterior del equipo</param>
        /// <param name="equipoModificado">equipo con nombre modificado</param>
        public static async Task ModificarEquipoEnListaDeJugadores(string nombreAnteriorEquipo, Equipo equipoModificado, List<Jugador> listaJugadores)
        {
            foreach (var item in listaJugadores)
            {
                if (nombreAnteriorEquipo == item.Equipo)
                {
                    Jugador jugadorNombreEquipoModificado = item;
                    jugadorNombreEquipoModificado.Equipo = equipoModificado.Nombre;
                    //csvJugadores.ModificarDato(item, jugadorNombreEquipoModificado);
                    await _sqlJugadores.ModificarDatoAsync(item, jugadorNombreEquipoModificado);
                }
            }
        }




    }
}

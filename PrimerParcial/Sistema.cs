using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.ManejadorCsv;
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
        private static List<Usuario> _listaDeUsuarios;

        static Sistema()
        {
            _listaDeUsuarios = new List<Usuario>();
            ManejadorCsvUsuarios csvUsuarios = new ManejadorCsvUsuarios("usuarios.csv");
            _listaDeUsuarios = csvUsuarios.LeerDatos();
        }

        public static List<Usuario> ListaDeUsuarios { get => _listaDeUsuarios; set => _listaDeUsuarios = value; }


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

       

    }
}

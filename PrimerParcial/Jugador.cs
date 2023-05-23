using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Jugador : Persona
    {
        private string _posicion;
        private string _equipo;

       


        public Jugador(string nombre, string apellido, DateTime edad, int dni, string posicion, string equipo):base(nombre, apellido, edad, dni)
        {
            _posicion = posicion;
            _equipo = equipo;
        }

        public string Posicion { get => _posicion; set => _posicion = value; }
        public string Equipo { get => _equipo; set => _equipo = value; }

        /// <summary>
        /// Método por el cual obtenemos la información de un jugador
        /// </summary>
        /// <returns></returns>
        public override string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{Nombre}");
            sb.AppendLine($"Apellido:{Apellido}");
            sb.AppendLine($"Dni: {Dni.ToString()}");
            sb.AppendLine($"Edad {CalcularEdad().ToString()}");
            sb.AppendLine($"Equipo:{Equipo}");
            sb.AppendLine($"Posicion:{Posicion}");
            return sb.ToString();
            
        }

  
        /// <summary>
        /// Método por el cual validamos nombre, apellido y dni de un jugador
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public static void ValidarJugador(string nombre, string apellido, string dni)
        {
            ValidarDni(dni);
            ValidarNombreYApellido(nombre, apellido);
        }

        /// <summary>
        /// Método que permite buscar el índice de un jugador
        /// </summary>
        /// <param name="jugadores"></param>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static int BuscarIndice(List<Jugador> jugadores, Jugador jugador)
        {
            int indice = -1;
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (jugadores[i] == jugador)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        /// <summary>
        /// Sobrecarga del operador != para verificar si un jugador es distinto de otro
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.Dni != j2.Dni;
        }

        /// <summary>
        /// Sobrecarga del operador == para verificar si un jugador es igual al otro
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Apellido}, {Nombre}, {Dni.ToString()}";
        }

    }
}

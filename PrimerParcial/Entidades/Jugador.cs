using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Entidades
{
    public class Jugador : Persona
    {
        private string _posicion;
        private string _equipo;




        public Jugador(string nombre, string apellido, DateTime edad, int dni, string posicion, string equipo) : base(nombre, apellido, edad, dni)
        {
            _posicion = posicion;
            _equipo = equipo;
        }

        public string Posicion { get => _posicion; set => _posicion = value; }
        public string Equipo { get => _equipo; set => _equipo = value; }

        /// <summary>
        /// Método por el cual obtenemos la información de un jugador
        /// </summary>
        /// <returns>Datos del jugador</returns>
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
        /// <param name="nombre">nombre ingresado</param>
        /// <param name="apellido">apellido ingresado</param>
        /// <param name="dni">dni ingresado</param>
        public static void ValidarJugador(string nombre, string apellido, string dni)
        {
            ValidarDni(dni);
            ValidarNombreYApellido(nombre, apellido);
        }

        /// <summary>
        /// Método que permite buscar el índice de un jugador
        /// </summary>
        /// <param name="jugadores">lista de jugadores</param>
        /// <param name="jugador">jugador a buscar</param>
        /// <returns> si encontró el jugador, su índice, sino -1</returns>
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
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="j1">jugador 1</param>
        /// <param name="j2">jugador 2</param>
        /// <returns>retorna true si no coincide el Dni de los jugadores, sino false</returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.Dni != j2.Dni;
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="j1">jugador 1</param>
        /// <param name="j2">jugador 2</param>
        /// <returns>retorna true si coincide el Dni de los jugadores, sino false</returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        /// <summary>
        /// Modificación del método ToString()
        /// </summary>
        /// <returns>Retorna apellido, nombre y dni del jugador</returns>
        public override string ToString()
        {
            return $"{Apellido}, {Nombre}, {Dni.ToString()}";
        }

    }
}

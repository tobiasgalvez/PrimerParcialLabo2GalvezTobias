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
        private int _cantidadGoles;
        private string _equipo;

       


        public Jugador(string nombre, string apellido, DateTime edad, int dni, string posicion, string equipo):base(nombre, apellido, edad, dni)
        {
            _posicion = posicion;
            _equipo = equipo;
        }

        public string Posicion { get => _posicion; set => _posicion = value; }
        public int CantidadGoles { get => _cantidadGoles; set => _cantidadGoles = value; }
        public string Equipo { get => _equipo; set => _equipo = value; }


        

        public static List<Jugador> GetAll()
        {
            return new List<Jugador>();
        }

        //public static Jugador Save()
        //{
        //    return new Jugador();
        //}


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{Nombre}");
            sb.AppendLine($"Dni: {Dni.ToString()}");
            sb.AppendLine($"Edad {CalcularEdad().ToString()}");
            sb.AppendLine($"Equipo:{Equipo}");
            sb.AppendLine($"Posicion:{Posicion}");
            return sb.ToString();
        }


    }
}

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


        public Jugador(string nombre, string apellido, int edad, int dni, string posicion, string equipo):base(nombre, apellido, edad, dni)
        {
            _posicion = posicion;
            _cantidadGoles = 0;
            _equipo = equipo;
        }

        public string Posicion { get => _posicion; set => _posicion = value; }
        public int CantidadGoles { get => _cantidadGoles; set => _cantidadGoles = value; }
        public string Equipo { get => _equipo; set => _equipo = value; }
    }
}

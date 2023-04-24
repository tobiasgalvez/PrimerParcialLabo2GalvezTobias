using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _dni;


        public Persona(string nombre, string apellido, int edad, int dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
            _dni = dni;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public int Dni { get => _dni;}

    }
}

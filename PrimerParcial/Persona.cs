using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Falta llenar campo 'nombre'.");
                }
                _nombre = value;
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Falta llenar campo 'apellido'");
                }
                _apellido = value;
            }
        }

        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value <= 0 || value >= 100)
                {
                    throw new ArgumentException("La edad debe estar entre 1 y 100 años.");
                }
                _edad = value;
            }
        }

        public int Dni { get => _dni; set => _dni = Validacion.ValidarDni(value); }
    }
}

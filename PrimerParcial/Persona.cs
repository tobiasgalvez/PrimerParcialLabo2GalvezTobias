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
        private DateTime _fechaDeNacimiento;
        private int _dni;

        public Persona(string nombre, string apellido, DateTime fechaDeNacimiento, int dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechaDeNacimiento = fechaDeNacimiento;
            _dni = dni;
        }

       

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaDeNacimiento { get => _fechaDeNacimiento; set => _fechaDeNacimiento = value; }
        public int Dni { get => _dni; set => _dni = value; }



        public int CalcularEdad()
        {
            int edad;
            return edad = DateTime.Today.AddTicks(-FechaDeNacimiento.Ticks).Year - 1;
        }
    }
}

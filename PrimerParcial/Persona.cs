using BibliotecaDeClases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Persona
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


        public abstract string ObtenerInformacion();


        public int CalcularEdad()
        {
            int edad;
            return edad = DateTime.Today.AddTicks(-FechaDeNacimiento.Ticks).Year - 1;
        }


        public static void ValidarNombreYApellido(string nombre, string apellido)
        {
            Validacion.ValidarString(nombre);
            Validacion.ValidarString(apellido);
            
                if (!(nombre.All(char.IsLetter) && apellido.All(char.IsLetter)))
                {
                    throw new StringLetrasException("nombre y/o apellido deben ser letras");
                    //argumentFormatException
                }
            
        }

        public static void ValidarDni(string dni)
        {
            int dniParser;
            dniParser = Validacion.DevolverCadenaParseadaInt(dni);

            if(dniParser == -1)
            {
                throw new StringNumeroException("El campo DNI sólo acepta números");
            }
                if (dniParser > 70000000 || dniParser < 1000000)
                {
                    throw new ArgumentException("Numero de DNI invalido");
                }
            
        }
    }
}

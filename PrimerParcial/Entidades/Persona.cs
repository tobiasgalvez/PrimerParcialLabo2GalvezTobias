using BibliotecaDeClases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Entidades
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

        /// <summary>
        /// Método que permite obtener la informacion de una persona
        /// </summary>
        /// <returns>Datos de la persona</returns>
        public abstract string ObtenerInformacion();

        /// <summary>
        /// Método que permite calcular la edad de una persona
        /// </summary>
        /// <returns>edad de la persona</returns>
        public int CalcularEdad()
        {
            return DateTime.Today.AddTicks(-FechaDeNacimiento.Ticks).Year - 1;
        }

        /// <summary>
        /// Método por el cual se valida el nombre y apellido de una persona
        /// </summary>
        /// <param name="nombre">nombre ingresado</param>
        /// <param name="apellido">apellido ingresado</param>
        /// <exception cref="StringLetrasException"></exception>
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

        /// <summary>
        /// Método por el cual se valida el dni de una persona
        /// </summary>
        /// <param name="dni">dni ingresado</param>
        /// <exception cref="StringNumeroException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void ValidarDni(string dni)
        {
            int dniParser;
            dniParser = Validacion.DevolverCadenaParseadaInt(dni);

            if (dniParser == -1)
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

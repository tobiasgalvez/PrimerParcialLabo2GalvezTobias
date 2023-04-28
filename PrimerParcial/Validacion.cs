using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Validacion
    {
        public static bool ValidarNombreYApellido(Persona persona)
        {
            if (persona == null)
            {
                return false;
            }

            try
            {
                persona.Nombre = persona.Nombre.Trim();
                persona.Apellido = persona.Apellido.Trim();
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public static int ValidarDni(int dni)
        {
            if (dni < 999999)
            {
                throw new ArgumentException("Numero de DNI invalido");
            }
            return dni;
        }


    }
}

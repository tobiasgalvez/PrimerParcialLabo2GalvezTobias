using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Validacion
    {
        public static bool ValidarString(string cadena)
        {
            bool retorno = false;

             if(!String.IsNullOrEmpty(cadena.Trim()))
             {
                retorno = true;
             }
            return retorno;
        }


        public static bool ValidarNombreYApellido(string nombre, string apellido)
        {
           if(ValidarString(nombre) && ValidarString(apellido))
           {
                if(!(nombre.All(char.IsLetter) || apellido.All(char.IsLetter)))
                {
                    throw new ArgumentException("nombre y/o apellido deben ser letras");
                }

                return true;
           }

  

            return true;
        }

        public static bool ValidarDni(int dni)
        {
           if (dni < 999999)
           {
              throw new ArgumentException("Numero de DNI invalido");
           }
            return true;
        }
        public static int DevolverCadenaParseadaInt(string cadena)
        {
            int parseo;
            ValidarString(cadena);

            if (!int.TryParse(cadena, out parseo))
            {
                throw new ArgumentException("El campo DNI sólo acepta numeros");
            }
            return parseo;
        }



        public static bool ValidarJugador(string nombre, string apellido, int dni)
        {
            if(ValidarNombreYApellido(nombre, apellido) && ValidarDni(dni))
            {
                return true;
            }
            return false;
        }

    }
}

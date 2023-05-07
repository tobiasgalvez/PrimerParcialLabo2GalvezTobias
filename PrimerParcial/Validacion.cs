using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Validacion
    {
        public static void ValidarString(string cadena)
        {
             if(string.IsNullOrEmpty(cadena)) //conviene usar 'string' y no 'String'
             {
                throw new ArgumentException("Hay campos vacios!!!");
                //throw new ArgumentNullException(cadena, "Hay campos vacios!!!!");
             }

        }


        public static int DevolverCadenaParseadaInt(string cadena)
        {
            int parseo;
            ValidarString(cadena);

            if (!(int.TryParse(cadena, out parseo)))
            {
                return -1;
            }
            else
            {
                return parseo;

            }
        }




    }
}

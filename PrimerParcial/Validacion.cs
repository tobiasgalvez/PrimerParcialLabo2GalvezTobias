using BibliotecaDeClases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Validacion
    {
        /// <summary>
        /// Método por el cual se valida si un string es válido o no
        /// </summary>
        /// <param name="cadena">cadena ingresada</param>
        /// <exception cref="CampoVacioException"></exception>
        public static void ValidarString(string cadena)
        {
             if(string.IsNullOrEmpty(cadena)) //conviene usar 'string' y no 'String'
             {
                throw new CampoVacioException("Hay campos vacios!!!");
                //throw new ArgumentNullException(cadena, "Hay campos vacios!!!!");
             }

        }

        /// <summary>
        /// Método por el cual se parsea un string a int
        /// </summary>
        /// <param name="cadena">cadena ingresada</param>
        /// <returns>si pudo realizar el parseo, el contenido de la cadena, sino -1</returns>
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

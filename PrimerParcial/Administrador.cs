using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases
{
    public class Administrador : Usuario
    {
        private string _hola; //no sabría qué atributo agregarle
        public Administrador(string nombre, string apellido, DateTime edad, int dni, string usuario, string contraseña, ERol rol, string hola) : base(nombre, apellido, edad, dni, usuario, contraseña, rol)
        {
            _hola = hola;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Usuario : Persona
    {
        private string _user;
        private string _contraseña;



        public Usuario(string nombre, string apellido, DateTime edad, int dni, string usuario, string contraseña) : base(nombre, apellido, edad, dni)
        {
            _user = usuario;
            _contraseña = contraseña;

        }

        public string User { get => _user; set => _user = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
    }
}

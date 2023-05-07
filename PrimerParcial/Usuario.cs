using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases
{
    public class Usuario : Persona
    {
        private string _user;
        private string _contraseña;
        private ERol _rol;



        public Usuario(string nombre, string apellido, DateTime edad, int dni, string usuario, string contraseña, ERol rol) : base(nombre, apellido, edad, dni)
        {
            _user = usuario;
            _contraseña = contraseña;
            _rol = rol;
        }

        public string User { get => _user; set => _user = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public ERol Rol { get => _rol;}
    }
}

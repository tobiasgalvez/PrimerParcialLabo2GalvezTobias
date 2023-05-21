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


        public override string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{Nombre}");
            sb.AppendLine($"Apellido:{Apellido}");
            sb.AppendLine($"Dni: {Dni.ToString()}");
            sb.AppendLine($"Edad {CalcularEdad().ToString()}");
            sb.AppendLine($"Nombre de usuario:{User}");
            sb.AppendLine($"Rol:{Rol}");
            return sb.ToString();
        }

        public static int BuscarIndice(List<Usuario> usuarios, Usuario usuario)
        {
            int indice = -1;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i] == usuario)
                {
                    indice = i;
                }
            }

            return indice;
        }


        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return u1.User != u2.User;
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.User == u2.User;
        }

        public override string ToString()
        {
            return User;
        }
    }
}

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
        private readonly ERol _rol;



        public Usuario(string nombre, string apellido, DateTime edad, int dni, string usuario, string contraseña, ERol rol) : base(nombre, apellido, edad, dni)
        {
            _user = usuario;
            _contraseña = contraseña;
            _rol = rol;
        }

        public string User { get => _user; set => _user = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public ERol Rol { get => _rol;}

        /// <summary>
        /// Implementación de método de clase Persona, el cual permite obtener la información de una persona
        /// </summary>
        /// <returns>Datos de la persona</returns>
        public override string ObtenerInformacion()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Nombre:{Nombre}");
            sb.AppendLine($"Apellido:{Apellido}");
            sb.AppendLine($"Dni: {Dni.ToString()}");
            sb.AppendLine($"Edad {CalcularEdad().ToString()}");
            sb.AppendLine($"Nombre de usuario:{User}");
            sb.AppendLine($"Rol:{Rol}");
            return sb.ToString();
        }

        /// <summary>
        /// Método por el cual se busca el indice de un usuario
        /// </summary>
        /// <param name="usuarios">lista de usuarios</param>
        /// <param name="usuario">usuario a buscar</param>
        /// <returns>si encontró el usuario, su índice, sino -1</returns>
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

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="u1">usuario 1</param>
        /// <param name="u2">usuario 2</param>
        /// <returns>retorna true si el usuario es distinto de otro, sino false</returns>
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return u1.User != u2.User;
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="u1">usuario 1</param>
        /// <param name="u2">usuario 2</param>
        /// <returns>retorna true si el usuario es igual a otro, sino false</returns>
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.User == u2.User;
        }


        /// <summary>
        /// Modificación del método ToString()
        /// </summary>
        /// <returns>nombre de usuario</returns>
        public override string ToString()
        {
            return User;
        }
    }
}

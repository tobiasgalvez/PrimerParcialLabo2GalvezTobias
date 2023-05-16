using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Sistema
    {
        private static List<Usuario> _listaDeUsuarios;

        static Sistema()
        {
            _listaDeUsuarios = new List<Usuario>();
            Hardcodeo.HardcodearUsuarios(_listaDeUsuarios);
        }

        public static List<Usuario> ListaDeUsuarios { get => _listaDeUsuarios; set => _listaDeUsuarios = value; }



        public static Usuario VerificarUsuarioExcepciones(string usuario, string contraseña)
        {
            string mensaje = "Error, datos ingresados invalidos";
            Validacion.ValidarString(usuario);
            Validacion.ValidarString(contraseña);
            
                foreach (Usuario item in _listaDeUsuarios)
                {
                    if (item.User.Trim() == usuario.Trim())
                    {
                        if (item.Contraseña.Trim() == contraseña.Trim())
                        {
                            return item;
                        }
                        throw new Exception(mensaje);
                    }
                }
                throw new Exception(mensaje);
        }

        //    formulario.MaximizeBox = false;
        //    formulario.MinimizeBox = false;
        //}

    }
}

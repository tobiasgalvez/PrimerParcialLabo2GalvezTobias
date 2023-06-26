using BibliotecaDeClases.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Informes
{
    public class InformesUsuarios : IInformes<Usuario>
    {
        private string _path;


        public InformesUsuarios(string path)
        {
            _path = path;
        }

        public void GuardarDatosCsv(List<Usuario> lista)
        {
            using (var sw = new StreamWriter(_path, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                sw.WriteLine("Nombre,Apellido,FechaDeNacimiento,Dni,User,Contraseña,Rol");
                foreach (var usuario in lista)
                {
                    sw.WriteLine($"{usuario.Nombre},{usuario.Apellido}, {usuario.FechaDeNacimiento}, {usuario.Dni},{usuario.User},{usuario.Contraseña},{usuario.Rol}");
                }
            }
        }

        public void GuardarDatosJson(List<Usuario> lista)
        {
            string jsonString = JsonConvert.SerializeObject(lista, Formatting.Indented);

            using (var sw = new StreamWriter(_path, false))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}

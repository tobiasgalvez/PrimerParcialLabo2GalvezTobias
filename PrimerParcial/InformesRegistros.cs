using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class InformesRegistros : IInformes<Logs>
    {
        private string _path;


        public InformesRegistros(string path)
        {
            _path = path;
        }


        public void GuardarDatosCsv(List<Logs> lista)
        {
            using (var sw = new StreamWriter(_path, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                //sw.WriteLine("Nombre,Apellido,FechaDeNacimiento,Dni,Posicion,Equipo");
                foreach (var registro in lista)
                {
                    sw.WriteLine($"{registro.Fecha},{registro.Usuario}, {registro.Accion}");
                }
            }
        }

        public void GuardarDatosJson(List<Logs> lista)
        {
            string jsonString = JsonConvert.SerializeObject(lista, Formatting.Indented);

            using (var sw = new StreamWriter(_path, false))
            {
                sw.WriteLine(jsonString);
            }
        }
    }


  }


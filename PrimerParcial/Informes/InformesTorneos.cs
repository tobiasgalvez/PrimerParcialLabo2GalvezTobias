using BibliotecaDeClases.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Informes
{
    public class InformesTorneos : IInformes<Torneo>
    {
        private string _path;


        public InformesTorneos(string path)
        {
            _path = path;
        }

        public void GuardarDatosCsv(List<Torneo> lista)
        {
            using (var sw = new StreamWriter(_path, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                sw.WriteLine("Nombre,CantidadEquipos");
                foreach (var torneo in lista)
                {
                    sw.WriteLine($"{torneo.Nombre},{torneo.CantidadEquipos}");
                }
            }
        }

        public void GuardarDatosJson(List<Torneo> lista)
        {
            string jsonString = JsonConvert.SerializeObject(lista, Formatting.Indented);

            using (var sw = new StreamWriter(_path, false))
            {
                sw.WriteLine(jsonString);
            }
        }

    }
}

using BibliotecaDeClases.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Informes
{
    public class InformesPartidos : IInformes<Partido>
    {
        private string _path;


        public InformesPartidos(string path)
        {
            _path = path;
        }

        public void GuardarDatosCsv(List<Partido> lista)
        {
            using (var sw = new StreamWriter(_path, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                sw.WriteLine("EquipoLocal,EquipoVisitante,Resultado,GolesLocal,GolesVisitante,Torneo,TarjetasAmarillasLocal,TarjetasRojasLocal,TarjetasAmarillasVisitante,TarjetasRojasVisitante");
                foreach (var partido in lista)
                {
                    sw.WriteLine($"{partido.EquipoLocal},{partido.EquipoVisitante},{partido.Resultado},{partido.GolesLocal},{partido.GolesVisitante},{partido.Torneo},{partido.TarjetasAmarillasLocal},{partido.TarjetasRojasLocal},{partido.TarjetasAmarillasVisitante},{partido.TarjetasRojasVisitante}");
                }
            }
        }



        public void GuardarDatosJson(List<Partido> lista)
        {
            string jsonString = JsonConvert.SerializeObject(lista, Formatting.Indented);

            using (var sw = new StreamWriter(_path, false))
            {
                sw.WriteLine(jsonString);
            }
        }

    }

}




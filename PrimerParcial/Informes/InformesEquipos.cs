using BibliotecaDeClases.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Informes
{
    public class InformesEquipos : IInformes<Equipo>
    {
        private string _path;


        public InformesEquipos(string path)
        {
            _path = path;
        }

        public void GuardarDatosCsv(List<Equipo> lista)
        {
            using (var sw = new StreamWriter(_path, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                sw.WriteLine("Nombre,Liga,ListaJugadores,CantidadJugadores,Partidos Ganados, Partidos Empatados, Partidos Perdidos, Tarjetas Amarillas, Tarjetas Rojas");
                foreach (var equipo in lista)
                {
                    sw.WriteLine($"{equipo.Nombre},{equipo.Liga},{equipo.CantidadJugadores},{equipo.PartidosGanados},{equipo.PartidosEmpatados},{equipo.PartidosPerdidos},{equipo.TarjetasAmarillas},{equipo.TarjetasRojas}");
                }
            }
        }

        public void GuardarDatosJson(List<Equipo> lista)
        {
            string jsonString = JsonConvert.SerializeObject(lista, Formatting.Indented);

            using (var sw = new StreamWriter(_path, false))
            {
                sw.WriteLine(jsonString);
            }
        }

    }
}

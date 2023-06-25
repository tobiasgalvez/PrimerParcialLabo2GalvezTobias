using BibliotecaDeClases.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class InformesJugadores : IInformes<Jugador>
    {
        private readonly string _path;


        public InformesJugadores(string path)
        {
            _path = path;
        }


        public void GuardarDatosCsv(List<Jugador> lista)
        {
            using (var sw = new StreamWriter(_path, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                //sw.WriteLine("Nombre,Apellido,FechaDeNacimiento,Dni,Posicion,Equipo");
                foreach (var jugador in lista)
                {
                    sw.WriteLine($"{jugador.Nombre},{jugador.Apellido}, {jugador.FechaDeNacimiento}, {jugador.Dni},{jugador.Posicion},{jugador.Equipo}");
                }
            }
        }

        public void GuardarDatosJson(List<Jugador> lista)
        {
            string jsonString = JsonConvert.SerializeObject(lista, Formatting.Indented);

            using (var sw = new StreamWriter(_path, false))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}

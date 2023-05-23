using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Torneo
    {
        private string _nombre;
        private int _cantidadEquipos;
        private int _cantidadPartidos;
        private List<Equipo> _listaDeEquipos;
        private List<Partido> _listaDePartidos;

        //lista de partidos y q un partido sea clase e/ 2 equipos

        public Torneo(string nombre)
        {
            _nombre = nombre;
            _cantidadEquipos = 0;
            _cantidadPartidos = 0;
            _listaDeEquipos = new List<Equipo>();
            _listaDePartidos = new List<Partido>();
        }

        public Torneo(string nombre, int cantidadEquipos):this(nombre)
        {
            _cantidadEquipos = cantidadEquipos;
        }

        public Torneo(string nombre, int cantidadEquipos, List<Equipo> listaDeEquipos, List<Partido> listaDePartidos):this(nombre, cantidadEquipos)
        {
            _listaDeEquipos = listaDeEquipos;
            _listaDePartidos = listaDePartidos;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadEquipos { get => _cantidadEquipos; set => _cantidadEquipos = value; }
        public List<Equipo> ListaDeEquipos { get => _listaDeEquipos; set => _listaDeEquipos = value; }
        public List<Partido> ListaDePartidos { get => _listaDePartidos; set => _listaDePartidos = value; }
        public int CantidadPartidos { get => _cantidadPartidos; set => _cantidadPartidos = value; }

        public override string ToString()
        {
            return Nombre;
        }


        public static int BuscarIndice(List<Torneo> torneos, Torneo torneo)
        {
            int indice = -1;
            for (int i = 0; i < torneos.Count; i++)
            {
                if (torneos[i] == torneo)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public static bool operator !=(Torneo t1, Torneo t2)
        {
            return t1.Nombre != t2.Nombre;
        }

        public static bool operator ==(Torneo t1, Torneo t2)
        {
            return t1.Nombre == t2.Nombre;
        }




    }
}

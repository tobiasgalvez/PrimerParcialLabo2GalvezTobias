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

        /// <summary>
        /// Modifico el método ToString() para retornar nombre del torneo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre;
        }

        /// <summary>
        /// Método que permite buscar el indice de un torneo
        /// </summary>
        /// <param name="torneos">lista de torneos</param>
        /// <param name="torneo">torneo a buscar</param>
        /// <returns>si encontró el torneo, su posición. Sino -1</returns>
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

        /// <summary>
        /// Sobrecarga del operador != para verificar si un torneo es distinto de otro
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator !=(Torneo t1, Torneo t2)
        {
            return t1.Nombre != t2.Nombre;
        }

        /// <summary>
        /// Sobrecarga del operador == para verificar si un torneo es igual a otro
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(Torneo t1, Torneo t2)
        {
            return t1.Nombre == t2.Nombre;
        }




    }
}

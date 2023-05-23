using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Equipo
    {
        private string _nombre;
        private List<Jugador> _listaJugadores;
        //private int _maxJugadores = 20;
        private int _cantidadJugadores;
        private string _liga;
        private int _partidosJugados;
        private int _partidosGanados;
        private int _partidosEmpatados;
        private int _partidosPerdidos;
        private int _goles;
        private int _tarjetasAmarillas;
        private int _tarjetasRojas;

        public Equipo()
        {
            _partidosJugados = 0;
            _partidosGanados = 0;
            _partidosEmpatados = 0;
            _partidosPerdidos = 0;
            _goles = 0;
            _tarjetasAmarillas = 0;
            _tarjetasRojas = 0;
            _listaJugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            _nombre = nombre;
            _cantidadJugadores = 0;
        }



        public Equipo(string nombre, string liga) : this(nombre)
        {
            _liga = liga;

        }

        public Equipo(string nombre, List<Jugador> listaJugadores, string liga) : this(nombre, liga)
        {

        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public List<Jugador> ListaJugadores { get => _listaJugadores; set => _listaJugadores = value; }
        public string Liga { get => _liga; set => _liga = value; }
        public int PartidosJugados { get => _partidosJugados; set => _partidosJugados = value; }
        public int PartidosGanados { get => _partidosGanados; set => _partidosGanados = value; }
        public int PartidosEmpatados { get => _partidosEmpatados; set => _partidosEmpatados = value; }
        public int PartidosPerdidos { get => _partidosPerdidos; set => _partidosPerdidos = value; }
        public int CantidadJugadores { get => _cantidadJugadores;  set => _cantidadJugadores = value; }
        public int Goles { get => _goles; set => _goles = value; }
        public int TarjetasAmarillas { get => _tarjetasAmarillas; set => _tarjetasAmarillas = value; }
        public int TarjetasRojas { get => _tarjetasRojas; set => _tarjetasRojas = value; }

        /// <summary>
        /// Método que permite buscar el indice de un equipo
        /// </summary>
        /// <param name="equipos"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static int BuscarIndice(List<Equipo> equipos, Equipo equipo)
        {
            int indice = -1;
            for (int i = 0; i < equipos.Count; i++)
            {
                if (equipos[i] == equipo)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }


        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return e1.Nombre != e2.Nombre;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.Nombre.ToLower() == e2.Nombre.ToLower();
        }

        public override string ToString()
        {
            return Nombre;
        }



    }
}

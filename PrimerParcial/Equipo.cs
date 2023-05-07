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
        private string _liga;
        private int _partidosJugados;
        private int _partidosGanados;
        private int _partidosEmpatados;
        private int _partidosPerdidos;

        public Equipo()
        {
            _partidosJugados = 0;
            _partidosGanados = 0;
            _partidosEmpatados = 0;
            _partidosPerdidos = 0;
        }

        public Equipo(string nombre):base()
        {
            _nombre = nombre;
        }

        public Equipo(string nombre, List<Jugador> listaJugadores, string liga):this(nombre)
        {
            _listaJugadores = listaJugadores;
            _liga = liga;
           
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public List<Jugador> ListaJugadores { get => _listaJugadores; set => _listaJugadores = value; }
        public string Liga { get => _liga; set => _liga = value; }
        public int PartidosJugados { get => _partidosJugados; set => _partidosJugados = value; }
        public int PartidosGanados { get => _partidosGanados; set => _partidosGanados = value; }
        public int PartidosEmpatados { get => _partidosEmpatados; set => _partidosEmpatados = value; }
        public int PartidosPerdidos { get => _partidosPerdidos; set => _partidosPerdidos = value; }
    }
}

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
        private int _maxJugadores = 20;
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
            _listaJugadores = listaJugadores;

        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public List<Jugador> ListaJugadores { get => _listaJugadores; set => _listaJugadores = value; }
        public string Liga { get => _liga; set => _liga = value; }
        public int PartidosJugados { get => _partidosJugados; set => _partidosJugados = value; }
        public int PartidosGanados { get => _partidosGanados; set => _partidosGanados = value; }
        public int PartidosEmpatados { get => _partidosEmpatados; set => _partidosEmpatados = value; }
        public int PartidosPerdidos { get => _partidosPerdidos; set => _partidosPerdidos = value; }
        public int CantidadJugadores { get => _cantidadJugadores; private set => _cantidadJugadores = value; }
        public int Goles { get => _goles; set => _goles = value; }
        public int TarjetasAmarillas { get => _tarjetasAmarillas; set => _tarjetasAmarillas = value; }
        public int TarjetasRojas { get => _tarjetasRojas; set => _tarjetasRojas = value; }

        //public static bool operator +(Equipo e, Jugador j)
        //{
        //    bool retorno = true;

        //    if (e.ListaJugadores.Count < e.CantidadJugadores)
        //    {
        //        foreach (var item in e.ListaJugadores)
        //        {
        //            if (item == j)
        //            {
        //                //retorno = false;
        //                throw new ArgumentException("El jugador ya se encuentra en este equipo");
        //            }
        //        }
        //        e.ListaJugadores.Add(j);
        //    }
        //    else
        //    {
        //        retorno = false;
        //    }


        //    return retorno;


        //}


        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return e1.Nombre != e2.Nombre;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.Nombre == e2.Nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }



    }
}

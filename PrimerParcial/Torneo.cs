﻿using System;
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
        private List<Equipo> _listaDeEquipos;
        private List<Partido> _listaDePartidos;
        private List<Equipo> listaEquipos;

        //lista de partidos y q un partido sea clase e/ 2 equipos



        public Torneo(string nombre, int cantidadEquipos)
        {

            _nombre = nombre;
            _cantidadEquipos = cantidadEquipos;
            _listaDeEquipos = new List<Equipo>();
            _listaDePartidos = new List<Partido>();
        }

        public Torneo(string nombre, int cantidadEquipos, List<Equipo> listaDeEquipos, List<Partido> listaDePartidos):this(nombre, cantidadEquipos)
        {
            _listaDeEquipos = listaDeEquipos;
            _listaDePartidos = listaDePartidos;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadEquipos { get => _cantidadEquipos;}
        public List<Equipo> ListaDeEquipos { get => _listaDeEquipos; set => _listaDeEquipos = value; }
        public List<Partido> ListaDePartidos { get => _listaDePartidos; set => _listaDePartidos = value; }

        public override string ToString()
        {
            return Nombre;
        }




    }
}

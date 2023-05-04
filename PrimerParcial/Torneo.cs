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
        private List<Equipo> _listaDeEquipos;

        public Torneo(string nombre, int cantidadEquipos, List<Equipo> listaDeEquipos)
        {
            _nombre = nombre;
            _cantidadEquipos = cantidadEquipos;
            _listaDeEquipos = listaDeEquipos;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadEquipos { get => _cantidadEquipos;}
        public List<Equipo> ListaDeEquipos { get => _listaDeEquipos; set => _listaDeEquipos = value; }
    }
}

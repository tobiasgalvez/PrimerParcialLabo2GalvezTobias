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

        public Torneo(string nombre, int cantidadEquipos)
        {
            _nombre = nombre;
            _cantidadEquipos = cantidadEquipos;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int CantidadEquipos { get => _cantidadEquipos;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Partido
    {
       // Dictionary<int, string> _partido; //string para ver quien ganó?
        private static int _ultimoId = 0;
        private int _idPartido;
        //private DateTime _fechaPartido;
        private Equipo _equipoLocal;
        private Equipo _equipoVisitante;
        private Enumerados.EResultado _resultado;
        private int _golesLocal;
        private int _golesVisitante;

        public Partido() 
        {
            _ultimoId++;
            _idPartido = _ultimoId;
        }


        public Partido(/*DateTime fechaPartido,*/ Equipo equipoLocal, Equipo equipoVisitante, Enumerados.EResultado resultado, int golesLocal, int golesVisitante):this()
        {
            //_fechaPartido = fechaPartido;
            _equipoLocal = equipoLocal;
            _equipoVisitante = equipoVisitante;
            _resultado = resultado;
            _golesLocal = golesLocal;
            _golesVisitante = golesVisitante;
        }

        public int IdPartido { get => _idPartido; private set => _idPartido = value; }
        //public DateTime FechaPartido { get => _fechaPartido; set => _fechaPartido = value; }
        public Equipo EquipoLocal { get => _equipoLocal; set => _equipoLocal = value; }
        public Equipo EquipoVisitante { get => _equipoVisitante; set => _equipoVisitante = value; }
        public Enumerados.EResultado Resultado { get => _resultado; set => _resultado = value; }
        public int GolesLocal { get => _golesLocal; set => _golesLocal = value; }
        public int GolesVisitante { get => _golesVisitante; set => _golesVisitante = value; }


        public static void ValidarEnfrentamiento(string equipo1, string equipo2)
        {
            if(equipo1 == equipo2)
            {
                throw new Exception("Un equipo no puede jugar consigo mismo!!!");
            }
        }
    }
}

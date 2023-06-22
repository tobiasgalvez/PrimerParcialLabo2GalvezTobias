using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Logs
    {
        private DateTime fecha;
        private string usuario;
        private string accion;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Accion { get => accion; set => accion = value; }
    }
}

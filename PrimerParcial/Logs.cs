using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Logs
    {
        private DateTime _fecha;
        private string _usuario;
        private string _accion;

        public Logs()
        {

        }

        public Logs(DateTime fecha, string usuario, string accion)
        {
            _fecha = fecha;
            _usuario = usuario;
            _accion = accion;
        }

        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Accion { get => _accion; set => _accion = value; }


        public override string ToString()
        {
            return $"[{Fecha}] {Usuario}: {Accion}";
        }
    }
}

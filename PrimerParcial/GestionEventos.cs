using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class GestionEventos
    {
        //delegado para el evento de registro de log
        public delegate void EventoRegistro(Logs registro);

        //Evento
        public event EventoRegistro EventoLog;

        // Método para enviar un registro de log
        /// <summary>
        /// Método que se encarga de enviar un registro de log al evento
        /// </summary>
        /// <param name="registro"></param>
        public void EnviarRegistroLog(Logs registro)
        {
            // Verificar si hay suscriptores al evento
            if (EventoLog != null)
            {
                // Invocar el evento y pasar el registro de log
                EventoLog.Invoke(registro);
            }
        }
    }
}

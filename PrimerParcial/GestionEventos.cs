using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class GestionEventos
    {
        // Declaración del delegado para el evento de registro de log
        public delegate void EventoRegistro(Logs registro);

        // Declaración del evento de registro de log
        public event EventoRegistro EventoLog;

        // Método para enviar un registro de log
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

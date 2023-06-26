using BibliotecaDeClases;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTests
{
    [TestClass]
    public class TestEnviarRegistroLog
    {
        [TestMethod]
        public void EnviarRegistroLog_EventoInvocado()
        {
            //instancia de la clase que contiene el método
            var instancia = new GestionEventos();

            //creo registro
            var registroPrueba = new Logs { Accion = "Mensaje de prueba" };


            instancia.EventoLog += (registro) =>
            {
                // Realizar las verificaciones necesarias en el manejador del evento
                Assert.IsNotNull(registro);
                Assert.AreEqual("Mensaje de prueba", registro.Accion);
            };


            //instancia.EventoLog += delegate (Logs registro)
            //{
            //    Assert.IsNotNull(registro);                               //sin expresiones lambda
            //    Assert.AreEqual("Mensaje de prueba", registro.Accion);
            //};


            instancia.EnviarRegistroLog(registroPrueba);
        }

        [TestMethod]
        public void EnviarRegistroLog_EventoNoInvocado()
        {
            var instancia = new GestionEventos();

            bool eventoInvocado = false;

            // Creo un registro de log de prueba
            var registroPrueba = new Logs { Accion = "Mensaje de prueba" };

            // Llamo al método sin suscribirme
            instancia.EnviarRegistroLog(registroPrueba);

            Assert.IsFalse(eventoInvocado, "evento no invocado si no hay suscriptores.");
        }



    }
}

using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.Excepciones;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTests
{
    [TestClass]
    public class TestValidacionEnfrentamiento
    {
        [TestMethod]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo1EsIgualAEquipo2()
        {
            var equipo1 = new Equipo("Boca", "LPF");
            var equipo2 = new Equipo("Boca", "LPF");



            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }

        [TestMethod]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo1NoTieneSuficientesJugadores()
        {
            int dni = 44521134;

            var equipo1 = new Equipo("Boca", "LPF");
            equipo1.ListaJugadores = new List<Jugador>(); // Sin jugadores

            var equipo2 = new Equipo("River", "LPF");
            equipo2.ListaJugadores = new List<Jugador>();


            for (int i = 0; i < 12; i++)
            {
                var jugador = new Jugador("Juan", "Pérez", new DateTime(2002, 10, 10), dni, "delantero", "Boca");
                equipo2.ListaJugadores.Add(jugador);

                dni--;
            }

            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }

        [TestMethod]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo2NoTieneSuficientesJugadores()
        {
            int dni = 44521134;

            var equipo1 = new Equipo("Boca", "LPF");
            equipo1.ListaJugadores = new List<Jugador>(); // Sin jugadores

            var equipo2 = new Equipo("River", "LPF");
            equipo2.ListaJugadores = new List<Jugador>();

            for (int i = 0; i < 12; i++)
            {
                var jugador = new Jugador("Juan", "Pérez", new DateTime(2002, 10, 10), dni, "delantero", "Boca");
                equipo1.ListaJugadores.Add(jugador);
                
                dni--;
            }


            //Assert
            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }


        [TestMethod]
        public void ValidarEnfrentamiento_NoDeberiaLanzarExceptionSiLosEquiposSonDistintosYAmbosTienenSuficientesJugadores()
        {
            //var jugador1 = new Jugador("Juan", "Pérez", new DateTime(2002, 10, 10), 44521134, "delantero", "Cebollitas");

            int dni = 44521134;

            var equipo1 = new Equipo("Boca", "LPF");
            
            var equipo2 = new Equipo("River", "LPF");
            

            for (int i = 0; i < 12; i++)
            {
                var jugador = new Jugador("Juan", "Pérez", new DateTime(2002, 10, 10), dni, "delantero", "Boca");
                equipo1.ListaJugadores.Add(jugador);
                equipo2.ListaJugadores.Add(jugador);
                dni--;
            }

            Action act = () => Partido.ValidarEnfrentamiento(equipo1, equipo2);
            act.Should().NotThrow<PartidoException>();
        }




    }
}

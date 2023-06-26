using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
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
            // Arrange
            var equipo1 = new Equipo("Boca", "LPF");
            var equipo2 = new Equipo("Boca", "LPF");



            // Act & Assert
            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }

        [TestMethod]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo1NoTieneSuficientesJugadores()
        {
            // Arrange
            var equipo1 = new Equipo("Boca", "LPF");
            equipo1.ListaJugadores = new List<Jugador>(); // Sin jugadores

            var equipo2 = new Equipo("River", "LPF");
            equipo2.ListaJugadores = new List<Jugador>(); // Sin jugadores

            // Act & Assert
            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }

        [TestMethod]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo2NoTieneSuficientesJugadores()
        {
            // Arrange
            var equipo1 = new Equipo("Boca", "LPF");
            equipo1.ListaJugadores = new List<Jugador>(); // Sin jugadores

            var equipo2 = new Equipo("River", "LPF");
            equipo2.ListaJugadores = new List<Jugador>
                { new Jugador("hola","hola",new DateTime(2002,10,10),44521134,"delantero","Cebollitas"),
                  new Jugador("juan","perez",new DateTime(2002,10,10),44521133,"delantero","Cebollitas") }; // Solo 2 jugadores

            //Assert
            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }


        [TestMethod]
        public void ValidarEnfrentamiento_NoDeberiaLanzarExceptionSiLosEquiposSonDistintosYAmbosTienenSuficientesJugadores()
        {
            // Arrange
            var equipo1 = new Equipo("Boca", "LPF");
            equipo1.ListaJugadores = new List<Jugador>
            { new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521134, "delantero", "Cebollitas"),
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521133, "delantero", "Cebollitas"),
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521132, "delantero", "Cebollitas") }; // 3 jugadores

            var equipo2 = new Equipo("River", "LPF");
            equipo2.ListaJugadores = new List<Jugador>
                { new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521134, "delantero", "Cebollitas"),
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521133, "delantero", "Cebollitas"),
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521132, "delantero", "Cebollitas") };// 3 jugadores

            // Act & Assert
            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }




    }
}

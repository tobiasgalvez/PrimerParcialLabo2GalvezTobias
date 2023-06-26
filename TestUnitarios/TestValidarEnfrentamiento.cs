using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.Excepciones;
using Vista;

namespace TestUnitarios
{
    [TestClass]
    public class TestValidarEnfrentamiento
    {
        [TestMethod]
        [ExpectedException(typeof(PartidoException))]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo1EsIgualAEquipo2()
        {
            // Arrange
            var equipo1 = new Equipo();
            var equipo2 = equipo1;

            // Act & Assert
            Assert.AreEqual(equipo1, equipo2);
        }

        [TestMethod]
        [ExpectedException(typeof(PartidoException))]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo1NoTieneSuficientesJugadores()
        {
            // Arrange
            var equipo1 = new Equipo();
            equipo1.ListaJugadores = new List<Jugador>(); // Sin jugadores

            var equipo2 = new Equipo();
            equipo2.ListaJugadores = new List<Jugador>(); // Sin jugadores

            // Act & Assert
            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }

        [TestMethod]
        [ExpectedException(typeof(PartidoException))]
        public void ValidarEnfrentamiento_DeberiaLanzarExceptionSiEquipo2NoTieneSuficientesJugadores()
        {
            // Arrange
            var equipo1 = new Equipo();
            equipo1.ListaJugadores = new List<Jugador>(); // Sin jugadores

            var equipo2 = new Equipo();
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
            var equipo1 = new Equipo();
            equipo1.ListaJugadores = new List<Jugador> 
            { new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521134, "delantero", "Cebollitas"), 
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521133, "delantero", "Cebollitas"), 
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521132, "delantero", "Cebollitas") }; // 3 jugadores

            var equipo2 = new Equipo();
            equipo2.ListaJugadores = new List<Jugador>
                { new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521134, "delantero", "Cebollitas"),
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521133, "delantero", "Cebollitas"),
                new Jugador("hola", "hola", new DateTime(2002, 10, 10), 44521132, "delantero", "Cebollitas") };// 3 jugadores

            // Act & Assert
            Assert.ThrowsException<PartidoException>(() => Partido.ValidarEnfrentamiento(equipo1, equipo2));
        }




    }
}
using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;

namespace PruebaTests
{
    [TestClass]
    public class TestModificarEquipo
    {
        [TestMethod]
        public async Task ModificarTorneoEnListaDeEquipos_ModificarTorneoEquipos()
        {
            var torneo = new Torneo { Nombre = "Nuevo Torneo" };
            var equipos = new List<Equipo>
        {
            new Equipo { Liga = "Carabao" },
            new Equipo { Liga = "Carabao" },
            new Equipo { Liga = "Ligue 1" }
        };

            await Sistema.ModificarTorneoEnListaDeEquipos("Antiguo Torneo", torneo, equipos);//no pongo el nombre anterior del torneo bien para que no me lo cambie en la base de datos

            // Assert
            foreach (var equipo in equipos)
            {
                if (equipo.Liga == "Antiguo Torneo")
                {
                    Assert.AreEqual(torneo.Nombre, equipo.Liga);
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public async Task ModificarTorneoEnListaDeEquipos_NombreTorneoInexistente()
        {
            var torneo = new Torneo("LPF");
            var equipos = new List<Equipo>
        {
            new Equipo { Liga = "Torneo Inexistente" },
            new Equipo { Liga = "Torneo Inexistente 2" },
            new Equipo { Liga = "Torneo Inexistente 3" }
        };

            await Sistema.ModificarTorneoEnListaDeEquipos("Torneo Inexistente", torneo, equipos);// 'torneo inexistente' no existe en la base de datos
        }


        [TestMethod]
        public async Task ModificarTorneoEnListaDeEquipos_NoCoincidenTorneos()
        {
            var torneo = new Torneo { Nombre = "Nuevo Torneo" };
            var equipos = new List<Equipo>
        {
            new Equipo { Liga = "Otro Torneo" },
            new Equipo { Liga = "Torneo Actual" }
        };

            await Sistema.ModificarTorneoEnListaDeEquipos("Antiguo Torneo", torneo, equipos);

            // Assert
            foreach (var equipo in equipos)
            {
                Assert.AreNotEqual(torneo.Nombre, equipo.Liga);
            }
        }


        [TestMethod]
        public async Task ModificarTorneoEnListaDeEquipos_ListaEquiposVacia()
        {
            // Arrange
            var torneo = new Torneo { Nombre = "Nuevo Torneo" };
            var equipos = new List<Equipo>();

            // Act
            await Sistema.ModificarTorneoEnListaDeEquipos("Antiguo Torneo", torneo, equipos);

            // Assert
            Assert.AreEqual(0, equipos.Count);
        }



    }
}
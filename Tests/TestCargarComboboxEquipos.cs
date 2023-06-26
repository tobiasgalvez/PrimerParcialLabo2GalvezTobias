using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;

namespace Tests
{
    [TestClass]
    internal class TestCargarComboboxEquipos
    {
        [TestMethod]
        public async void ModificarTorneoEnListaDeEquipos_ModificarTorneoEquipos()
        {
            var torneo = new Torneo { Nombre = "Nuevo Torneo" };
            var equipos = new List<Equipo>
        {
            new Equipo { Liga = "Antiguo Torneo" },
            new Equipo { Liga = "Otro Torneo" },
            new Equipo { Liga = "Antiguo Torneo" }
        };

            await Sistema.ModificarTorneoEnListaDeEquipos("Antiguo Torneo", torneo, equipos);

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
        public async void ModificarTorneoEnListaDeEquipos_NoCoincidenTorneos()
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
        public async void ModificarTorneoEnListaDeEquipos_ListaEquiposVacia()
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

using PrimerParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Hardcodeo
    {
        //public static void HardcodearProductos(List<Producto> lista)
        //{
        //    Random random = new Random();
        //    lista.Add(new Producto("Cereales", random.Next(1,100), random.Next(200,500)));
        //    lista.Add(new Producto("Papas fritas", random.Next(1, 100), random.Next(200, 500)));
        //    lista.Add(new Producto("Chocolate", random.Next(1, 100), random.Next(200, 500)));
        //}

        public static void HardcodearJugadores(List<Jugador> lista)
        {
           // Random random = new Random();
            lista.Add(new Jugador("Tobias", "Galvez" , 20, 44521134, Enumerados.EPosiciones.Delantero.ToString(), "El Rejunte"));
            lista.Add(new Jugador("Juan", "Galvez", 54, 20508973, Enumerados.EPosiciones.Defensor.ToString(), "Los mismos de siempre"));
            lista.Add(new Jugador("Federico", "Sanchez", 20, 43123444, Enumerados.EPosiciones.Mediocampista.ToString(), "El Rejunte"));


        }


        public static void HardcodearEquipos(List<Equipo> listaEquipos, List<Jugador> listaJugadores)
        {
            // Random random = new Random();
            listaEquipos.Add(new Equipo("El Rejunte", listaJugadores, "Carabao"));
            listaEquipos.Add(new Equipo("Los mismos de siempre", listaJugadores, "Carabao"));


        }

        public static void HardcodearUsuarios(List<Usuario> lista)
        {
            lista.Add(new Usuario("Tobias", "Galvez", 19, 44521134, "tobigalvez", "hola1234"));
            lista.Add(new Usuario("Gonzalo", "Paz", 29, 39678521, "gonza.paz", "14876"));
            lista.Add(new Usuario("Juan", "Regueira", 38, 34785441, "juancito_regue", "juanitoR"));

        }
    }
}

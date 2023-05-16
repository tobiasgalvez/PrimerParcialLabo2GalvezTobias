using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ManejadorCsv
    {
        private readonly string _csvFilePath;

        public ManejadorCsv(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<Jugador> LeerJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();
            DateTime fechaNacimiento;

            using (StreamReader reader = new StreamReader(_csvFilePath))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');
                    fechaNacimiento = DateTime.Parse(partes[2]);

                    jugadores.Add(new Jugador(partes[0], partes[1], fechaNacimiento, int.Parse(partes[3]), partes[4], partes[5]));
                }
            }

            return jugadores;
        }

        public void AgregarJugador(Jugador jugador)
        {
            using (var sw = new StreamWriter(_csvFilePath, true))
            {
                sw.WriteLine($"{jugador.Nombre},{jugador.Apellido}, {jugador.FechaDeNacimiento}, {jugador.Dni},{jugador.Posicion},{jugador.Equipo}");
            }
        }

        public void ModificarJugador(Jugador jugadorOriginal, Jugador jugadorModificado)
        {
            var jugadores = LeerJugadores();
            int indice = Jugador.BuscarIndice(jugadores, jugadorOriginal);

            

            if (indice != -1)
            {
                jugadores[indice] = jugadorModificado;
                GuardarJugadores(jugadores);
            }
        }

        public void EliminarJugador(Jugador jugador)
        {
            var jugadores = LeerJugadores();
            foreach (var item in jugadores)
            {
                if(jugador == item)
                {
                    jugadores.Remove(item);
                }
            }
            GuardarJugadores(jugadores);
        }

        private void GuardarJugadores(List<Jugador> jugadores)
        {
            using (var sw = new StreamWriter(_csvFilePath, false))
            {
                //sw.WriteLine("Nombre,Apellido,FechaDeNacimiento,Dni,Posicion,Equipo");
                foreach (var jugador in jugadores)
                {
                    sw.WriteLine($"{jugador.Nombre},{jugador.Apellido}, {jugador.FechaDeNacimiento}, {jugador.Dni},{jugador.Posicion},{jugador.Equipo}");
                }
            }
        }
    }
}

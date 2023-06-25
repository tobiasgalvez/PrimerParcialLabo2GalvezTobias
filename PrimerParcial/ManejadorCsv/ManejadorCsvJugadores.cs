using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases.Entidades;

namespace BibliotecaDeClases.ManejadorCsv
{
    public class ManejadorCsvJugadores : ManejadorCsvBase<Jugador>
    {

        public ManejadorCsvJugadores(string csvFilePath) : base(csvFilePath) { }

        public override List<Jugador> LeerDatos()
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

        public override void AgregarDato(Jugador jugador)
        {
            using (var sw = new StreamWriter(_csvFilePath, true)) // el using sería como un try-finally en donde el finally tira un dispose al archivo 
            //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                sw.WriteLine($"{jugador.Nombre},{jugador.Apellido}, {jugador.FechaDeNacimiento}, {jugador.Dni},{jugador.Posicion},{jugador.Equipo}");
            }
        }

        public override void ModificarDato(Jugador jugadorOriginal, Jugador jugadorModificado)
        {
            var jugadores = LeerDatos();
            int indice = Jugador.BuscarIndice(jugadores, jugadorOriginal);



            if (indice != -1)
            {
                jugadores[indice] = jugadorModificado;
                GuardarDatos(jugadores);
            }
        }

        public override void EliminarDato(Jugador jugador)
        {
            var jugadores = LeerDatos();
            var jugadoresAEliminar = new List<Jugador>();

            foreach (var item in jugadores)
            {
                if (jugador == item)
                {
                    jugadoresAEliminar.Add(item);
                }
            }

            foreach (var item in jugadoresAEliminar)
            {
                jugadores.Remove(item);
            }

            GuardarDatos(jugadores);
        }

        public override void GuardarDatos(List<Jugador> jugadores)
        {
            using (var sw = new StreamWriter(_csvFilePath, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
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

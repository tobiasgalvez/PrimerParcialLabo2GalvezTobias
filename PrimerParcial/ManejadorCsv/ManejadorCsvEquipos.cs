using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorCsv
{
    public class ManejadorCsvEquipos : ManejadorCsvBase<Equipo>
    {
        public ManejadorCsvEquipos(string csvFilePath) : base(csvFilePath)
        {
        }

        public override List<Equipo> LeerDatos()
        {
            List<Equipo> equipos = new List<Equipo>();
            List<Jugador> jugadores = new List<Jugador>();
            List<Partido> partidos = new List<Partido>();

            string pathJugadores = "jugadores.csv";
            string pathPartidos = "partidos.csv";

            ManejadorCsvJugadores manejadorCsvJugadores = new ManejadorCsvJugadores(pathJugadores);
            ManejadorCsvPartidos manejadorCsvPartidos = new ManejadorCsvPartidos(pathPartidos);

            using (StreamReader reader = new StreamReader(_csvFilePath))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');
                    // fechaNacimiento = DateTime.Parse(partes[2]);

                    equipos.Add(new Equipo(partes[0], partes[1]));
                }
            }

            jugadores = manejadorCsvJugadores.LeerDatos();
            partidos = manejadorCsvPartidos.LeerDatos();

            AsignarJugadoresAEquipos(equipos, jugadores); //no se si está bien
            //AsignarResultadosAEquipos(equipos, partidos);
            AsignarResultadosAEquipos(equipos, partidos);

            GuardarDatos(equipos);


            return equipos;
        }

        public override void AgregarDato(Equipo equipo)
        {
            using (var sw = new StreamWriter(_csvFilePath, true)) // el using sería como un try-finally en donde el finally tira un dispose al archivo 
            {
                sw.WriteLine($"{equipo.Nombre},{equipo.Liga},{equipo.CantidadJugadores},{equipo.PartidosGanados},{equipo.PartidosEmpatados},{equipo.PartidosPerdidos},{equipo.TarjetasAmarillas},{equipo.TarjetasRojas}");
            }
        }

        public override void ModificarDato(Equipo equipoOriginal, Equipo equipoModificado)
        {
            var equipos = LeerDatos();
            int indice = Equipo.BuscarIndice(equipos, equipoOriginal);

            if (indice != -1)
            {
                equipos[indice] = equipoModificado;
                GuardarDatos(equipos);
            }
        }

        public override void EliminarDato(Equipo equipo)
        {
            //var equipos = LeerDatos();
            //foreach (var item in equipos)
            //{
            //    if (equipo == item)
            //    {
            //        equipos.Remove(item);
            //    }
            //}
            //GuardarDatos(equipos);

            var equipos = LeerDatos();
            var equiposAEliminar = new List<Equipo>();

            foreach (var item in equipos)
            {
                if (equipo == item)
                {
                    equiposAEliminar.Add(item);
                }
            }

            foreach (var item in equiposAEliminar)
            {
                equipos.Remove(item);
            }

            GuardarDatos(equipos);
        }

        public override void GuardarDatos(List<Equipo> lista)
        {
            using (var sw = new StreamWriter(_csvFilePath, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                //sw.WriteLine("Nombre,Liga,ListaJugadores,CantidadJugadores");
                foreach (var equipo in lista)
                {
                    sw.WriteLine($"{equipo.Nombre},{equipo.Liga},{equipo.CantidadJugadores},{equipo.PartidosGanados},{equipo.PartidosEmpatados},{equipo.PartidosPerdidos},{equipo.TarjetasAmarillas},{equipo.TarjetasRojas}");
                }
            }
        }


        private void AsignarJugadoresAEquipos(List<Equipo> equipos, List<Jugador> jugadores)
        {
            foreach (var jugador in jugadores)
            {
                foreach (var equipo in equipos)
                {
                    if (jugador.Equipo == equipo.Nombre)
                    {
                            equipo.ListaJugadores.Add(jugador);
                            equipo.CantidadJugadores++;
                    }
                }
            }
        }

        private void AsignarResultadosAEquipos(List<Equipo> equipos, List<Partido> partidos)
        {
            //foreach (var jugador in jugadores)
            //{
            //    Equipo equipo = equipos.FirstOrDefault(e => e.Nombre == jugador.Equipo);
            //    if (equipo is not null)
            //    {
            //        equipo.ListaJugadores.Add(jugador);
            //    }
            //}
            foreach (var partido in partidos)
            {
                foreach (var equipo in equipos)
                {
                    if (partido.EquipoLocal.Nombre == equipo.Nombre)
                    {
                        equipo.PartidosJugados++;
                        equipo.Goles += partido.GolesLocal;
                        equipo.TarjetasAmarillas += partido.EquipoLocal.TarjetasAmarillas;
                        equipo.TarjetasRojas += partido.EquipoLocal.TarjetasRojas;
                        if (partido.Resultado == Enumerados.EResultado.Local)
                            equipo.PartidosGanados++;
                        else if (partido.Resultado == Enumerados.EResultado.Empate)
                            equipo.PartidosEmpatados++;
                        else
                            equipo.PartidosPerdidos++;
                    }
                    if(partido.EquipoVisitante.Nombre == equipo.Nombre)
                    {
                        equipo.PartidosJugados++;
                        equipo.Goles += partido.GolesVisitante;
                        equipo.TarjetasAmarillas += partido.EquipoVisitante.TarjetasAmarillas;
                        equipo.TarjetasRojas += partido.EquipoVisitante.TarjetasRojas;
                        if (partido.Resultado == Enumerados.EResultado.Visitante)
                            equipo.PartidosGanados++;
                        else if (partido.Resultado == Enumerados.EResultado.Empate)
                            equipo.PartidosEmpatados++;
                        else
                            equipo.PartidosPerdidos++;
                    }
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases.ManejadorCsv
{
    public class ManejadorCsvTorneos : ManejadorCsvBase<Torneo>
    {
        public ManejadorCsvTorneos(string csvFilePath) : base(csvFilePath)
        {
        }

        public override List<Torneo> LeerDatos()
        {
            List<Torneo> torneos = new List<Torneo>();
            List<Equipo> equiposDelTorneo = new List<Equipo>();
            List<Partido> partidosDelTorneo = new List<Partido>();

            string pathEquipos = "equipos.csv";
            string pathPartidos = "partidos.csv";
            ManejadorCsvEquipos manejadorCsvEquipos = new ManejadorCsvEquipos(pathEquipos);
            ManejadorCsvPartidos manejadorCsvPartidos = new ManejadorCsvPartidos(pathPartidos);

            using (StreamReader reader = new StreamReader(_csvFilePath))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');

                    torneos.Add(new Torneo(partes[0]));
                }
            }

            equiposDelTorneo = manejadorCsvEquipos.LeerDatos();
            partidosDelTorneo = manejadorCsvPartidos.LeerDatos();

            AsignarEquiposATorneo(torneos, equiposDelTorneo);
            AsignarPartidosATorneo(torneos, partidosDelTorneo);

            GuardarDatos(torneos);

            return torneos;
        }

        public override void AgregarDato(Torneo torneo)
        {
            using (var sw = new StreamWriter(_csvFilePath, true)) // el using sería como un try-finally en donde el finally tira un dispose al archivo 
            {
                sw.WriteLine($"{torneo.Nombre},{torneo.CantidadEquipos}");
            }
        }

        public override void ModificarDato(Torneo torneoOriginal, Torneo torneoModificado)
        {
            var torneos = LeerDatos();
            int indice = Torneo.BuscarIndice(torneos, torneoOriginal);

            if (indice != -1)
            {
                torneos[indice] = torneoModificado;
                GuardarDatos(torneos);
            }
        }

        public override void EliminarDato(Torneo torneo)
        {
            var torneos = LeerDatos();
            var torneosAEliminar = new List<Torneo>();
            //foreach (var item in partidos)
            //{
            //    if (partido == item)
            //    {
            //        partidos.Remove(item);
            //    }
            //}
            //GuardarDatos(partidos);

            foreach (var item in torneos)
            {
                if (torneo == item)
                {
                    torneosAEliminar.Add(item);
                }
            }

            foreach (var item in torneosAEliminar)
            {
                torneos.Remove(item);
            }

            GuardarDatos(torneos);


        }

        public override void GuardarDatos(List<Torneo> torneos)
        {
            using (var sw = new StreamWriter(_csvFilePath, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                foreach (var torneo in torneos)
                {
                    sw.WriteLine($"{torneo.Nombre},{torneo.CantidadEquipos}");
                }
            }
        }



        private void AsignarEquiposATorneo(List<Torneo> torneos, List<Equipo> equipos)
        {
            foreach (var equipo in equipos)
            {
                foreach (var torneo in torneos)
                {
                    if (equipo.Liga == torneo.Nombre)
                    {
                       torneo.ListaDeEquipos.Add(equipo);
                       torneo.CantidadEquipos++;
                    }
                }
            }
        }

        private void AsignarPartidosATorneo(List<Torneo> torneos, List<Partido> partidos)
        {
            foreach (var partido in partidos)
            {
                foreach (var torneo in torneos)
                {
                    if (partido.Torneo == torneo.Nombre)
                    {
                        torneo.ListaDePartidos.Add(partido);
                        torneo.CantidadPartidos++;
                    }
                }
            }
        }

    }
}

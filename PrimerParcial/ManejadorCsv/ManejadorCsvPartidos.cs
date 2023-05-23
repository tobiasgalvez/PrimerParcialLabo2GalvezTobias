using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases.ManejadorCsv
{
    public class ManejadorCsvPartidos : ManejadorCsvBase<Partido>
    {
        public ManejadorCsvPartidos(string csvFilePath) : base(csvFilePath)
        {
        }

        public override List<Partido> LeerDatos()
        {
            List<Partido> partidos = new List<Partido>();
            Equipo equipo1;
            Equipo equipo2;
       
            EResultado resultado;

            using (StreamReader reader = new StreamReader(_csvFilePath))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(',');
                    equipo1 = new Equipo(partes[0]);
                    equipo2 = new Equipo(partes[1]);

                    //equipo1.Goles = int.Parse(partes[3]);
                    //equipo2.Goles = int.Parse(partes[4]);
                    resultado = Enum.Parse<EResultado>(partes[2]);

                    partidos.Add(new Partido(equipo1, equipo2, resultado, int.Parse(partes[3]), int.Parse(partes[4]), partes[5], int.Parse(partes[6]), int.Parse(partes[7]), int.Parse(partes[8]), int.Parse(partes[9])));
                }
            }
            return partidos;
        }

        public override void AgregarDato(Partido partido)
        {
            using (var sw = new StreamWriter(_csvFilePath, true)) // el using sería como un try-finally en donde el finally tira un dispose al archivo 
            {
                sw.WriteLine($"{partido.EquipoLocal},{partido.EquipoVisitante},{partido.Resultado},{partido.EquipoLocal.Goles},{partido.EquipoVisitante.Goles},{partido.Torneo},{partido.TarjetasAmarillasLocal},{partido.TarjetasRojasLocal},{partido.TarjetasAmarillasVisitante},{partido.TarjetasRojasVisitante}");
            }
        }

        public override void ModificarDato(Partido partidoOriginal, Partido partidoModificado)
        {
            //var partidos = LeerDatos();
            //int indice = Partido.BuscarIndice(partidos, partidoOriginal,);

            //if (indice != -1)
            //{
            //    partidos[indice] = partidoModificado;
            //    GuardarDatos(partidos);
            //}
        }

        public void ModificarPartido(Partido partidoOriginal, Partido partidoModificado, string nombreAnterior)
        {
            var partidos = LeerDatos();
            int indice = Partido.BuscarIndice(partidos, partidoOriginal, nombreAnterior);

            if (indice != -1)
            {
                partidos[indice] = partidoModificado;
                GuardarDatos(partidos);
            }
        }

        public override void EliminarDato(Partido partido)
        {
            var partidos = LeerDatos();
            var partidosAEliminar = new List<Partido>();
            //foreach (var item in partidos)
            //{
            //    if (partido == item)
            //    {
            //        partidos.Remove(item);
            //    }
            //}
            //GuardarDatos(partidos);

            foreach (var item in partidos)
            {
                if (partido == item)
                {
                    partidosAEliminar.Add(item);
                }
            }

            foreach (var item in partidosAEliminar)
            {
                partidos.Remove(item);
            }

            GuardarDatos(partidos);




        }

        public override void GuardarDatos(List<Partido> partidos)
        {
            using (var sw = new StreamWriter(_csvFilePath, false)) //el false sobrescribe el archivo, mientras que el true agrega contenido al archivo existente
            {
                foreach (var partido in partidos)
                {
                    sw.WriteLine($"{partido.EquipoLocal},{partido.EquipoVisitante},{partido.Resultado},{partido.GolesLocal},{partido.GolesVisitante},{partido.Torneo},{partido.TarjetasAmarillasLocal},{partido.TarjetasRojasLocal},{partido.TarjetasAmarillasVisitante},{partido.TarjetasRojasVisitante}");
                }
            }
        }

    }
}

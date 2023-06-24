using BibliotecaDeClases.ManejadorCsv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.ManejadorSQL;

namespace Vista
{
    public partial class FormRanking : Form
    {
        List<Equipo> Equipos { get; set; }
        //ManejadorCsvEquipos csvEquipos;
        IManejadorSQL<Equipo> sqlEquipos;
        public FormRanking()
        {
            InitializeComponent();
            Equipos = new List<Equipo>();
            //csvEquipos = new ManejadorCsvEquipos("equipos.csv");
            sqlEquipos = new ManejadorSqlEquipos(@"Server=.;Database=aplicacion;Trusted_Connection=True;");


        }

        private async void FormRankingHistórico_Load(object sender, EventArgs e)
        {
            //Equipos = csvEquipos.LeerDatos();
            Equipos = await sqlEquipos.LeerDatosAsync();
            //Equipos = OrdenarEquipos(Equipos);
        }
        private void btn_másGoles_Click(object sender, EventArgs e)
        {
            int i = 1;
            StringBuilder stringBuilder = new StringBuilder();

            Equipos = OrdenarEquiposPorGolesConvertidos(Equipos);
            foreach (var item in Equipos)
            { 
                stringBuilder.AppendLine($"{i.ToString()}. {item.Nombre}----- {item.Goles}");
                i++;
            }

            MessageBox.Show(stringBuilder.ToString());
        }

 

        private void btn_masPartidos_Click(object sender, EventArgs e)
        {
            int i = 1;
            StringBuilder stringBuilder = new StringBuilder();

            Equipos = OrdenarEquiposPorPartidosJugados(Equipos);
            foreach (var item in Equipos)
            {
                stringBuilder.AppendLine($"{i.ToString()}. {item.Nombre}----- {item.PartidosJugados}");
                i++;
            }

            MessageBox.Show(stringBuilder.ToString());
        }

        private void btn_masTarjetasAmarillas_Click(object sender, EventArgs e)
        {
            int i = 1;
            StringBuilder stringBuilder = new StringBuilder();

            Equipos = OrdenarEquiposPorTarjetasAmarillas(Equipos);
            foreach (var item in Equipos)
            {
                stringBuilder.AppendLine($"{i.ToString()}. {item.Nombre}----- {item.TarjetasAmarillas}");
                i++;
            }

            MessageBox.Show(stringBuilder.ToString());
        }

        private void btn_masTarjetasRojas_Click(object sender, EventArgs e)
        {
            int i = 1;
            StringBuilder stringBuilder = new StringBuilder();

            Equipos = OrdenarEquiposPorTarjetasRojas(Equipos);
            foreach (var item in Equipos)
            {
                stringBuilder.AppendLine($"{i.ToString()}. {item.Nombre}----- {item.TarjetasRojas}");
                i++;
            }

            MessageBox.Show(stringBuilder.ToString());
        }



        public List<Equipo> OrdenarEquiposPorPartidosJugados(List<Equipo> equipos)
        {
            var equiposOrdenadosPartidos = equipos.OrderByDescending(e => e.PartidosJugados).ToList();

            return equiposOrdenadosPartidos;
        }

        public List<Equipo> OrdenarEquiposPorGolesConvertidos(List<Equipo> equipos)
        {
            var equiposOrdenadosGoles = equipos.OrderByDescending(e => e.Goles).ToList();

            return equiposOrdenadosGoles;
        }

        public List<Equipo> OrdenarEquiposPorTarjetasRojas(List<Equipo> equipos)
        {
            var equiposOrdenadosTarjetasRojas = equipos.OrderByDescending(e => e.TarjetasRojas).ToList();

            return equiposOrdenadosTarjetasRojas;
        }

        public List<Equipo> OrdenarEquiposPorTarjetasAmarillas(List<Equipo> equipos)
        {
            var equiposOrdenadosTarjetasAmarillas = equipos.OrderByDescending(e => e.TarjetasAmarillas).ToList();

            return equiposOrdenadosTarjetasAmarillas;
        }
    }
}

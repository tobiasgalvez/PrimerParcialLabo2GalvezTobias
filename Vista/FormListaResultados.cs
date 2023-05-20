using BibliotecaDeClases;
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

namespace Vista
{
    public partial class FormListaResultados : Form
    {
        List<Partido> Partidos { get; set; }
        List<Equipo> Equipos { get; set; }
        ManejadorCsvPartidos csvPartidos;
        ManejadorCsvEquipos csvEquipos;

        public FormListaResultados()
        {
            InitializeComponent();
            Partidos = new List<Partido>();
            Equipos = new List<Equipo>();
            csvPartidos = new ManejadorCsvPartidos("partidos.csv");
            csvEquipos = new ManejadorCsvEquipos("equipos.csv");
        }

        private void FormListaResultados_Load(object sender, EventArgs e)
        {

            Partidos = csvPartidos.LeerDatos();
            Equipos = csvEquipos.LeerDatos();
            //csvPartidos.EliminarDato(Partidos[0]);
            //csvPartidos.EliminarDato(Partidos[1]);
            dgv_listadoResultados.DataSource = Partidos;
            this.MaximizeBox = false;
        }


        private void btn_agregarResultado_Click(object sender, EventArgs e)
        {
            FormAgregarResultado formAgregarResultado = new FormAgregarResultado();
            bool esIgual = false;

            DialogResult resultado = formAgregarResultado.ShowDialog(); //para poner foco en el form alta equipo
            if (resultado == DialogResult.OK)
            {
                Partido partidoIngresado = formAgregarResultado.Partido;
                //MessageBox.Show("Resultado cargado con exito!!!!");
                foreach (var item in Partidos)
                {
                    if (partidoIngresado == item)
                    {
                        esIgual = true;
                    }
                }
                if (!esIgual)
                {
                    Partidos.Add(partidoIngresado);
                    csvPartidos.AgregarDato(partidoIngresado);

                    ActualizarDataGrid();
                    MessageBox.Show("Resultado cargado con exito!!!!");

                }
                else
                {
                    MessageBox.Show($"El partido '{partidoIngresado.EquipoLocal}' vs '{partidoIngresado.EquipoVisitante}' ya ha sido jugado");
                }
            }
            else
            {
                MessageBox.Show("Se canceló el resultado!!!!");
            }
        }


        private void ActualizarDataGrid()
        {
            //if(Partidos.Count > 0)
            //{
            //    dgv_listadoResultados.DataSource = null; // limpiar el DataSource para actualizar los datos
            //    dgv_listadoResultados.DataSource = Partidos; // volver a vincular con la lista de jugadores actualizada
            //    dgv_listadoResultados.Refresh(); // refrescar el datagrid
            //}
            //else
            //{
            //    dgv_listadoResultados.Visible = false;
            //    // lbl "sin datos"
            //}

            dgv_listadoResultados.DataSource = null; // limpiar el DataSource para actualizar los datos
            dgv_listadoResultados.DataSource = Partidos; // volver a vincular con la lista de jugadores actualizada
            dgv_listadoResultados.Refresh(); // refrescar el datagrid
        }
    }
}

using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.ManejadorCsv;
using BibliotecaDeClases.ManejadorSQL;
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
        Usuario UsuarioIngresado { get; set; }
        GestionEventos GestionEventos { get; set; }
        //ManejadorCsvPartidos csvPartidos;
        //ManejadorCsvEquipos csvEquipos;
        IManejadorSQL<Partido> sqlPartidos;
        IManejadorSQL<Equipo> sqlEquipos;

        public FormListaResultados(Usuario usuarioIngresado, GestionEventos gestionEventos)
        {
            InitializeComponent();
            Partidos = new List<Partido>();
            Equipos = new List<Equipo>();
            //csvPartidos = new ManejadorCsvPartidos("partidos.csv");
            //csvEquipos = new ManejadorCsvEquipos("equipos.csv");
            sqlPartidos = new ManejadorSQLResultados(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
            sqlEquipos = new ManejadorSqlEquipos(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
            UsuarioIngresado = usuarioIngresado;
            GestionEventos = gestionEventos;
        }

        private async void FormListaResultados_Load(object sender, EventArgs e)
        {

            //Partidos = csvPartidos.LeerDatos();
            //Equipos = csvEquipos.LeerDatos();
            Equipos = await sqlEquipos.LeerDatosAsync();
            Partidos = await sqlPartidos.LeerDatosAsync();

            //csvPartidos.EliminarDato(Partidos[0]);
            //csvPartidos.EliminarDato(Partidos[1]);
            //csvPartidos.EliminarDato(Partidos[2]);
            //csvPartidos.EliminarDato(Partidos[3]);
            //csvPartidos.EliminarDato(Partidos[4]);
            //csvPartidos.EliminarDato(Partidos[5]);
            //csvPartidos.EliminarDato(Partidos[6]);

            dgv_listadoResultados.DataSource = Partidos;
            this.MaximizeBox = false;
        }


        private void btn_agregarResultado_Click(object sender, EventArgs e)
        {
            FormAgregarResultado formAgregarResultado = new FormAgregarResultado();
            
            DialogResult resultado = formAgregarResultado.ShowDialog(); //para poner foco en el form alta equipo
            if (resultado == DialogResult.OK)
            {
                Partido partidoIngresado = formAgregarResultado.Partido;
               
                Partidos.Add(partidoIngresado);
                //csvPartidos.AgregarDato(partidoIngresado);
                sqlPartidos.AgregarDatoAsync(partidoIngresado);

                ActualizarDataGrid();
                MessageBox.Show("Resultado cargado con exito!!!!");
                Logs registro = new Logs
                {
                    Fecha = DateTime.Now,
                    Usuario = UsuarioIngresado.User,
                    Accion = "Agregó un nuevo resultado",
                };

                GestionEventos.EnviarRegistroLog(registro);

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

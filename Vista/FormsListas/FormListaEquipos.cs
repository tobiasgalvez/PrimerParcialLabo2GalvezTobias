using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.Informes;
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
    public partial class FormListaEquipos : Form
    {
        List<Equipo> Equipos { get; set; }
        //ManejadorCsvEquipos csvEquipos;
        IManejadorSQL<Equipo> manejadorSqlEquipos;
        public Usuario UsuarioIngresado { get; set; }
        public GestionEventos GestionEventos { get; set; }
        //List<Jugador> listaJugadores;


        public FormListaEquipos(Usuario usuarioIngresado,GestionEventos evento)
        {
            InitializeComponent();
            Equipos = new List<Equipo>();
            //csvEquipos = new ManejadorCsvEquipos("equipos.csv");
            manejadorSqlEquipos = new ManejadorSqlEquipos(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
            GestionEventos = evento;
            UsuarioIngresado = usuarioIngresado;
            //listaJugadores = new List<Jugador>();
        }

        private async void FormListaEquipos_Load(object sender, EventArgs e)
        {

            //Equipos = csvEquipos.LeerDatos();
            Equipos = await manejadorSqlEquipos.LeerDatosAsync();

            dgv_listadoEquipos.DataSource = Equipos;
            this.MaximizeBox = false;

            if (UsuarioIngresado.Rol == Enumerados.ERol.Admin)
            {
                btn_exportarCsv.Visible = true;
                btn_exportarJson.Visible = true;
            }

        }

        private void btn_agregarEquipo_Click(object sender, EventArgs e)
        {
            FormAltaEquipo altaEquipo = new FormAltaEquipo();
            
            bool esIgual = false;
            DialogResult resultado = altaEquipo.ShowDialog(); //para poner foco en el form alta equipo
            if (resultado == DialogResult.OK)
            {
                Equipo equipoIngresado = altaEquipo.Equipo;
                //equipoIngresado.Nombre.ToLower(); // por si ingresa el mismo equipo pero sin mayusculas
                foreach (var item in Equipos)
                {
                    if (equipoIngresado == item)
                    {
                        esIgual = true;
                    }
                }
                if (!esIgual)
                {
                    Equipos.Add(equipoIngresado);
                    //csvEquipos.AgregarDato(equipoIngresado);
                    manejadorSqlEquipos.AgregarDatoAsync(equipoIngresado);
                    //DataGridHelp.ActualizarDataGrid(dgv_listadoEquipos, Equipos);
                    ActualizarDataGrid();
                    Logs registro = new Logs
                    {
                        Fecha = DateTime.Now,
                        Usuario = UsuarioIngresado.User,
                        Accion = $"Agregó un nuevo equipo: {equipoIngresado}",
                    };

                    GestionEventos.EnviarRegistroLog(registro);

                    MessageBox.Show("equipo cargado con exito!!!!");

                }
                else
                {
                    MessageBox.Show($"El equipo {equipoIngresado.Nombre} ya ha sido agregado");
                }
            }
            else
            {
                MessageBox.Show("Se canceló el alta de un equipo!!!!");
            }
        }

        private void ActualizarDataGrid()
        {
            dgv_listadoEquipos.DataSource = null; // limpiar el DataSource para actualizar los datos
            dgv_listadoEquipos.DataSource = Equipos; // volver a vincular con la lista de jugadores actualizada
            dgv_listadoEquipos.Refresh(); // refrescar el datagrid
        }

        private void btn_exportarCsv_Click(object sender, EventArgs e)
        {
            txt_path.Visible = true;
            btn_exportar.Visible = true;
            btn_exportarCsv.Visible = false;
            btn_exportarJson.Visible = false;

            txt_path.PlaceholderText = "Ingrese path para csv";
        }

        private void btn_exportarJson_Click(object sender, EventArgs e)
        {
            txt_path.Visible = true;
            btn_exportar.Visible = true;
            btn_exportarCsv.Visible = false;
            btn_exportarJson.Visible = false;

            txt_path.PlaceholderText = "Ingrese path para json";
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            string auxPath;
            IInformes<Equipo> informesEquipos;
            bool extensionJson = false;

            if (txt_path.PlaceholderText == "Ingrese path para json")
            {
                extensionJson = true;
            }

            try
            {
                auxPath = txt_path.Text;
                if (extensionJson)
                    Validacion.ValidarExtensionJson(auxPath);
                else
                    Validacion.ValidarExtensionCsv(auxPath);




                informesEquipos = new InformesEquipos(auxPath);

                if (extensionJson)
                    informesEquipos.GuardarDatosJson(Equipos);
                else
                    informesEquipos.GuardarDatosCsv(Equipos);

                MessageBox.Show("Archivo generado con exito!!!");

                lbl_msjError.Visible = false;
                txt_path.Visible = false;
                btn_exportarCsv.Visible = true;
                btn_exportarJson.Visible = true;
                btn_exportar.Visible = false;



            }
            catch (Exception excepcion)
            {
                //MessageBox.Show(excepcion.Message.ToString());
                lbl_msjError.Visible = true;
                lbl_msjError.Text = excepcion.Message;

            }


        }

        //public void OcultarControlMaximizar(Form formulario)
        //{
        //    formulario.MaximizeBox = false;
        //}



    }
}

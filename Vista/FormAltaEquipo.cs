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
    public partial class FormAltaEquipo : Form
    {
        public Equipo Equipo { get; set; }
        List<Torneo> Torneos { get; set; }
        List<Equipo> Equipos { get; set; }
        private string _nombreAnterior;


        //ManejadorCsvTorneos csvTorneos;
        IManejadorSQL<Torneo> sqlTorneos;
        public FormAltaEquipo()
        {
            InitializeComponent();
            //csvTorneos = new ManejadorCsvTorneos("torneos.csv");
            sqlTorneos = new ManejadorSQLTorneos(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
        }

        public FormAltaEquipo(List<Equipo> listaEquipos):this()
        {
            Equipos = new List<Equipo>();
            Equipos = listaEquipos;

            CambiarHerramientasParaModificar();
        }

        public string NombreAnterior { get => _nombreAnterior; set => _nombreAnterior = value; }
        

        private async void FormAltaEquipo_Load(object sender, EventArgs e)
        {

            //Torneos = csvTorneos.LeerDatos();
            Torneos = await sqlTorneos.LeerDatosAsync();

            cbo_torneos.DataSource = Torneos;
            comboBox1.DataSource = Equipos;

            if(Equipos is not null)
            {
                Equipo = (Equipo)comboBox1.SelectedItem;
                CargarDatosEquipo(Equipo);
            }
        }

        private void CargarDatosEquipo(Equipo equipo)
        {
            this.cbo_torneos.Text = equipo.Liga;
            this.txt_altaNombre.Text = equipo.Nombre;
            NombreAnterior = equipo.Nombre;

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string auxNombre;
                string auxTorneo;

                auxNombre = txt_altaNombre.Text;
                auxTorneo = cbo_torneos.Text;

                Validacion.ValidarString(auxNombre);

                Equipo = new Equipo(auxNombre, auxTorneo);

                this.DialogResult = DialogResult.OK;


            }
            catch(Exception excepcion)
            {
                lbl_msjError.Text = excepcion.Message;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void CambiarHerramientasParaModificar()
        {
            this.lbl_equipoModificar.Visible = true;
            this.comboBox1.Visible = true;
            this.lbl_nombre.Text = "Nuevo Nombre:";
            this.btn_confirmar.Text = "Modificar";
            //this.cbo_torneos.Visible = false;
            //this.lbl_torneoAJugar.Visible = false;
            //this.cbo_torneos.SelectedItem = Equipo.Liga;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDatosEquipo((Equipo)comboBox1.SelectedItem);
        }
    }
}

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
    public partial class FormAltaTorneo : Form
    {
        private string _nombreAnterior;
        public Torneo Torneo { get; set; }
        public List<Torneo> Torneos { get; set; }

        public FormAltaTorneo()
        {
            InitializeComponent();
        }

        public FormAltaTorneo(List<Torneo> listaTorneos):this()
        {
            Torneos = new List<Torneo>();
            Torneos = listaTorneos;

            this.cbo_torneosModificar.Visible = true;
            this.lbl_torneoAModificar.Visible = true;
            this.lbl_nombre.Text = "Nuevo nombre:";
            this.btn_confirmar.Text = "Modificar";
        }

        public string NombreAnterior { get => _nombreAnterior; set => _nombreAnterior = value; }

        private void FormAltaTorneo_Load(object sender, EventArgs e)
        {
            cbo_torneosModificar.DataSource = Torneos;

            if(Torneos is not null)
            {
                Torneo = (Torneo)cbo_torneosModificar.SelectedItem;
                CargarDatosTorneo(Torneo);

            }

        }

        private void CargarDatosTorneo(Torneo torneo)
        {
            this.txt_altaNombreTorneo.Text = torneo.Nombre;
            NombreAnterior = torneo.Nombre;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string auxNombre;

                auxNombre = txt_altaNombreTorneo.Text;
                Validacion.ValidarString(auxNombre);

                Torneo = new Torneo(auxNombre);

                this.DialogResult = DialogResult.OK;


            }
            catch (Exception excepcion)
            {
                lbl_msjError.Text = excepcion.Message;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cbo_torneosModificar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDatosTorneo((Torneo)cbo_torneosModificar.SelectedItem);
        }
    }
}

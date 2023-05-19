using BibliotecaDeClases;
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
        public Torneo Torneo { get; set; }
        public FormAltaTorneo()
        {
            InitializeComponent();
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
    }
}

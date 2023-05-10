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
    public partial class FormContenedor : Form
    {
        private Usuario _usuarioIngresado;
        public FormContenedor(Usuario usuarioIngresado)
        {
            InitializeComponent();
            _usuarioIngresado = usuarioIngresado;

        }

        private void verPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaJugadores formListado = new FormListaJugadores();
            formListado.ShowDialog();
            //this.Hide();

        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            if(_usuarioIngresado.Rol == Enumerados.ERol.Visitante)
            {
                modificarToolStripMenuItem.Visible = false;    //CAMBIAR ESTO
                verUsuariosToolStripMenuItem.Visible = false;
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void verEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaEquipos formListado = new FormListaEquipos();
            formListado.ShowDialog();
        }

        private void verResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verTorneosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListaTorneos formListadoTorneos = new FormListaTorneos();
            formListadoTorneos.ShowDialog();
        }
    }
}

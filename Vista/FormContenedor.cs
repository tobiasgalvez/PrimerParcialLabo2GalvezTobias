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
        public FormContenedor()
        {
            InitializeComponent();
        }

        private void verPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaJugadores formListado = new FormListaJugadores();
            formListado.Show();
            //this.Hide();
        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
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
            formListado.Show();
        }
    }
}

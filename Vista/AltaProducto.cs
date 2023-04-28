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
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            var lista = new List<Enumerados.EPosiciones>();

            lista = Enumerados.GetAll();

            foreach (var item in lista)
            {
                cbo_posiciones.Items.Add(item);
            }
        }
    }
}

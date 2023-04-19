using BibliotecaDeClases;
using PrimerParcial;
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
    public partial class FormListado : Form
    {
        List<Producto> productos; 
        public FormListado()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            Hardcodeo.HardcodearProductos(productos);
            dgv_listado.DataSource = productos;

        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            AltaProducto altaProducto = new AltaProducto();
            altaProducto.ShowDialog();
            
        }
    }
}

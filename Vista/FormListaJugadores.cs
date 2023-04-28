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
    public partial class FormListaJugadores : Form
    {
        List<Jugador> jugadores; 
        public FormListaJugadores()
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            Hardcodeo.HardcodearJugadores(jugadores);
            dgv_listado.DataSource = jugadores;

        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            AltaProducto altaProducto = new AltaProducto();
            altaProducto.ShowDialog();
            
        }
    }
}

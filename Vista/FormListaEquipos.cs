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
    public partial class FormListaEquipos : Form
    {
        List<Equipo> listaEquipos;
        List<Jugador> listaJugadores;
        public FormListaEquipos()
        {
            InitializeComponent();
            listaEquipos = new List<Equipo>();
            listaJugadores = new List<Jugador>();
        }

        private void FormListaEquipos_Load(object sender, EventArgs e)
        {
            Hardcodeo.HardcodearEquipos(listaEquipos, listaJugadores);
            dgv_listadoEquipos.DataSource = listaEquipos;
        }
    }
}

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
        public List<Jugador> Jugadores { get; set; }
        //Jugador jugador;
        public FormListaJugadores()
        {
            InitializeComponent();
            Jugadores = new List<Jugador>();
        }

        private void FormListado_Load(object sender, EventArgs e)
        {
            Hardcodeo.HardcodearJugadores(Jugadores);
            //jugadores.Add(jugador);
            dgv_listado.DataSource = Jugadores;

        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            AltaJugador altaProducto = new AltaJugador(Jugadores);
            altaProducto.ShowDialog(); //para poner foco en el form alta jugador
        }
    }
}

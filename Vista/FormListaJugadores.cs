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
            AltaJugador altaJugador = new AltaJugador();
            DialogResult resultado = altaJugador.ShowDialog(); //para poner foco en el form alta jugador
            if(resultado == DialogResult.OK)
            {
                Jugador jugadorIngresado = altaJugador.Jugador;
                Jugadores.Add(jugadorIngresado);
                ActualizarDataGrid();
                MessageBox.Show("jugador cargado con exito!!!!");
            }
            else
            {
                MessageBox.Show("Se canceló el alta de un jugador!!!!");
            }
        }

        private void ActualizarDataGrid()
        {
            dgv_listado.DataSource = null; // limpiar el DataSource para actualizar los datos
            dgv_listado.DataSource = Jugadores; // volver a vincular con la lista de jugadores actualizada
            dgv_listado.Refresh(); // refrescar el datagrid
        }
    }
}

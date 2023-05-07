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
        public List<Equipo> ListaEquipos { get => listaEquipos; set => listaEquipos = value; }

        private void FormListaEquipos_Load(object sender, EventArgs e)
        {
            Hardcodeo.HardcodearEquipos(listaEquipos, listaJugadores);
            dgv_listadoEquipos.DataSource = listaEquipos;
        }

        private void btn_agregarEquipo_Click(object sender, EventArgs e)
        {
            FormAltaEquipo altaEquipo = new FormAltaEquipo();
            DialogResult resultado = altaEquipo.ShowDialog(); //para poner foco en el form alta equipo
            if (resultado == DialogResult.OK)
            {
                Equipo equipoIngresado = altaEquipo.Equipo;
                ListaEquipos.Add(equipoIngresado);
                MessageBox.Show("equipo cargado con exito!!!!");
            }
            else
            {
                MessageBox.Show("Se canceló el alta de un equipo!!!!");
            }
        }
    }
}

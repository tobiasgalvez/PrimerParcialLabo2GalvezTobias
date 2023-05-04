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
    public partial class AltaJugador : Form
    {
        Jugador jugador;
        List<Jugador> _jugadorList;
      
        public AltaJugador(List<Jugador> jugadores)
        {
            InitializeComponent();
            _jugadorList = jugadores;
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            string auxNombre;
            string auxApellido;
            int dni;
            DateTime fechaNacimiento;
            string equipo;
            string posicion;

            try
            {

                auxNombre = txt_altaNombre.Text;
                auxApellido = txt_altaApellido.Text;
                dni = Validacion.DevolverCadenaParseadaInt(txt_altaDni.Text);
                Validacion.ValidarJugador(auxNombre, auxApellido, dni);
                fechaNacimiento = monthCalendar_fechaNacimiento.SelectionStart;
                equipo = cbo_altaEquipo.Text;
                posicion = cbo_posiciones.Text;

                jugador = new Jugador(auxNombre, auxApellido, fechaNacimiento, dni, posicion, equipo);
                MessageBox.Show(jugador.ToString());

                FormListaJugadores formJugadores = new FormListaJugadores();

                formJugadores.Jugadores.Add(jugador);
                formJugadores.Show();
                this.Hide();
            }
            catch (Exception excepcion)
            {
                //MessageBox.Show(excepcion.Message.ToString());
                lbl_msjError.Visible = true;
                lbl_msjError.Text = excepcion.Message;

            }

                //FormListaJugadores formListaJugadores = new FormListaJugadores(jugador);
                //formListaJugadores.Show();
                //this.Hide();
            
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

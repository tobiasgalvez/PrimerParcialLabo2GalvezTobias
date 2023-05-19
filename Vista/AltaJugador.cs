using BibliotecaDeClases;
using BibliotecaDeClases.ManejadorCsv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaDeClases.Enumerados;

namespace Vista
{
    public partial class AltaJugador : Form
    {
        
        public Jugador Jugador { get; set; }
        public List<Equipo> Equipos { get; set; }
        public ManejadorCsvEquipos csvEquipos;
        public AltaJugador()
        {
            InitializeComponent();
            Equipos = new List<Equipo>();
            csvEquipos = new ManejadorCsvEquipos("equipos.csv");

        }

       
        private void AltaProducto_Load(object sender, EventArgs e)
        {
           Equipos = csvEquipos.LeerDatos();
           cbo_altaEquipo.DataSource = Equipos;
           cbo_posiciones.DataSource = Enum.GetValues(typeof(EPosiciones)).Cast<EPosiciones>().ToList();

            //var lista = new List<Enumerados.EPosiciones>();
            //lista = Enumerados.GetAll();

            //foreach (var item in lista)
            //{
            //    cbo_posiciones.Items.Add(item);
            //}
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            string auxNombre;
            string auxApellido;
            string dniTexto;
            int dni;
            DateTime fechaNacimiento;
            string equipo;
            string posicion;

            try
            {

                auxNombre = txt_altaNombre.Text;
                auxApellido = txt_altaApellido.Text;
                dniTexto = txt_altaDni.Text;
                //dni = Validacion.DevolverCadenaParseadaInt(txt_altaDni.Text);
                Jugador.ValidarJugador(auxNombre, auxApellido, dniTexto);
                dni = Validacion.DevolverCadenaParseadaInt(dniTexto);
                fechaNacimiento = monthCalendar_fechaNacimiento.SelectionStart;
                equipo = cbo_altaEquipo.Text;
                posicion = cbo_posiciones.Text;
                Validacion.ValidarString(equipo);
                Validacion.ValidarString(posicion);

                Jugador = new Jugador(auxNombre, auxApellido, fechaNacimiento, dni, posicion, equipo);
                MessageBox.Show(Jugador.ObtenerInformacion());
                this.DialogResult = DialogResult.OK;

                //FormListaJugadores formJugadores = new FormListaJugadores();

                //formJugadores.Jugadores.Add(jugador);
                //formJugadores.Show();
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


        private void CargarJugador()
        { 
            //tendría q pasarme el codigo de "agregar" acá 
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }

  
    }
}

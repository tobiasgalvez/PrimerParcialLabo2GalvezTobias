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
        public List<Jugador> Jugadores { get; set; }
        public AltaJugador()
        {
            InitializeComponent();
            Equipos = new List<Equipo>();
            csvEquipos = new ManejadorCsvEquipos("equipos.csv");


        }

        public AltaJugador(List<Jugador> jugadores):this()
        {
            Jugadores = new List<Jugador>();
            Jugadores = jugadores;

            CambiarHerramientasParaModificar();
        }

       

        private void AltaProducto_Load(object sender, EventArgs e)
        {


            //if(Jugador != null)
            //{
            //    txt_altaNombre.Text = Jugador.Nombre;
            //    txt_altaApellido.Text = Jugador.Apellido;
            //    txt
            //}
           Equipos = csvEquipos.LeerDatos();
           cbo_altaEquipo.DataSource = Equipos;
           cbo_posiciones.DataSource = Enum.GetValues(typeof(EPosiciones)).Cast<EPosiciones>().ToList();

            cbo_jugadoresModificar.DataSource = Jugadores;

            if(Jugadores is not null)
            {
               Jugador = (Jugador)cbo_jugadoresModificar.SelectedItem;

                CargarDatosJugador(Jugador);

            }
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

                this.Hide();
            }
            catch (Exception excepcion)
            {
                //MessageBox.Show(excepcion.Message.ToString());
                lbl_msjError.Visible = true;
                lbl_msjError.Text = excepcion.Message;

            }
        }


        private void CargarDatosJugador(Jugador jugador)
        {
            txt_altaNombre.Text = jugador.Nombre;
            txt_altaApellido.Text = jugador.Apellido;
            txt_altaDni.Text = jugador.Dni.ToString();
            cbo_altaEquipo.Text = jugador.Equipo;
            cbo_posiciones.Text = jugador.Posicion;
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }

        private void cbo_jugadoresModificar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDatosJugador((Jugador)cbo_jugadoresModificar.SelectedItem);
        }

        private void CambiarHerramientasParaModificar()
        {
            this.btn_confirmar.Text = "Modificar";
            this.cbo_jugadoresModificar.Visible = true;
            this.lbl_jugadorAModificar.Visible = true;
            this.monthCalendar_fechaNacimiento.Visible = false;
            this.lbl_fechaDeNacimiento.Visible = false;
        }
    }
}

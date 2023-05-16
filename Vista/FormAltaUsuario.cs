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
using static BibliotecaDeClases.Enumerados;

namespace Vista
{
    public partial class FormAltaUsuario : Form
    {
        public Usuario Usuario { get; set; }
        public FormAltaUsuario()
        {
            InitializeComponent();
        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {
            cbo_roles.DataSource = Enum.GetValues(typeof(ERol)).Cast<ERol>().ToList();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string auxNombre;
            string auxApellido;
            string dniTexto;
            int dni;
            DateTime fechaNacimiento;
            string nombreUsuario;
            string contraseña;
            ERol rol;

            try
            {

                auxNombre = txt_altaNombre.Text;
                auxApellido = txt_altaApellido.Text;
                dniTexto = txt_altaDni.Text;
                //dni = Validacion.DevolverCadenaParseadaInt(txt_altaDni.Text);
                Jugador.ValidarJugador(auxNombre, auxApellido, dniTexto);
                dni = Validacion.DevolverCadenaParseadaInt(dniTexto);
                fechaNacimiento = monthCalendar_fechaNacimiento.SelectionStart;
                nombreUsuario = txt_altaNombreUsuario.Text;
                contraseña = txt_altaContraseña.Text;
                Enum.TryParse(cbo_roles.Text, out rol); // no haría falta verificar porque el combobox sólo contiene admin o visitante


                Validacion.ValidarString(nombreUsuario);
                Usuario = new Usuario(auxNombre, auxApellido, fechaNacimiento, dni, nombreUsuario, contraseña, rol);
                MessageBox.Show(Usuario.ObtenerInformacion());
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                lbl_msjError.Visible = true;
                lbl_msjError.Text = ex.Message;
            }
        }
    }
}


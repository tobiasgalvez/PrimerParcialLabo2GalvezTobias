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
    public partial class FormAltaUsuario : Form
    {
        public Usuario Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public FormAltaUsuario()
        {
            InitializeComponent();
            Usuarios = new List<Usuario>();
        }
        public FormAltaUsuario(List<Usuario> listaUsuarios) : this()
        {
            Usuarios = listaUsuarios;
            CambiarHerramientasParaModificar();
        }

        private void FormAltaUsuario_Load(object sender, EventArgs e)
        {
            cbo_roles.DataSource = Enum.GetValues(typeof(ERol)).Cast<ERol>().ToList();
            cbo_usuariosModificar.DataSource = Usuarios;

            if (Usuarios is not null)
            {
                Usuario = (Usuario)cbo_usuariosModificar.SelectedItem;
                CargarDatosUsuario(Usuario);    
            }
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CambiarHerramientasParaModificar()
        {
            this.lbl_fechaDeNacimiento.Visible = false;
            this.monthCalendar_fechaNacimiento.Visible = false;
            this.lbl_usuarioAModificar.Visible = true;
            this.cbo_usuariosModificar.Visible = true;
            this.btn_confirmar.Text = "Modificar";
        }

        private void CargarDatosUsuario(Usuario usuario)
        {
            txt_altaNombre.Text = usuario.Nombre;
            txt_altaApellido.Text = usuario.Apellido;
            txt_altaDni.Text = usuario.Dni.ToString();
            txt_altaNombreUsuario.Text = usuario.User;
            txt_altaContraseña.Text = usuario.Contraseña;
            cbo_roles.Text = usuario.Rol.ToString();
        }

        private void cbo_usuariosModificar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDatosUsuario((Usuario)cbo_usuariosModificar.SelectedItem);
        }
    }
}


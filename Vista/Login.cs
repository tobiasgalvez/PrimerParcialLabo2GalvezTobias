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
using Vista.Properties;

namespace Vista
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            txt_contraseña.PasswordChar = '*';
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            //abstraccion (el boton se abstrae de cómo hace el sistema para verificar el usuario. Le importa que le devuelva un usuario NADA MÁS)
            try
            {

                Usuario usuarioAux;
                //encapsulamiento (el sistema verifica el usuario pero el boton no sabe cómo lo hace)
                usuarioAux = Sistema.VerificarUsuarioExcepciones(txt_usuario.Text, txt_contraseña.Text);
                if (usuarioAux is not null)
                {
                    FormContenedor formContenedor = new FormContenedor(usuarioAux);
                    formContenedor.Show();
                    this.Hide();
                }

            }
            catch (Exception excepcion)
            {
                lbl_mensajeError.Visible = true;
                lbl_mensajeError.Text = excepcion.Message;
                //MessageBox.Show(excepcion.Message);
            }
        }

        private void btn_autocompletar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int indice;

            indice = rnd.Next(Sistema.ListaDeUsuarios.Count);

            this.txt_usuario.Text = Sistema.ListaDeUsuarios[indice].User;
            this.txt_contraseña.Text = Sistema.ListaDeUsuarios[indice].Contraseña;
        }

        private void pic_mostrarContraseña_Click(object sender, EventArgs e)
        {
            //pic_mostrarContraseña.Image = Resources.ocultarContraseña;
            pic_ocultarContraseña.BringToFront();
            txt_contraseña.PasswordChar = '\0';

        }

        private void pic_ocultarContraseña_Click(object sender, EventArgs e)
        {
            pic_mostrarContraseña.BringToFront();
            txt_contraseña.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.Informes;
using BibliotecaDeClases.ManejadorCsv;
using BibliotecaDeClases.ManejadorSQL;
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
    public partial class FormListaUsuarios : Form
    {
        List<Usuario> Usuarios { get; set; }
        //ManejadorCsvUsuarios csvUsuarios;
        Usuario UsuarioIngresado { get; set; }
        IManejadorSQL<Usuario> sqlUsuarios;
        public FormListaUsuarios(Usuario usuarioIngresado)
        {
            InitializeComponent();
            //csvUsuarios = new ManejadorCsvUsuarios("usuarios.csv");
            sqlUsuarios = new ManejadorSQLUsuarios(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
            UsuarioIngresado = usuarioIngresado;
        }


        private async void FormListaUsuarios_Load(object sender, EventArgs e)
        {
            //Usuarios = csvUsuarios.LeerDatos();
            Usuarios = await sqlUsuarios.LeerDatosAsync();
            dgv_listado.DataSource = Usuarios;

            if (UsuarioIngresado.Rol == Enumerados.ERol.Admin)
            {
                btn_exportarCsv.Visible = true;
                btn_exportarJson.Visible = true;
            }

        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            bool esIgual = false;
            //ManejadorCsv csv = new ManejadorCsv("usuarios.csv");
            FormAltaUsuario formAltaUsuario = new FormAltaUsuario();
            DialogResult resultado = formAltaUsuario.ShowDialog(); //para poner foco en el form alta jugador
            if (resultado == DialogResult.OK)
            {
                Usuario usuarioIngresado = formAltaUsuario.Usuario;
                foreach (var item in Usuarios)
                {
                    if (usuarioIngresado == item)
                    {
                        esIgual = true;
                    }
                }
                if (!esIgual)
                {
                    Usuarios.Add(usuarioIngresado);
                    //csv.AgregarJugador(jugadorIngresado);AGREGAR USUARIO
                    sqlUsuarios.AgregarDatoAsync(usuarioIngresado);
                    ActualizarDataGrid();
                    MessageBox.Show("usuario cargado con exito!!!!");

                }
                else
                {
                    MessageBox.Show($"El nombre de usuario: {usuarioIngresado.User} ya fue utilizado");
                }
            }
            else
            {
                MessageBox.Show("Se canceló el alta de un usuario!!!!");
            }
        }

        private void ActualizarDataGrid()
        {
            dgv_listado.DataSource = null; // limpiar el DataSource para actualizar los datos
            dgv_listado.DataSource = Usuarios; // volver a vincular con la lista de usuarios actualizada
            dgv_listado.Refresh(); // refrescar el datagrid
        }

        private void btn_exportarCsv_Click(object sender, EventArgs e)
        {
            txt_path.Visible = true;
            btn_exportar.Visible = true;
            btn_exportarCsv.Visible = false;
            btn_exportarJson.Visible = false;

            txt_path.PlaceholderText = "Ingrese path para csv";
        }

        private void btn_exportarJson_Click(object sender, EventArgs e)
        {
            txt_path.Visible = true;
            btn_exportar.Visible = true;
            btn_exportarCsv.Visible = false;
            btn_exportarJson.Visible = false;

            txt_path.PlaceholderText = "Ingrese path para json";
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            string auxPath;
            IInformes<Usuario> informesUsuarios;
            bool extensionJson = false;

            if (txt_path.PlaceholderText == "Ingrese path para json")
            {
                extensionJson = true;
            }

            try
            {
                auxPath = txt_path.Text;
                if (extensionJson)
                    Validacion.ValidarExtensionJson(auxPath);
                else
                    Validacion.ValidarExtensionCsv(auxPath);




                informesUsuarios = new InformesUsuarios(auxPath);

                if (extensionJson)
                    informesUsuarios.GuardarDatosJson(Usuarios);
                else
                    informesUsuarios.GuardarDatosCsv(Usuarios);

                MessageBox.Show("Archivo generado con exito!!!");

                lbl_msjError.Visible = false;
                txt_path.Visible = false;
                btn_exportarCsv.Visible = true;
                btn_exportarJson.Visible = true;
                btn_exportar.Visible = false;



            }
            catch (Exception excepcion)
            {
                //MessageBox.Show(excepcion.Message.ToString());
                lbl_msjError.Visible = true;
                lbl_msjError.Text = excepcion.Message;

            }

        }
    }
}

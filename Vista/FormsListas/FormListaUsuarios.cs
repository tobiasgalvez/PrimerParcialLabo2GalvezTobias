using BibliotecaDeClases.Entidades;
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
        IManejadorSQL<Usuario> sqlUsuarios;
        public FormListaUsuarios()
        {
            InitializeComponent();
            //csvUsuarios = new ManejadorCsvUsuarios("usuarios.csv");
            sqlUsuarios = new ManejadorSQLUsuarios(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
        }


        private async void FormListaUsuarios_Load(object sender, EventArgs e)
        {
            //Usuarios = csvUsuarios.LeerDatos();
            Usuarios = await sqlUsuarios.LeerDatosAsync();
            dgv_listado.DataSource = Usuarios;
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

        
    }
}

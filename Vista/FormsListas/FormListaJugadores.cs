using BibliotecaDeClases;
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
    public partial class FormListaJugadores : Form
    {
        public List<Jugador> Jugadores { get; set; }
        public Usuario UsuarioIngresado{get; set;}
        IManejadorSQL<Jugador> SqlJugadores { get; set; }
        public GestionEventos GestionEventos { get; set; }
        //Jugador jugador;
        public FormListaJugadores(Usuario usuarioIngresado, GestionEventos evento)
        {
            InitializeComponent();
            Jugadores = new List<Jugador>();
            UsuarioIngresado = usuarioIngresado;
            GestionEventos = evento;
            SqlJugadores = new ManejadorSQLJugadores(@"Server=.;Database=aplicacion;Trusted_Connection=True;");

        }



        private async void FormListado_Load(object sender, EventArgs e)
        {
            //Hardcodeo.HardcodearJugadores(Jugadores);
            //jugadores.Add(jugador);


            //ManejadorCsvJugadores csvJugadores = new ManejadorCsvJugadores("jugadores.csv");

            // Jugadores = csvJugadores.LeerDatos();

            Jugadores = await SqlJugadores.LeerDatosAsync();
            
            //csv.AgregarJugador(Jugadores[1]);
            //Jugadores = csv.LeerJugadores();
            dgv_listado.DataSource = Jugadores;
            this.MaximizeBox = false;

        }

        private void Btn_agregarProducto_Click(object sender, EventArgs e)
        {
            bool esIgual = false;
            ManejadorCsvJugadores csvJugadores = new ManejadorCsvJugadores("jugadores.csv");
            FormAltaJugador altaJugador = new FormAltaJugador();
            DialogResult resultado = altaJugador.ShowDialog(); //para poner foco en el form alta jugador
            if(resultado == DialogResult.OK)
            {
                Jugador jugadorIngresado = altaJugador.Jugador;
                foreach (var item in Jugadores)
                {
                    if(jugadorIngresado == item)
                    {
                        esIgual = true; 
                    }
                }
                if(!esIgual)
                {
                        Jugadores.Add(jugadorIngresado);
                    csvJugadores.AgregarDato(jugadorIngresado);
                        ActualizarDataGrid();
                        MessageBox.Show("jugador cargado con exito!!!!");
                    Logs registro = new Logs
                    {
                        Fecha = DateTime.Now,
                        Usuario = UsuarioIngresado.User,
                        Accion = "Agregó un nuevo jugador",
                    };

                    GestionEventos.EnviarRegistroLog(registro);


                }
                else
                {
                    MessageBox.Show($"El jugador con dni {jugadorIngresado.Dni} ya ha sido agregado");
                }
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

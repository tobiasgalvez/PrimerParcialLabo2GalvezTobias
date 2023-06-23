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
    public partial class FormEliminar : Form
    {
    //    ManejadorCsvJugadores csvJugadores;
    //    ManejadorCsvTorneos csvTorneos;
    //    ManejadorCsvUsuarios csvUsuarios;
    //    ManejadorCsvEquipos csvEquipos;
    //    ManejadorCsvPartidos csvPartidos;

        IManejadorSQL<Jugador> sqlJugadores;
        IManejadorSQL<Torneo> sqlTorneos;
        IManejadorSQL<Usuario> sqlUsuarios;
        IManejadorSQL<Equipo> sqlEquipos;
        IManejadorSQL<Partido> sqlPartidos;

        string connection = @"Server=.;Database=aplicacion;Trusted_Connection=True;";


        List<Jugador> Jugadores { get; set; }
        List<Torneo> Torneos { get; set; }
        List<Usuario> Usuarios { get; set; }
        List<Equipo> Equipos { get; set; }
        List<Partido> Partidos { get; set; }

        public FormEliminar()
        {
            InitializeComponent();

            //csvJugadores = new ManejadorCsvJugadores("jugadores.csv");
            //csvTorneos = new ManejadorCsvTorneos("torneos.csv");
            //csvUsuarios = new ManejadorCsvUsuarios("usuarios.csv");
            //csvEquipos = new ManejadorCsvEquipos("equipos.csv");
            //csvPartidos = new ManejadorCsvPartidos("partidos.csv");


            sqlJugadores = new ManejadorSQLJugadores(connection);
            sqlTorneos = new ManejadorSQLTorneos(connection);
            sqlUsuarios = new ManejadorSQLUsuarios(connection);
            sqlEquipos = new ManejadorSqlEquipos(connection);
            sqlPartidos = new ManejadorSQLResultados(connection);

            Jugadores = new List<Jugador>();
            Torneos = new List<Torneo>();
            Usuarios = new List<Usuario>();
            Equipos = new List<Equipo>();
            Partidos = new List<Partido>();
        }

        private async void FormEliminar_Load(object sender, EventArgs e)
        {
            //Jugadores = csvJugadores.LeerDatos();
            //Torneos = csvTorneos.LeerDatos();
            //Usuarios = csvUsuarios.LeerDatos();
            //Equipos = csvEquipos.LeerDatos();
            //Partidos = csvPartidos.LeerDatos();

            Jugadores = await sqlJugadores.LeerDatosAsync();
            Torneos = await sqlTorneos.LeerDatosAsync();
            Usuarios = await sqlUsuarios.LeerDatosAsync();
            Equipos = await sqlEquipos.LeerDatosAsync();
            Partidos = await sqlPartidos.LeerDatosAsync();


            cbo_jugadores.DataSource = Jugadores;
            cbo_equipos.DataSource = Equipos;
            cbo_usuarios.DataSource = Usuarios;
            cbo_torneos.DataSource = Torneos;
            cbo_partidos.DataSource = Partidos;
        }

        private async void btn_eliminarJugador_Click(object sender, EventArgs e)
        {
            Jugador jugadorAEliminar;
            jugadorAEliminar = (Jugador)cbo_jugadores.SelectedItem;

            DialogResult resultado = MessageBox.Show("Confirma eliminación de este jugador?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                //csvJugadores.EliminarDato(jugadorAEliminar);
                await sqlJugadores.EliminarDatoAsync(jugadorAEliminar);
                MessageBox.Show($"Jugador '{jugadorAEliminar}' eliminado!!!");
                cbo_jugadores.DataSource = await sqlJugadores.LeerDatosAsync();
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación");
            }
        }

        private async void btn_eliminarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipoAEliminar;
            equipoAEliminar = (Equipo)cbo_equipos.SelectedItem;

            DialogResult resultado = MessageBox.Show("Confirma eliminación de este equipo?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                //csvEquipos.EliminarDato(equipoAEliminar);
                await sqlEquipos.EliminarDatoAsync(equipoAEliminar);
                MessageBox.Show($"Equipo '{equipoAEliminar}' eliminado!!!");
                cbo_equipos.DataSource =  await sqlEquipos.LeerDatosAsync();
                foreach (var item in Jugadores)
                {
                    Jugador jugadorEquipoEliminado = item;
                    if (item.Equipo == equipoAEliminar.Nombre)
                    {
                        jugadorEquipoEliminado.Equipo = "Sin equipo";
                        //csvJugadores.ModificarDato(item, jugadorEquipoEliminado);
                        await sqlJugadores.ModificarDatoAsync(item, jugadorEquipoEliminado);

                    }
                        
                }
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación");
            }
        }

        private async void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuarioAEliminar;
            usuarioAEliminar = (Usuario)cbo_usuarios.SelectedItem;

            DialogResult resultado = MessageBox.Show("Confirma eliminación de este usuario?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                //csvUsuarios.EliminarDato(usuarioAEliminar);
                await sqlUsuarios.EliminarDatoAsync(usuarioAEliminar);
                MessageBox.Show($"Usuario '{usuarioAEliminar}' eliminado!!!");
                cbo_usuarios.DataSource = await sqlUsuarios.LeerDatosAsync();
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación");
            }
        }

        private async void btn_eliminarTorneo_Click(object sender, EventArgs e)
        {
            Torneo torneoAEliminar;
            torneoAEliminar = (Torneo)cbo_torneos.SelectedItem;

            DialogResult resultado = MessageBox.Show("Confirma eliminación de este torneo?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                //csvTorneos.EliminarDato(torneoAEliminar);
                await sqlTorneos.EliminarDatoAsync(torneoAEliminar);
                MessageBox.Show($"Torneo '{torneoAEliminar}' eliminado!!!");
                cbo_torneos.DataSource = await sqlTorneos.LeerDatosAsync();

                foreach (var item in Equipos)
                {
                    if(item.Liga == torneoAEliminar.Nombre)
                    item.Liga = "nn";
                }
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación");
            }
        }

        private async void btn_eliminarPartido_Click(object sender, EventArgs e)
        {
            Partido partidoAEliminar;
            partidoAEliminar = (Partido)cbo_partidos.SelectedItem;

            DialogResult resultado = MessageBox.Show("Confirma eliminación de este partido?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                //csvPartidos.EliminarDato(partidoAEliminar);
                await sqlPartidos.EliminarDatoAsync(partidoAEliminar);
                MessageBox.Show($"Partido '{partidoAEliminar}' eliminado!!!");
                cbo_partidos.DataSource = await sqlPartidos.LeerDatosAsync();
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación");
            }
        }
    }
}

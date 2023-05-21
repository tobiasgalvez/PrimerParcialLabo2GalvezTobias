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

namespace Vista
{
    public partial class FormModificar : Form
    {
        ManejadorCsvJugadores csvJugadores;
        ManejadorCsvTorneos csvTorneos;
        ManejadorCsvUsuarios csvUsuarios;
        ManejadorCsvEquipos csvEquipos;

        List<Jugador> Jugadores { get; set; }
        List<Torneo> Torneos { get; set; }
        List<Usuario> Usuarios { get; set; }  
        List<Equipo> Equipos { get; set; }


        public FormModificar()
        {
            InitializeComponent();
            csvJugadores = new ManejadorCsvJugadores("jugadores.csv");
            csvTorneos = new ManejadorCsvTorneos("torneos.csv");
            csvUsuarios = new ManejadorCsvUsuarios("usuarios.csv");
            csvEquipos = new ManejadorCsvEquipos("equipos.csv");

            Jugadores = new List<Jugador>();
            Torneos = new List<Torneo>();
            Usuarios = new List<Usuario>();
            Equipos = new List<Equipo>();

        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            Jugadores = csvJugadores.LeerDatos();
            Torneos = csvTorneos.LeerDatos();
            Usuarios = csvUsuarios.LeerDatos();
            Equipos = csvEquipos.LeerDatos();
        }

        private void btn_modificarJugador_Click(object sender, EventArgs e)
        {
            AltaJugador altaJugador = new AltaJugador(Jugadores);
            //int indiceJugador;
            DialogResult resultado = altaJugador.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                Jugador jugadorModificado = altaJugador.Jugador;

                foreach (var item in Jugadores)
                {
                    if (jugadorModificado == item)
                    {
                        csvJugadores.ModificarDato(item, jugadorModificado);
                        MessageBox.Show("Jugador modificado con éxito!!!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Se canceló la modificación de un jugador!!!");
            }
        }

        private void btn_modificarEquipo_Click(object sender, EventArgs e)
        {
            FormAltaEquipo formAltaEquipo = new FormAltaEquipo(Equipos);
            DialogResult resultado = formAltaEquipo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Equipo equipoModificado = formAltaEquipo.Equipo;
                string nombreAnteriorEquipo = formAltaEquipo.NombreAnterior;

                foreach (var item in Equipos)
                {
                    if (nombreAnteriorEquipo == item.Nombre)
                    {
                        csvEquipos.ModificarDato(item, equipoModificado);
                        MessageBox.Show("Equipo modificado con exito!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Se canceló la modificación del equipo");
            }
        }

        private void btn_modificarTorneo_Click(object sender, EventArgs e)
        {
            FormAltaTorneo formAltaTorneo = new FormAltaTorneo(Torneos);
            DialogResult resultado = formAltaTorneo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Torneo torneoModificado = formAltaTorneo.Torneo;
                string nombreAnteriorTorneo = formAltaTorneo.NombreAnterior;

                foreach (var item in Torneos)
                {
                    if (nombreAnteriorTorneo == item.Nombre)
                    {
                        csvTorneos.ModificarDato(item, torneoModificado);
                        MessageBox.Show("Torneo modificado con exito!!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Se canceló la modificación del nombre del torneo");
            }
        }

        private void btn_modificarUsuario_Click(object sender, EventArgs e)
        {
            FormAltaUsuario formAltaUsuario = new FormAltaUsuario(Usuarios);
            //int indiceJugador;
            DialogResult resultado = formAltaUsuario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Usuario usuarioModificado = formAltaUsuario.Usuario;

                foreach (var item in Usuarios)
                {
                    if (usuarioModificado == item)
                    {
                        csvUsuarios.ModificarDato(item, usuarioModificado);
                        MessageBox.Show("Usuario modificado con éxito!!!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Se canceló la modificación de un usuario!!!");
            }
        }
    }
}

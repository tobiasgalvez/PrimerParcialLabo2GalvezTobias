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
        ManejadorCsvPartidos csvPartidos;

        List<Jugador> Jugadores { get; set; }
        List<Torneo> Torneos { get; set; }
        List<Usuario> Usuarios { get; set; }  
        List<Equipo> Equipos { get; set; }
        List<Partido> Partidos { get; set; }


        public FormModificar()
        {
            InitializeComponent();
            csvJugadores = new ManejadorCsvJugadores("jugadores.csv");
            csvTorneos = new ManejadorCsvTorneos("torneos.csv");
            csvUsuarios = new ManejadorCsvUsuarios("usuarios.csv");
            csvEquipos = new ManejadorCsvEquipos("equipos.csv");
            csvPartidos = new ManejadorCsvPartidos("partidos.csv");

            Jugadores = new List<Jugador>();
            Torneos = new List<Torneo>();
            Usuarios = new List<Usuario>();
            Equipos = new List<Equipo>();
            Partidos = new List<Partido>();

        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            Jugadores = csvJugadores.LeerDatos();
            Torneos = csvTorneos.LeerDatos();
            Usuarios = csvUsuarios.LeerDatos();
            Equipos = csvEquipos.LeerDatos();
            Partidos = csvPartidos.LeerDatos();
        }

        private void btn_modificarJugador_Click(object sender, EventArgs e)
        {
            FormAltaJugador altaJugador = new FormAltaJugador(Jugadores);
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
            bool flag = false;
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
                        flag = true;
                        break;
                    }
                }

                if(flag)
                {
                    ModificarEquipoEnListaDeJugadores(nombreAnteriorEquipo, equipoModificado);
                    ModificarEquipoEnListaDePartidos(nombreAnteriorEquipo, equipoModificado);
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
            bool flag = false;
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
                        flag = true;
                    }
                }

                if(flag)
                {
                    ModificarTorneoEnListaDeEquipos(nombreAnteriorTorneo, torneoModificado);
                }

            }
            else
            {
                MessageBox.Show("Se canceló la modificación del nombre del torneo");
            }
        }

        private void btn_modificarUsuario_Click(object sender, EventArgs e)
        {
            FormAltaUsuario formAltaUsuario = new(Usuarios);
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

        /// <summary>
        /// Método por el cual se actualiza el nombre del equipo  en la lista de jugadores
        /// </summary>
        /// <param name="nombreAnteriorEquipo">nombre anterior del equipo</param>
        /// <param name="equipoModificado">equipo con nombre modificado</param>
        private void ModificarEquipoEnListaDeJugadores(string nombreAnteriorEquipo, Equipo equipoModificado)
        {
            foreach (var item in Jugadores)
            {
                if (nombreAnteriorEquipo == item.Equipo)
                {
                    Jugador jugadorNombreEquipoModificado = item;
                    jugadorNombreEquipoModificado.Equipo = equipoModificado.Nombre;
                    csvJugadores.ModificarDato(item, jugadorNombreEquipoModificado);
                }
            }
        }

        /// <summary>
        /// Método por el cual se actualiza el nombre del equipo en la lista de partidos
        /// </summary>
        /// <param name="nombreAnteriorEquipo">nombre anterior del equipo</param>
        /// <param name="equipoModificado">equipo con nombre modificado</param>
        private void ModificarEquipoEnListaDePartidos(string nombreAnteriorEquipo, Equipo equipoModificado)
        {
            foreach (var item in Partidos)
            {
                Partido partidoNombreEquipoModificado = item;
                if (nombreAnteriorEquipo == item.EquipoLocal.Nombre)
                {
                    partidoNombreEquipoModificado.EquipoLocal.Nombre = equipoModificado.Nombre;
                    csvPartidos.ModificarPartido(item, partidoNombreEquipoModificado, nombreAnteriorEquipo);
                }
                if (nombreAnteriorEquipo == item.EquipoVisitante.Nombre)
                {
                    partidoNombreEquipoModificado.EquipoVisitante.Nombre = equipoModificado.Nombre;
                    csvPartidos.ModificarPartido(item, partidoNombreEquipoModificado, nombreAnteriorEquipo);
                }
            }
        }

        /// <summary>
        /// Método por el cual se actualiza el nombre del torneo en la lista de equipos
        /// </summary>
        /// <param name="nombreAnteriorTorneo">nombre anterior del torneo</param>
        /// <param name="torneoModificado">torneo con nombre modificado</param>
        private void ModificarTorneoEnListaDeEquipos(string nombreAnteriorTorneo, Torneo torneoModificado)
        {
            foreach (var item in Equipos)
            {
                Equipo equipoNombreTorneoModificado;
                if (nombreAnteriorTorneo == item.Liga)
                {
                    equipoNombreTorneoModificado = item;
                    equipoNombreTorneoModificado.Liga = torneoModificado.Nombre;
                    csvEquipos.ModificarDato(item, equipoNombreTorneoModificado);
                }
            }
        }




    }
}

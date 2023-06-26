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
    public partial class FormModificar : Form
    {
        //ManejadorCsvJugadores csvJugadores;
        //ManejadorCsvTorneos csvTorneos;
        //ManejadorCsvUsuarios csvUsuarios;
        //ManejadorCsvEquipos csvEquipos;
        //ManejadorCsvPartidos csvPartidos;

        Usuario UsuarioIngresado { get; set; }
        GestionEventos GestionEventos { get; set; }

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


        public FormModificar(Usuario usuarioIngresado, GestionEventos gestionEventos)
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

            UsuarioIngresado = usuarioIngresado;
            GestionEventos = gestionEventos;
        }

        private async void FormModificar_Load(object sender, EventArgs e)
        {
            Jugadores = await sqlJugadores.LeerDatosAsync();
            Torneos = await sqlTorneos.LeerDatosAsync();
            Usuarios = await sqlUsuarios.LeerDatosAsync();
            Equipos = await sqlEquipos.LeerDatosAsync();
            Partidos = await sqlPartidos.LeerDatosAsync();
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
                        //csvJugadores.ModificarDato(item, jugadorModificado);
                        sqlJugadores.ModificarDatoAsync(item, jugadorModificado);
                        MessageBox.Show("Jugador modificado con éxito!!!");
                        Logs registro = new Logs
                        {
                            Fecha = DateTime.Now,
                            Usuario = UsuarioIngresado.User,
                            Accion = $"Modificó un jugador: {item}",
                        };

                        GestionEventos.EnviarRegistroLog(registro);
                    }
                }

            }
            else
            {
                MessageBox.Show("Se canceló la modificación de un jugador!!!");
            }
        }

        private async void btn_modificarEquipo_Click(object sender, EventArgs e)
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
                        //csvEquipos.ModificarDato(item, equipoModificado);
                        await sqlEquipos.ModificarDatoAsync(item, equipoModificado);
                        MessageBox.Show("Equipo modificado con exito!!!");
                        flag = true;
                        Logs registro = new Logs
                        {
                            Fecha = DateTime.Now,
                            Usuario = UsuarioIngresado.User,
                            Accion = $"Modificó un equipo: nombre anterior: {item} nombre actual: {equipoModificado}",
                        };

                        GestionEventos.EnviarRegistroLog(registro);
                        break;
                    }
                }

                if(flag)
                {
                    await Sistema.ModificarEquipoEnListaDeJugadores(nombreAnteriorEquipo, equipoModificado, Jugadores);
                    //ModificarEquipoEnListaDePartidos(nombreAnteriorEquipo, equipoModificado);
                }
            }
            else
            {
                MessageBox.Show("Se canceló la modificación del equipo");
            }
        }

        private async void btn_modificarTorneo_Click(object sender, EventArgs e)
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
                        //csvTorneos.ModificarDato(item, torneoModificado);
                        await sqlTorneos.ModificarDatoAsync(item, torneoModificado);
                        MessageBox.Show("Torneo modificado con exito!!!");
                        flag = true;
                        Logs registro = new Logs
                        {
                            Fecha = DateTime.Now,
                            Usuario = UsuarioIngresado.User,
                            Accion = $"Modificó un torneo: nombre anterior:{item.Nombre} nombre actual: {torneoModificado.Nombre}",
                        };

                        GestionEventos.EnviarRegistroLog(registro);
                    }
                }

                if(flag)
                {
                    await Sistema.ModificarTorneoEnListaDeEquipos(nombreAnteriorTorneo, torneoModificado, Equipos);
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
                        //csvUsuarios.ModificarDato(item, usuarioModificado);
                        sqlUsuarios.ModificarDatoAsync(item, usuarioModificado);
                        MessageBox.Show("Usuario modificado con éxito!!!");
                        Logs registro = new Logs
                        {
                            Fecha = DateTime.Now,
                            Usuario = UsuarioIngresado.User,
                            Accion = $"Modificó un usuario: {item}",
                        }; 
                        GestionEventos.EnviarRegistroLog(registro);

                    }
                }

            }
            else
            {
                MessageBox.Show("Se canceló la modificación de un usuario!!!");
            }
        }

 
        /// <summary>
        /// Método por el cual se actualiza el nombre del equipo en la lista de partidos
        /// </summary>
        /// <param name="nombreAnteriorEquipo">nombre anterior del equipo</param>
        /// <param name="equipoModificado">equipo con nombre modificado</param>
        //private void ModificarEquipoEnListaDePartidos(string nombreAnteriorEquipo, Equipo equipoModificado)
        //{
        //    foreach (var item in Partidos)
        //    {
        //        Partido partidoNombreEquipoModificado = item;
        //        if (nombreAnteriorEquipo == item.EquipoLocal.Nombre)
        //        {
        //            partidoNombreEquipoModificado.EquipoLocal.Nombre = equipoModificado.Nombre;
        //            csvPartidos.ModificarPartido(item, partidoNombreEquipoModificado, nombreAnteriorEquipo);
        //        }
        //        if (nombreAnteriorEquipo == item.EquipoVisitante.Nombre)
        //        {
        //            partidoNombreEquipoModificado.EquipoVisitante.Nombre = equipoModificado.Nombre;
        //            csvPartidos.ModificarPartido(item, partidoNombreEquipoModificado, nombreAnteriorEquipo);
        //        }
        //    }
        //}

       



    }
}

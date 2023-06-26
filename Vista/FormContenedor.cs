using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;
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
    public partial class FormContenedor : Form
    {
        public Usuario UsuarioIngresado { get; set; }
        public GestionEventos GestionEventos { get; set; }
        IManejadorSQL<Logs> sqlRegistros;

        public FormContenedor(Usuario usuarioIngresado)
        {
            InitializeComponent();
            UsuarioIngresado = usuarioIngresado;
            GestionEventos = new GestionEventos();
            sqlRegistros = new ManejadorSQLRegistros(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
            //me suscribo al evento log
            GestionEventos.EventoLog += GestionEventos_EventoLog;

        }

        private async void GestionEventos_EventoLog(Logs log)
        {
            // Agregar el registro de log al TextBox 
            //lst_registros.Items.Add($"[{log.Fecha}] {log.Usuario}: {log.Accion}"); 
            await sqlRegistros.AgregarDatoAsync(log);

        }

        private void verPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaJugadores formListado = new FormListaJugadores(UsuarioIngresado, GestionEventos);
            formListado.ShowDialog();
            //this.Hide();

        }

        private void FormContenedor_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            if(UsuarioIngresado.Rol == Enumerados.ERol.Visitante)
            {
                modificarToolStripMenuItem.Visible = false;
                verUsuariosToolStripMenuItem.Visible = false;
                eliminarToolStripMenuItem.Visible = false;
                registrosToolStripMenuItem.Visible = false;
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void verEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaEquipos formListado = new FormListaEquipos(UsuarioIngresado, GestionEventos);
            formListado.ShowDialog();
        }

        private void verTorneosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListaTorneos formListadoTorneos = new FormListaTorneos(UsuarioIngresado, GestionEventos);
            formListadoTorneos.ShowDialog();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaUsuarios formListaUsuarios = new FormListaUsuarios(UsuarioIngresado, GestionEventos);
            formListaUsuarios.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UsuarioIngresado.ObtenerInformacion());
        }

        private void verResultadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListaResultados formListaResultados = new FormListaResultados(UsuarioIngresado, GestionEventos);
            formListaResultados.ShowDialog();
        }

        private void verRankingHistoricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRanking formRankingHistórico = new FormRanking();
            formRankingHistórico.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificar formModificar = new FormModificar(UsuarioIngresado, GestionEventos);
            formModificar.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar formEliminar = new FormEliminar(UsuarioIngresado, GestionEventos);
            formEliminar.ShowDialog();
        }

        private void aplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Sistema.InformacionAplicacion());
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistros formRegistros = new FormRegistros(UsuarioIngresado);
            formRegistros.ShowDialog();
        }
    }
}

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
using static BibliotecaDeClases.Enumerados;

namespace Vista
{
    public partial class FormAgregarResultado : Form
    {
        //List<Equipo> _listaEquipos;
        //List<Torneo> _listaTorneos;

        public List<Equipo> Equipos { get; set; }
        public List<Torneo> Torneos { get; set; }
        public Partido Partido { get; set; }

        public FormAgregarResultado()
        {
            InitializeComponent();
            Equipos = new List<Equipo>();
            Torneos = new List<Torneo>();
            Partido = new Partido();
        }

        private void FormAgregarResultado_Load(object sender, EventArgs e)
        {
            lbl_mensajeError.Visible = false;
            //Hardcodeo.HardcodearEquipos(Equipos);
            Hardcodeo.HardcodearTorneos(Torneos);

            Torneos[0].ListaDeEquipos.Add(new Equipo("Boca"));
            CargarComboBoxEquipos(Torneos[0]);

            cbo_torneo.DataSource = Torneos;

            //for (int i = 0; i < Torneos.Count; i++)
            //{

            //     //TENDRIA QUE AGREGAR BIEN TODOS LOS TORNEOS AL COMBOBOX
            //}
            //Torneos[0].ListaDeEquipos = new List<Equipo>();

            //foreach (var item in Equipos)
            //{
            //    if(item.Liga == Torneos[0].Nombre)
            //    {
            //        Torneos[0].ListaDeEquipos.Add(item);
            //    }
            //}

            //foreach (var item in Torneos[0].ListaDeEquipos)
            //{
            //    cbo_equipo1.Items.Add(item.Nombre);
            //    cbo_equipo2.Items.Add(item.Nombre);
            //}

            //foreach (var item in Torneos)
            //{
            //    cbo_torneo.Items.Add(item.Nombre);
            //}
            
        }

        private void btn_generarResultado_Click(object sender, EventArgs e)
        {
            //Partido nuevoPartido;
            Random random = new Random();
            //Partido partido = new Partido();

            EResultado ganador;

            ganador = (EResultado)random.Next(0, 2+1);

            string equipo1;
            string equipo2;

            Equipo equipoLocal;
            Equipo equipoVisitante;

            try
            {
                Validacion.ValidarString(cbo_equipo1.Text);
                Validacion.ValidarString(cbo_equipo2.Text);
                equipo1 = cbo_equipo1.Text;
                equipo2 = cbo_equipo2.Text;
                Partido.ValidarEnfrentamiento(equipo1, equipo2);

                foreach (var item in Torneos[0].ListaDeEquipos)
                {
                    if(item.Nombre == equipo1)
                    {
                        equipoLocal = item;
                        Partido.EquipoLocal = equipoLocal;
                    }                                   //BUSCO SI COINCIDE EL EQUIPO QUE INGRESÓ EN EL COMBOBOX
                    else if(item.Nombre == equipo2)
                    {
                        equipoVisitante = item;
                        Partido.EquipoVisitante = equipoVisitante;
                    }
                }

                Partido.SimularPartido();
                MessageBox.Show(Partido.ResumenPartido());
                //Partido = partido;

                this.DialogResult = DialogResult.OK;
            

            }catch(Exception ex)
            {
                lbl_mensajeError.Visible = true;
                lbl_mensajeError.Text = ex.Message;
            }

                //throw new Exception("Un equipo no puede jugar consigo mismo!!!");
                //MessageBox.Show("Un equipo no puede jugar consigo mismo!!!");
                
           

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void CargarComboBoxEquipos(Torneo torneoSeleccionado)
        {
            cbo_equipo1.DataSource = new List<Equipo>(torneoSeleccionado.ListaDeEquipos);
            cbo_equipo2.DataSource = new List<Equipo>(torneoSeleccionado.ListaDeEquipos);
        }

        private void cbo_torneo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarComboBoxEquipos((Torneo)cbo_torneo.SelectedItem);
        }
    }
}

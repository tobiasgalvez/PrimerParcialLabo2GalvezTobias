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
        ManejadorCsvTorneos csvTorneos;

        public FormAgregarResultado()
        {
            InitializeComponent();
            Equipos = new List<Equipo>();
            Torneos = new List<Torneo>();
            Partido = new Partido();
            csvTorneos = new ManejadorCsvTorneos("torneos.csv");
        }

        private void FormAgregarResultado_Load(object sender, EventArgs e)
        {
            
            lbl_mensajeError.Visible = false;
            Torneo torneoSeleccionado;
            //Hardcodeo.HardcodearEquipos(Equipos);
            
            Torneos = csvTorneos.LeerDatos();

            cbo_torneo.DataSource = Torneos;
            torneoSeleccionado = (Torneo)cbo_torneo.SelectedItem;   
            CargarComboBoxEquipos(torneoSeleccionado);
            

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

            //Equipo equipo1Ingresado;
            //Equipo equipo2Ingresado;

            Equipo equipoLocal;
            Equipo equipoVisitante;

            Torneo torneoElegido;

            try
            {
                Validacion.ValidarString(cbo_equipo1.Text);
                Validacion.ValidarString(cbo_equipo2.Text);
                equipoLocal = (Equipo)cbo_equipo1.SelectedItem;
                equipoVisitante = (Equipo)cbo_equipo2.SelectedItem;
                torneoElegido = (Torneo)cbo_torneo.SelectedItem;
                Partido.ValidarEnfrentamiento(equipoLocal, equipoVisitante);
                Partido.Torneo = cbo_torneo.Text;

                foreach (var item in torneoElegido.ListaDeEquipos)
                {
                    if(equipoLocal == item)
                    {
                        equipoLocal = item;
                        Partido.EquipoLocal = equipoLocal;
                    }                                   //BUSCO SI COINCIDE EL EQUIPO QUE INGRESÓ EN EL COMBOBOX
                    else if(equipoVisitante == item)
                    {
                        equipoVisitante = item;
                        Partido.EquipoVisitante = equipoVisitante;
                    }
                }

                Partido.SimularPartido();
                MessageBox.Show(Partido.ResumenPartido());


                //TENGO QUE AGREGAR EL CSV DE EQUIPOS Y ACTUALIZAR A LOS EQUIPOS QUE JUGARON PARA QUE FIGUREN SUS GOLES Y QUE FIGUREN SUS PARTIDOS JUGADOS, GANADOS, PERDIDOS, EMPATADOS, ETC
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
            if(torneoSeleccionado.ListaDeEquipos.Count > 0)
            {
                //Creo estas dos listas diferentes porque cuando cambio la selección en uno de los combobox, también se cambia en el otro debido a que ambos están enlazados a la misma lista de equipos.
                List<Equipo> listaEquipos1 = new List<Equipo>(torneoSeleccionado.ListaDeEquipos);
                List<Equipo> listaEquipos2 = new List<Equipo>(torneoSeleccionado.ListaDeEquipos);

                // Asignar las listas a los ComboBox
                cbo_equipo1.DataSource = listaEquipos1;
                cbo_equipo2.DataSource = listaEquipos2;
            }
            else
            {
                throw new SinEquiposCargadosException("El torneo no tiene equipos cargados!!!");
            }

        }

        private void cbo_torneo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CargarComboBoxEquipos((Torneo)cbo_torneo.SelectedItem);

            }catch(Exception ex)
            {
                lbl_mensajeError.Visible = true;
                lbl_mensajeError.Text = ex.Message;
            }
        }
    }
}

﻿using BibliotecaDeClases.Entidades;
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
    public partial class FormListaTorneos : Form
    {
        List<Torneo> Torneos { get; set; }
        //ManejadorCsvTorneos csvTorneos;
        IManejadorSQL<Torneo> SqlTorneos { get; set; }

        public FormListaTorneos()
        {
            InitializeComponent();
            Torneos = new List<Torneo>();
            //csvTorneos = new ManejadorCsvTorneos("torneos.csv");
            SqlTorneos = new ManejadorSQLTorneos(@"Server=.;Database=aplicacion;Trusted_Connection=True;");

        }

        private async void ListaTorneos_Load(object sender, EventArgs e)
        {
            //Hardcodeo.HardcodearTorneos(Torneos);
            //Torneos = csvTorneos.LeerDatos();
            Torneos = await SqlTorneos.LeerDatosAsync();

            dgv_listadoTorneos.DataSource = Torneos;
            this.MaximizeBox = false;
        }

        private void btn_agregarTorneo_Click(object sender, EventArgs e)
        {
            FormAltaTorneo altaTorneo = new FormAltaTorneo();

            bool esIgual = false;
            DialogResult resultado = altaTorneo.ShowDialog(); //para poner foco en el form alta equipo
            if (resultado == DialogResult.OK)
            {
                Torneo torneoIngresado = altaTorneo.Torneo;
                foreach (var item in Torneos)
                {
                    if (torneoIngresado == item)
                    {
                        esIgual = true;
                    }
                }
                if (!esIgual)
                {
                    Torneos.Add(torneoIngresado);
                    //csvTorneos.AgregarDato(torneoIngresado);
                    SqlTorneos.AgregarDatoAsync(torneoIngresado);
                    ActualizarDataGrid();
                    MessageBox.Show("torneo cargado con exito!!!!");

                }
                else
                {
                    MessageBox.Show($"El torneo {torneoIngresado.Nombre} ya ha sido agregado");
                }
            }
            else
            {
                MessageBox.Show("Se canceló el alta de un equipo!!!!");
            }
        }

        private void ActualizarDataGrid()
        {
            dgv_listadoTorneos.DataSource = null; // limpiar el DataSource para actualizar los datos
            dgv_listadoTorneos.DataSource = Torneos; // volver a vincular con la lista de jugadores actualizada
            dgv_listadoTorneos.Refresh(); // refrescar el datagrid
        }
    }
}
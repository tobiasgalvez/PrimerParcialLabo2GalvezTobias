﻿using BibliotecaDeClases;
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
    public partial class FormAltaEquipo : Form
    {
        Equipo _equipo;
        List<Torneo> Torneos { get; set; }
        ManejadorCsvTorneos csvTorneos;
        public FormAltaEquipo()
        {
            InitializeComponent();
            csvTorneos = new ManejadorCsvTorneos("torneos.csv");
        }

        public Equipo Equipo { get => _equipo;}


        private void FormAltaEquipo_Load(object sender, EventArgs e)
        {

            Torneos = csvTorneos.LeerDatos();

            cbo_torneos.DataSource = Torneos;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string auxNombre;
                string auxTorneo;

                auxNombre = txt_altaNombre.Text;
                auxTorneo = cbo_torneos.Text;

                Validacion.ValidarString(auxNombre);

                _equipo = new Equipo(auxNombre, auxTorneo);

                this.DialogResult = DialogResult.OK;


            }
            catch(Exception excepcion)
            {
                lbl_msjError.Text = excepcion.Message;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

       
    }
}

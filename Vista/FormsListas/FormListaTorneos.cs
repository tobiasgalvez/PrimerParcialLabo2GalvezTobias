﻿using BibliotecaDeClases;
using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.Informes;
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
        Usuario UsuarioIngresado { get; set; }
        GestionEventos GestionEventos { get; set; }

        public FormListaTorneos(Usuario usuarioIngresado, GestionEventos gestionEventos)
        {
            InitializeComponent();
            Torneos = new List<Torneo>();
            //csvTorneos = new ManejadorCsvTorneos("torneos.csv");
            SqlTorneos = new ManejadorSQLTorneos(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
            UsuarioIngresado = usuarioIngresado;
            GestionEventos = gestionEventos;
        }

        private async void ListaTorneos_Load(object sender, EventArgs e)
        {
            //Hardcodeo.HardcodearTorneos(Torneos);
            //Torneos = csvTorneos.LeerDatos();
            Torneos = await SqlTorneos.LeerDatosAsync();

            dgv_listadoTorneos.DataSource = Torneos;
            this.MaximizeBox = false;


            if (UsuarioIngresado.Rol == Enumerados.ERol.Admin)
            {
                btn_exportarCsv.Visible = true;
                btn_exportarJson.Visible = true;
            }

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
                    Logs registro = new Logs
                    {
                        Fecha = DateTime.Now,
                        Usuario = UsuarioIngresado.User,
                        Accion = $"Agregó un nuevo torneo: {torneoIngresado.Nombre}",
                    };

                    GestionEventos.EnviarRegistroLog(registro);

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

        private void btn_exportarCsv_Click(object sender, EventArgs e)
        {
            txt_path.Visible = true;
            btn_exportar.Visible = true;
            btn_exportarCsv.Visible = false;
            btn_exportarJson.Visible = false;

            txt_path.PlaceholderText = "Ingrese path para csv";
        }

        private void btn_exportarJson_Click(object sender, EventArgs e)
        {
            txt_path.Visible = true;
            btn_exportar.Visible = true;
            btn_exportarCsv.Visible = false;
            btn_exportarJson.Visible = false;

            txt_path.PlaceholderText = "Ingrese path para json";
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            string auxPath;
            IInformes<Torneo> informesTorneos;
            bool extensionJson = false;

            if (txt_path.PlaceholderText == "Ingrese path para json")
            {
                extensionJson = true;
            }

            try
            {
                auxPath = txt_path.Text;
                if (extensionJson)
                    Validacion.ValidarExtensionJson(auxPath);
                else
                    Validacion.ValidarExtensionCsv(auxPath);




                informesTorneos = new InformesTorneos(auxPath);

                if (extensionJson)
                    informesTorneos.GuardarDatosJson(Torneos);
                else
                    informesTorneos.GuardarDatosCsv(Torneos);

                MessageBox.Show("Archivo generado con exito!!!");

                lbl_msjError.Visible = false;
                txt_path.Visible = false;
                btn_exportarCsv.Visible = true;
                btn_exportarJson.Visible = true;
                btn_exportar.Visible = false;



            }
            catch (Exception excepcion)
            {
                //MessageBox.Show(excepcion.Message.ToString());
                lbl_msjError.Visible = true;
                lbl_msjError.Text = excepcion.Message;

            }

        }
    }
}

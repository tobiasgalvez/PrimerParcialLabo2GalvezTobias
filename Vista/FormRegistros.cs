using BibliotecaDeClases.ManejadorSQL;
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
using BibliotecaDeClases.Entidades;
using BibliotecaDeClases.Informes;

namespace Vista
{
    public partial class FormRegistros : Form
    {

        List<Logs> ListaRegistros { get; set; }
        IManejadorSQL<Logs> sqlRegistros;
        public Usuario UsuarioIngresado { get; set; }

        public FormRegistros(Usuario usuarioIngresado)
        {
            InitializeComponent();
            ListaRegistros = new List<Logs>();
            sqlRegistros = new ManejadorSQLRegistros(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
            UsuarioIngresado = usuarioIngresado;
        }

        private async void FormRegistros_Load(object sender, EventArgs e)
        {
            ListaRegistros = await sqlRegistros.LeerDatosAsync();
            foreach (var item in ListaRegistros)
            {
            lst_registros.Items.Add(item);

            }

            if (UsuarioIngresado.Rol == Enumerados.ERol.Admin)
            {
                btn_exportarCsv.Visible = true;
                btn_exportarJson.Visible = true;
            }


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
            IInformes<Logs> informesRegistros;
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




                informesRegistros = new InformesRegistros(auxPath);

                if (extensionJson)
                    informesRegistros.GuardarDatosJson(ListaRegistros);
                else
                    informesRegistros.GuardarDatosCsv(ListaRegistros);

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

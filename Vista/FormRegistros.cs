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

namespace Vista
{
    public partial class FormRegistros : Form
    {
        List<Logs> ListaRegistros { get; set; }
        IManejadorSQL<Logs> sqlRegistros;

        public FormRegistros()
        {
            InitializeComponent();
            ListaRegistros = new List<Logs>();
            sqlRegistros = new ManejadorSQLRegistros(@"Server=.;Database=aplicacion;Trusted_Connection=True;");
        }

        private async void FormRegistros_Load(object sender, EventArgs e)
        {
            ListaRegistros = await sqlRegistros.LeerDatosAsync();
            foreach (var item in ListaRegistros)
            {
            lst_registros.Items.Add(item);

            }
        }
    }
}

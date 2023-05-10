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
    public partial class FormListaTorneos : Form
    {
        List<Torneo> Torneos { get; set; }

        public FormListaTorneos()
        {
            InitializeComponent();
            Torneos = new List<Torneo>();
        }

        private void ListaTorneos_Load(object sender, EventArgs e)
        {
            Hardcodeo.HardcodearTorneos(Torneos);
            dgv_listadoTorneos.DataSource = Torneos;
            this.MaximizeBox = false;
        }

        private void btn_agregarResultado_Click(object sender, EventArgs e)
        {
            FormAgregarResultado formAgregarResultado = new FormAgregarResultado();

            DialogResult resultado = formAgregarResultado.ShowDialog(); //para poner foco en el form alta equipo
            if (resultado == DialogResult.OK)
            {
                //Equipo equipoIngresado = altaEquipo.Equipo;
                //ListaEquipos.Add(equipoIngresado);
                MessageBox.Show("Resultado cargado con exito!!!!");
            }
            else
            {
                MessageBox.Show("Se canceló el resultado!!!!");
            }
        }
    }
}

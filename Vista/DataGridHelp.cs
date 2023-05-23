using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDeClases
{
    public static class DataGridHelp<T>
    {
        public static void ActualizarDataGrid(DataGridView dgv, List<T> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data;
            dgv.Refresh();
        }
    }
}

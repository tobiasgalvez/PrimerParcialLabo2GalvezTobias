using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public interface IInformes<T>
    {
        public void GuardarDatosCsv(List<T> lista);
        public void GuardarDatosJson(List<T> lista);

    }
}

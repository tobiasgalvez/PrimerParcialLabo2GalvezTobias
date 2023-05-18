using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorCsv
{
    public abstract class ManejadorCsvBase<T> //'T' parámetro de tipo genérico, permite trabajar con distintos tipos de datos
    {
        protected readonly string _csvFilePath;

        public ManejadorCsvBase(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public abstract List<T> LeerDatos();
        public abstract void AgregarDato(T dato);
        public abstract void ModificarDato(T datoOriginal, T datoModificado);
        public abstract void EliminarDato(T dato);
        public abstract void GuardarDatos(List<T> lista);
    }
}

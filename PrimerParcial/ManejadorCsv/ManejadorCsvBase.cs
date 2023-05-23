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

        /// <summary>
        /// Método por el cual se leen los datos de un csv y se devuelve una lista de objetos
        /// </summary>
        /// <returns></returns>
        public abstract List<T> LeerDatos();
        /// <summary>
        /// Método por el cual se agrega un objeto al csv
        /// </summary>
        /// <param name="dato">objeto a ingresar</param>
        public abstract void AgregarDato(T dato);
        /// <summary>
        /// Método por el cual se modifica un objeto del csv
        /// </summary>
        /// <param name="datoOriginal">objeto original</param>
        /// <param name="datoModificado">objeto modificado</param>
        public abstract void ModificarDato(T datoOriginal, T datoModificado);
        /// <summary>
        /// Método por el cual se elimina un objeto del csv
        /// </summary>
        /// <param name="dato">objeto a eliminar</param>
        public abstract void EliminarDato(T dato);
        /// <summary>
        /// Método por el cual se guardan los datos de los objetos al csv
        /// </summary>
        /// <param name="lista">lista de objetos a guardar</param>
        public abstract void GuardarDatos(List<T> lista);
    }
}

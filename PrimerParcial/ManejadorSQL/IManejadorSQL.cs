using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    public interface IManejadorSQL<T>
    {
        /// <summary>
        /// Funcion que se encarga de leer objetos de una base de datos y devuelve una lista de objetos específica
        /// </summary>
        /// <returns></returns>
        Task<List<T>> LeerDatosAsync();
        /// <summary>
        /// Funcion que se encarga de agregar un dato nuevo a la base de datos mediante una consulta INSERT
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        Task AgregarDatoAsync(T dato);
        /// <summary>
        /// Funcion que se encarga de modificar un dato en la base de datos mediante una consulta UPDATE 
        /// </summary>
        /// <param name="datoOriginal"></param>
        /// <param name="datoModificado"></param>
        /// <returns></returns>
        Task ModificarDatoAsync(T datoOriginal, T datoModificado);
        /// <summary>
        /// Funcion que se encarga de eliminar un dato en la base de datos mediante un UPDATE del atributo 'is_deleted'
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        Task EliminarDatoAsync(T dato);
    }
}

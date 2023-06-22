using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    public interface IManejadorSQL<T>
    {
        Task<List<T>> LeerDatosAsync();
        Task AgregarDatoAsync(T dato);
        Task ModificarDatoAsync(T datoOriginal, T datoModificado);
        Task EliminarDatoAsync(T dato);
    }
}

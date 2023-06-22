using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    public class ManejadorSQLUsuarios : IManejadorSQL<Usuario>
    {
        public Task AgregarDatoAsync(Usuario dato)
        {
            throw new NotImplementedException();
        }

        public Task EliminarDatoAsync(Usuario dato)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> LeerDatosAsync()
        {
            throw new NotImplementedException();
        }

        public Task ModificarDatoAsync(Usuario datoOriginal, Usuario datoModificado)
        {
            throw new NotImplementedException();
        }
    }
}

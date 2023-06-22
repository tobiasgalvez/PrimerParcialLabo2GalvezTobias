using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    public class ManejadorSQLResultados : IManejadorSQL<Partido>
    {
        private readonly string _connectionString;

        public ManejadorSQLResultados(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task AgregarDatoAsync(Partido dato)
        {
            throw new NotImplementedException();
        }

        public Task EliminarDatoAsync(Partido dato)
        {
            throw new NotImplementedException();
        }

        public Task<List<Partido>> LeerDatosAsync()
        {
            throw new NotImplementedException();
        }

        public Task ModificarDatoAsync(Partido datoOriginal, Partido datoModificado)
        {
            throw new NotImplementedException();
        }
    }
}

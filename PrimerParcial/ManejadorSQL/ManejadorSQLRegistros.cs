using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.ManejadorSQL
{
    public class ManejadorSQLRegistros : IManejadorSQL<Logs>
    {
        private readonly string _connectionString;


        public ManejadorSQLRegistros(string connectionString)
        {
            _connectionString = connectionString;
        }


        public async Task<List<Logs>> LeerDatosAsync()
        {
            List<Logs> registros = new List<Logs>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM registros_usuarios", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            registros.Add(new Logs(reader.GetDateTime(1), reader.GetString(2), reader.GetString(3)));
                        }
                    }
                }
            }

           
            return registros;
        }

        public async Task AgregarDatoAsync(Logs registro)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("INSERT INTO registros_usuarios (fecha, usuario, accion) VALUES (@Fecha, @Usuario, @Accion)", connection))
                {
                    command.Parameters.AddWithValue("@Fecha", registro.Fecha);
                    command.Parameters.AddWithValue("@Usuario", registro.Usuario);
                    command.Parameters.AddWithValue("@Accion", registro.Accion);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public Task EliminarDatoAsync(Logs dato)
        {
            throw new NotImplementedException();
        }


        public Task ModificarDatoAsync(Logs datoOriginal, Logs datoModificado)
        {
            throw new NotImplementedException();
        }
    }
}

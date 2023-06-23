using BibliotecaDeClases.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Enumerados;

namespace BibliotecaDeClases.ManejadorSQL
{
    public class ManejadorSQLUsuarios : IManejadorSQL<Usuario>
    {
        private readonly string _connectionString;

        public ManejadorSQLUsuarios(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Usuario>> LeerDatosAsync()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT * FROM usuarios", connection))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            usuarios.Add(new Usuario(reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6), Enum.Parse<ERol>(reader.GetString(7))));
                        }
                    }
                }
            }

            return usuarios;
        }


        public async Task AgregarDatoAsync(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("INSERT INTO usuarios (nombre, apellido, fecha_nacimiento, dni, nombre_usuario, contraseña, rol) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Dni, @NombreUsuario, @Contraseña, @Rol)", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaDeNacimiento);
                    command.Parameters.AddWithValue("@Dni", usuario.Dni);
                    command.Parameters.AddWithValue("@NombreUsuario", usuario.User);
                    command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    command.Parameters.AddWithValue("@Rol", usuario.Rol.ToString());

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task EliminarDatoAsync(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("DELETE FROM usuarios WHERE dni = @Dni", connection))
                {
                    command.Parameters.AddWithValue("@Dni", usuario.Dni);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task ModificarDatoAsync(Usuario usuarioOriginal, Usuario usuarioModificado)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("UPDATE usuarios SET nombre = @NombreModificado, apellido = @ApellidoModificado, dni = @DniModificado, nombre_usuario = @NombreUsuarioModificado, contraseña = @ContraseñaModificado, rol = @RolModificado  WHERE dni = @DniOriginal", connection))
                {
                    command.Parameters.AddWithValue("@NombreModificado", usuarioModificado.Nombre);
                    command.Parameters.AddWithValue("@ApellidoModificado", usuarioModificado.Apellido);

                    command.Parameters.AddWithValue("@DniOriginal", usuarioOriginal.Dni);
                    command.Parameters.AddWithValue("@DniModificado", usuarioModificado.Dni);

                    command.Parameters.AddWithValue("@NombreUsuarioModificado", usuarioModificado.User);
                    command.Parameters.AddWithValue("@ContraseñaModificado", usuarioModificado.Contraseña);
                    command.Parameters.AddWithValue("@RolModificado", usuarioModificado.Rol);


                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}

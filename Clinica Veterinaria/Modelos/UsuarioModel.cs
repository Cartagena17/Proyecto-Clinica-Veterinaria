using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Conexion;
using Modelos.Entidades;

namespace Modelos
{
    public class UsuarioModel
    {
        public bool HayUsuariosRegistrados()
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuarios";
                using (var command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public bool CrearPrimerAdministrador(string usuario, string contraseña)
        {
            using (var connection = Conexiondb.conectar())
            {
                if (HayUsuariosRegistrados()) return false;

                string query = @"INSERT INTO Usuarios (Usuario, Contraseña, Rol) 
                           VALUES (@Usuario, @Contraseña, 'Administrador')";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", BCrypt.Net.BCrypt.HashPassword(contraseña));
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ExisteAdministrador()
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Rol = 'Administrador'";
                using (var command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public Usuario Autenticar(string usuario, string contraseña)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = @"SELECT IdUsuario, Usuario, Contraseña, Rol, Activo, IdEmpleado
                           FROM Usuarios WHERE Usuario = @Usuario AND Activo = 1";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read() && BCrypt.Net.BCrypt.Verify(contraseña, reader["Contraseña"].ToString()))
                        {
                            return new Usuario
                            {
                                IdUsuario = (int)reader["IdUsuario"],
                                NombreUsuario = reader["Usuario"].ToString(),
                                Rol = reader["Rol"].ToString(),
                                Activo = (bool)reader["Activo"],
                                IdEmpleado = reader["IdEmpleado"] as int?
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool CambiarContraseña(int idUsuario, string nuevaContraseña)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = "UPDATE Usuarios SET Contraseña = @Contraseña WHERE IdUsuario = @IdUsuario";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Contraseña", BCrypt.Net.BCrypt.HashPassword(nuevaContraseña));
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool GenerarTokenRecuperacion(string email, string token)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = @"UPDATE Usuarios 
                           SET TokenRecuperacion = @Token, 
                               FechaExpiracionToken = @FechaExpiracion
                           WHERE Usuario = @Email";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Token", token);
                    command.Parameters.AddWithValue("@FechaExpiracion", DateTime.Now.AddHours(2));
                    command.Parameters.AddWithValue("@Email", email);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ValidarTokenRecuperacion(string email, string token)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = @"SELECT COUNT(*) FROM Usuarios 
                           WHERE Usuario = @Email 
                           AND TokenRecuperacion = @Token 
                           AND FechaExpiracionToken > GETDATE()";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Token", token);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public bool CrearUsuarioEmpleado(string usuario, string contraseña, int idEmpleado)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = @"INSERT INTO Usuarios (Usuario, Contraseña, Rol, IdEmpleado) 
                           VALUES (@Usuario, @Contraseña, 'Empleado', @IdEmpleado)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", BCrypt.Net.BCrypt.HashPassword(contraseña));
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UsuarioExiste(string usuario)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public bool EmpleadoTieneCuenta(int idEmpleado)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE IdEmpleado = @IdEmpleado";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public string ObtenerUsuarioPorEmpleado(int idEmpleado)
        {
            using (var connection = Conexiondb.conectar())
            {
                string query = "SELECT Usuario FROM Usuarios WHERE IdEmpleado = @IdEmpleado";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    var result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public string GenerarUsuarioUnico(string nombre, string apellido)
        {
            string usuarioBase = $"{nombre.ToLower().Substring(0, 1)}{apellido.ToLower().Replace(" ", "")}";
            string usuario = usuarioBase;
            int contador = 1;

            while (UsuarioExiste(usuario))
            {
                usuario = $"{usuarioBase}{contador}";
                contador++;
            }

            return usuario;
        }
    }
}

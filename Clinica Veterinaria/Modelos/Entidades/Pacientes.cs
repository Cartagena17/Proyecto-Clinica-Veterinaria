using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Modelos.Conexion;

namespace Modelos.Entidades
{
    public class Pacientes
    {
        private int pacienteID;
        private string nombrePac;
        private string especiePac;
        private string razaPac;
        private DateTime nacimientoPac;
        private decimal pesoPac;
        private string sexoPac;
        private string colorPac;
        public int PropietarioID { get; set; }

        public string NombrePac { get => nombrePac; set => nombrePac = value; }
        public string EspeciePac { get => especiePac; set => especiePac = value; }
        public string RazaPac { get => razaPac; set => razaPac = value; }
        public decimal PesoPac { get => pesoPac; set => pesoPac = value; }
        public string SexoPac { get => sexoPac; set => sexoPac = value; }
        public string ColorPac { get => colorPac; set => colorPac = value; }
        public DateTime NacimientoPac { get => nacimientoPac; set => nacimientoPac = value; }
        public int PacienteID { get => pacienteID; set => pacienteID = value; }

        public string NombreCompleto => $"{NombrePac} ({EspeciePac})";

        public override string ToString()
        {
            return NombreCompleto;
        }

        public bool InsertarPacientes()
        {
            try
            {
                using (SqlConnection conexion = Conexiondb.conectar())
                {
                    string query = @"INSERT INTO Pacientes 
                               (NombrePac, EspeciePac, RazaPac, NacimientoPac, PesoPac, SexoPac, ColorPac, PropietarioID) 
                               VALUES 
                               (@Nombre, @Especie, @Raza, @Nacimiento, @Peso, @Sexo, @Color, @PropietarioID)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", NombrePac);
                        comando.Parameters.AddWithValue("@Especie", EspeciePac);
                        comando.Parameters.AddWithValue("@Raza", RazaPac);
                        comando.Parameters.AddWithValue("@Nacimiento", NacimientoPac);
                        comando.Parameters.AddWithValue("@Peso", PesoPac);
                        comando.Parameters.AddWithValue("@Sexo", SexoPac);
                        comando.Parameters.AddWithValue("@Color", ColorPac);
                        comando.Parameters.AddWithValue("@PropietarioID", PropietarioID);

                        int resultado = comando.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar paciente: {ex.Message}");
            }
        }

        public static List<Pacientes> CargarPacientesPorPropietario(int propietarioID)
        {
            List<Pacientes> listaPacientes = new List<Pacientes>();

            try
            {
                using (SqlConnection conexion = Conexiondb.conectar())
                {
                    string comando = @"SELECT PacienteID, NombrePac, EspeciePac, RazaPac, PropietarioID 
                          FROM Pacientes 
                          WHERE PropietarioID = @PropietarioID 
                          ORDER BY NombrePac";

                    using (SqlCommand cmd = new SqlCommand(comando, conexion))
                    {
                        cmd.Parameters.AddWithValue("@PropietarioID", propietarioID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listaPacientes.Add(new Pacientes
                                {
                                    PacienteID = reader.GetInt32(0),
                                    NombrePac = reader.GetString(1),
                                    EspeciePac = reader.GetString(2),
                                    RazaPac = reader.GetString(3),
                                    PropietarioID = reader.GetInt32(4)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar pacientes: {ex.Message}");
            }

            return listaPacientes;
        }

        public static DataTable CargarPacientes()
        {
            using (SqlConnection conexion = Conexiondb.conectar())
            {
                string comando = "Select *from CargarPacientes";
                SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
        }

        public bool EliminarPaciente(int pacienteID)
        {
            try
            {
                using (SqlConnection conexion = Conexiondb.conectar())
                {
                    string query = "DELETE FROM Pacientes WHERE PacienteID = @PacienteID";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@PacienteID", pacienteID);
                        int resultado = comando.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar paciente: {ex.Message}");
            }
        }

        public bool ActualizarPaciente()
        {
            try
            {
                using (SqlConnection conexion = Conexiondb.conectar())
                {
                    string query = @"UPDATE Pacientes SET 
                               NombrePac = @Nombre,
                               EspeciePac = @Especie,
                               RazaPac = @Raza,
                               NacimientoPac = @Nacimiento,
                               PesoPac = @Peso,
                               SexoPac = @Sexo,
                               ColorPac = @Color,
                               PropietarioID = @PropietarioID
                               WHERE PacienteID = @PacienteID";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@PacienteID", PacienteID);
                        comando.Parameters.AddWithValue("@Nombre", NombrePac);
                        comando.Parameters.AddWithValue("@Especie", EspeciePac);
                        comando.Parameters.AddWithValue("@Raza", RazaPac);
                        comando.Parameters.AddWithValue("@Nacimiento", NacimientoPac);
                        comando.Parameters.AddWithValue("@Peso", PesoPac);
                        comando.Parameters.AddWithValue("@Sexo", SexoPac);
                        comando.Parameters.AddWithValue("@Color", ColorPac);
                        comando.Parameters.AddWithValue("@PropietarioID", PropietarioID);

                        int resultado = comando.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar paciente: {ex.Message}");
            }
        }

        public static DataTable BuscarCita(string busqueda)
        {
            SqlConnection con = Conexiondb.conectar();

            string comando = @"
              SELECT * FROM CargarPacientes
    WHERE Paciente LIKE @busqueda 
       OR Especie LIKE @busqueda 
       OR Raza LIKE @busqueda 
       OR Propietario LIKE @busqueda";

            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
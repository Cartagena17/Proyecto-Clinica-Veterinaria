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
        private string pesoPac;
        private string sexoPac;
        private string colorPac;

        public string NombrePac { get => nombrePac; set => nombrePac = value; }
        public string EspeciePac { get => especiePac; set => especiePac = value; }
        public string RazaPac { get => razaPac; set => razaPac = value; }
        
        public string PesoPac { get => pesoPac; set => pesoPac = value; }
        public string SexoPac { get => sexoPac; set => sexoPac = value; }
        public string ColorPac { get => colorPac; set => colorPac = value; }
        public DateTime NacimientoPac { get => nacimientoPac; set => nacimientoPac = value; }
        public int PacienteID { get => pacienteID; set => pacienteID = value; }

        public bool InsertarPacientes()
        {

            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO Pacientes ( NombrePac, EspeciePac, RazaPac, NacimientoPac, PesoPac, SexoPac, ColorPac) " +
                "VALUES ( @nombrePac, @especiePac, @razaPac, @nacimientoPac, @pesoPac, @sexoPac, @colorPac)";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@nombrePac",nombrePac);
            cmd.Parameters.AddWithValue("@especiePac",especiePac);
            cmd.Parameters.AddWithValue("@razaPac",razaPac);
            cmd.Parameters.AddWithValue("nacimientoPac",NacimientoPac);
            cmd.Parameters.AddWithValue("@pesoPac",pesoPac);
            cmd.Parameters.AddWithValue("@sexoPac",sexoPac);
            cmd.Parameters.AddWithValue("@colorPac",colorPac);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static DataTable CargarPacientes()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "select *from CargarPacientes;";

            SqlDataAdapter ad = new SqlDataAdapter(comando,conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool EliminarPaciente(int id)
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "DELETE FROM Pacientes WHERE pacienteID=@pacienteID;";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@pacienteID", id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ActualizarPaciente()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "UPDATE Pacientes SET " +
                             "NombrePac = @NombrePac, " +
                             "EspeciePac = @EspeciePac, " +
                             "RazaPac = @RazaPac, " +
                             "NacimientoPac = @NacimientoPac, " +
                             "PesoPac = @PesoPac, " +
                             "SexoPac = @SexoPac, " +
                             "ColorPac = @ColorPac " +
                             "WHERE PacienteID = @PacienteID;";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@NombrePac", NombrePac);
            cmd.Parameters.AddWithValue("@EspeciePac", EspeciePac);
            cmd.Parameters.AddWithValue("@RazaPac", RazaPac);
            cmd.Parameters.AddWithValue("@NacimientoPac", NacimientoPac);
            cmd.Parameters.AddWithValue("@PesoPac", PesoPac);
            cmd.Parameters.AddWithValue("@SexoPac", SexoPac);
            cmd.Parameters.AddWithValue("@ColorPac", ColorPac);
            cmd.Parameters.AddWithValue("@PacienteID", PacienteID);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

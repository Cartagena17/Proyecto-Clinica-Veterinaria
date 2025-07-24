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

        private int propietarioID;
        private string nombrePac;
        private string especiePac;
        private string razaPac;
        private DateTime nacimientoPac;
        private string pesoPac;
        private string sexoPac;
        private string colorPac;

        public int PropietarioID { get => propietarioID; set => propietarioID = value; }
        public string NombrePac { get => nombrePac; set => nombrePac = value; }
        public string EspeciePac { get => especiePac; set => especiePac = value; }
        public string RazaPac { get => razaPac; set => razaPac = value; }
        
        public string PesoPac { get => pesoPac; set => pesoPac = value; }
        public string SexoPac { get => sexoPac; set => sexoPac = value; }
        public string ColorPac { get => colorPac; set => colorPac = value; }
        public DateTime NacimientoPac { get => nacimientoPac; set => nacimientoPac = value; }

        public bool InsertarPacientes()
        {

            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO Pacientes (PropietarioID, NombrePac, EspeciePac, RazaPac, NacimientoPac, PesoPac, SexoPac, ColorPac) " +
                "VALUES (@PropietarioID, @nombrePac, @especiePac, @razaPac, @nacimientoPac, @pesoPac, @sexoPac, @colorPac)";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@propietarioID", propietarioID);
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

            string comando = "select *from Pacientes;";

            SqlDataAdapter ad = new SqlDataAdapter(comando,conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
            
        
        
        
    }
}

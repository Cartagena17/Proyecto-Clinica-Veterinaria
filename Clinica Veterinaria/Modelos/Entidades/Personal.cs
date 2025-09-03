using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Personal
    {
        private int personalID;
        private string nombrePers;
        private string apellidoPers;
        private string telefonoPers;
        private string emailPers;


        public string NombrePers { get => nombrePers; set => nombrePers = value; }
        public string ApellidoPers { get => apellidoPers; set => apellidoPers = value; }
        public string TelefonoPers { get => telefonoPers; set => telefonoPers = value; }
        public string EmailPers { get => emailPers; set => emailPers = value; }
        public int PersonalID { get => personalID; set => personalID = value; }

        public bool InsertarPersonal()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO Personal (NombrePers, ApellidoPers, , TelefonoPers, EmailPers) " +
                "VALUES(@NombrePers,@ApellidoPers,@TelefonoPers,@EmailPers);";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@Nombrepers", nombrePers);
            cmd.Parameters.AddWithValue("@ApellidoPers", apellidoPers);
            cmd.Parameters.AddWithValue("@TelefonoPers", telefonoPers);
            cmd.Parameters.AddWithValue("@EmailPers", emailPers);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable CargarPersonal()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "select *from Personal";

            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;

        }


        public bool EliminarPersonal(int id)
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "DELETE FROM Personal WHERE personalID=@personalID;";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@personalID", id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ActualizarPersonal()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "UPDATE Personal SET nombrePers=@NombrePers, TelefonoPers=@TelefonoPers, " +
                             "apellidoPers=@ApellidoPErs, EmailPers=@EmailPers  " +
                             "WHERE personalID=@personalID;";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@NombrePers", NombrePers);
            cmd.Parameters.AddWithValue("@TelefonoPers", TelefonoPers);
            cmd.Parameters.AddWithValue("@ApellidoPers",ApellidoPers );
            cmd.Parameters.AddWithValue("@EmailPers", EmailPers);
            cmd.Parameters.AddWithValue("@personalID", PersonalID);

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

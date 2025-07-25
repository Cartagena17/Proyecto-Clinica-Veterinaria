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
        private string nombrePers;
        private string apellidoPers;
        private string rol;
        private string telefonoPers;
        private string emailPers;


        public string NombrePers { get => nombrePers; set => nombrePers = value; }
        public string ApellidoPers { get => apellidoPers; set => apellidoPers = value; }
        public string Rol { get => rol; set => rol = value; }
        public string TelefonoPers { get => telefonoPers; set => telefonoPers = value; }
        public string EmailPers { get => emailPers; set => emailPers = value; }

        public bool InsertarPersonal()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO Personal (NombrePers, ApellidoPers, Rol, TelefonoPers, EmailPers) " +
                "VALUES(@NombrePers,@ApellidoPers,@Rol,@TelefonoPers,@EmailPers);";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@Nombrepers", nombrePers);
            cmd.Parameters.AddWithValue("@ApellidoPers", apellidoPers);
            cmd.Parameters.AddWithValue("@rol", rol);
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


    }
}

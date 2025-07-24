using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelos.Conexion;

namespace Modelos.Entidades 
{
    public class Propietarios
    {
        private int PropietarioID;
        private string NombreProp;
        private string TelefonoProp;
        private string DireccionProp;
        private string EmailProp;

        public int PropietarioID1 { get => PropietarioID; set => PropietarioID = value; }
        public string NombreProp1 { get => NombreProp; set => NombreProp = value; }
        public string TelefonoProp1 { get => TelefonoProp; set => TelefonoProp = value; }
        public string DireccionProp1 { get => DireccionProp; set => DireccionProp = value; }
        public string EmailProp1 { get => EmailProp; set => EmailProp = value; }
        



        public bool InsertarPropietarios()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "Insert into propietarios (NombreProp,TelefonoProp,DireccionProp,EmailProp)" +
                " values(@NombreProp,@TelefonoProp,@DireccionProp,@EmailProp);";

            SqlCommand cmd = new SqlCommand(comando,conexion);

            cmd.Parameters.AddWithValue("@NombreProp", NombreProp);
            cmd.Parameters.AddWithValue("@TelefonoProp",TelefonoProp);
            cmd.Parameters.AddWithValue("@DireccionProp",DireccionProp);
            cmd.Parameters.AddWithValue("@EmailProp",EmailProp);

            
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static DataTable CargarPropietarios()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "select *from Propietarios;";

            SqlDataAdapter ad = new SqlDataAdapter(comando,conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;

        }
       

        



    }
}

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

        private string NombreProp;
        private string TelefonoProp;
        private string DireccionProp;
        private string EmailProp;
        private int id;

        public string NombreProp1 { get => NombreProp; set => NombreProp = value; }
        public string TelefonoProp1 { get => TelefonoProp; set => TelefonoProp = value; }
        public string DireccionProp1 { get => DireccionProp; set => DireccionProp = value; }
        public string EmailProp1 { get => EmailProp; set => EmailProp = value; }
        public int Id { get => id; set => id = value; }

        public bool InsertarPropietarios()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "Insert into propietarios (NombreProp,TelefonoProp,DireccionProp,EmailProp)" +
                " values(@NombreProp,@TelefonoProp,@DireccionProp,@EmailProp);";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@NombreProp", NombreProp);
            cmd.Parameters.AddWithValue("@TelefonoProp", TelefonoProp);
            cmd.Parameters.AddWithValue("@DireccionProp", DireccionProp);
            cmd.Parameters.AddWithValue("@EmailProp", EmailProp);


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

            string comando = "select *from CargarPropietarios;";

            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;

        }



        public override string ToString()
        {
            return NombreProp1;
        }
        public static List<Propietarios> CargarPropietariosCB()
        {
            List<Propietarios> ListaPropietarios = new List<Propietarios>();

            try
            {
                SqlConnection con = Conexiondb.conectar();

                string comando = "select propietarioid, NombreProp from Propietarios;";
                SqlCommand cmd = new SqlCommand(comando, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListaPropietarios.Add(new Propietarios
                    {
                        Id = reader.GetInt32(0),
                        NombreProp1 = reader.GetString(1)

                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar propietario: {ex.Message}");
            }
            return ListaPropietarios;
        }

        //public static DataTable CargarCBPropietarios()
        //{
        //    SqlConnection conexion = Conexiondb.conectar();

        //    string comando = "select NombreProp from Propietarios;";

        //    SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

        //    DataTable dt = new DataTable();
        //    ad.Fill(dt);

        //    return dt;

        //}

        public bool ActualizarPropietario()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "UPDATE Propietarios SET NombreProp=@NombreProp, TelefonoProp=@TelefonoProp, " +
                             "DireccionProp=@DireccionProp, EmailProp=@EmailProp " +
                             "WHERE propietarioID=@propietarioID;";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@NombreProp", NombreProp);
            cmd.Parameters.AddWithValue("@TelefonoProp", TelefonoProp);
            cmd.Parameters.AddWithValue("@DireccionProp", DireccionProp);
            cmd.Parameters.AddWithValue("@EmailProp", EmailProp);
            cmd.Parameters.AddWithValue("@propietarioID", Id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarPropietario(int id)
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "DELETE FROM Propietarios WHERE propietarioID=@propietarioID;";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@propietarioID", id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable BuscarPropietarios(string valor)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = Conexiondb.conectar())
                {
                    string comando = @"SELECT * FROM Propietarios 
                               WHERE NombreProp LIKE @valor 
                                  OR TelefonoProp LIKE @valor 
                                  OR DireccionProp LIKE @valor 
                                  OR EmailProp LIKE @valor";

                    SqlCommand cmd = new SqlCommand(comando, conexion);
                    cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar propietarios: {ex.Message}");
            }
            return dt;


        }
    }
}

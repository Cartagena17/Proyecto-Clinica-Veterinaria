using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Conexion;

namespace Modelos.Entidades
{
    public class Citas
    {
        private int PacientID;
        private int PropietarioID;
        private int PersonalID;
        private DateTime FechaCita;
        private string HoraCita;
        private string MotivoCita;

        public int PacientID1 { get => PacientID; set => PacientID = value; }
        public int PropietarioID1 { get => PropietarioID; set => PropietarioID = value; }
        public int PersonalID1 { get => PersonalID; set => PersonalID = value; }
        public DateTime FechaCita1 { get => FechaCita; set => FechaCita = value; }
        public string HoraCita1 { get => HoraCita; set => HoraCita = value; }
        public string MotivoCita1 { get => MotivoCita; set => MotivoCita = value; }

        public static DataTable CargarCitas()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "select *from Citas;";

            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;

        }



        public bool InsertarCita()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO Citas (PacienteID, PropietarioID, PersonalID, FechaCita, HoraCita, MotivoCita) " +
                "VALUES(@PacienteID, @PropietarioID, @PersonalID, @FechaCita, @HoraCita, @MotivoCita);";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("PacienteID", PacientID);
            cmd.Parameters.AddWithValue("PropietarioID", PropietarioID);
            cmd.Parameters.AddWithValue("PersonalID", PersonalID);
            cmd.Parameters.AddWithValue("FechaCita", FechaCita);
            cmd.Parameters.AddWithValue("HoraCita", HoraCita);
            cmd.Parameters.AddWithValue("MotivoCita", MotivoCita);

            if (cmd.ExecuteNonQuery() >0)
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

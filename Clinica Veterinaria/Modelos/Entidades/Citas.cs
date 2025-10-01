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
        private int citaID;
        private int pacienteID;
        private int propietarioID;
        private int personalID;
        private DateTime fechaCita;
        private string horaCita;
        private string motivoCita;
        private string notasCita;

        public int PacienteID { get => pacienteID; set => pacienteID = value; }
        public int PropietarioID { get => propietarioID; set => propietarioID = value; }
        public int PersonalID { get => personalID; set => personalID = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public string HoraCita { get => horaCita; set => horaCita = value; }
        public string MotivoCita { get => motivoCita; set => motivoCita = value; }
        public string NotasCita { get => notasCita; set => notasCita = value; }
        public int CitaID { get => citaID; set => citaID = value; }

        public static DataTable CargarCitas()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "select *from CargarCitas2;";

            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;

        }



        public bool InsertarCita()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO Citas ( PropietarioID,PacienteID, PersonalID, FechaCita, HoraCita, MotivoCita,NotasCita) " +
                "VALUES( @PropietarioID,@PacienteID, @PersonalID, @FechaCita, @HoraCita, @MotivoCita,@NotasCita);";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("PacienteID", PacienteID);
            cmd.Parameters.AddWithValue("PropietarioID", PropietarioID);
            cmd.Parameters.AddWithValue("PersonalID", PersonalID);
            cmd.Parameters.AddWithValue("FechaCita", FechaCita);
            cmd.Parameters.AddWithValue("HoraCita", HoraCita);
            cmd.Parameters.AddWithValue("MotivoCita", MotivoCita);
            //cmd.Parameters.AddWithValue("NotasCita", NotasCita);
            cmd.Parameters.AddWithValue("@NotasCita", NotasCita);


            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool ActualizarCita()
        {
            SqlConnection con = Conexiondb.conectar();
            string comando = @"UPDATE Citas
                         SET FechaCita = @FechaCita,
                             HoraCita = @HoraCita,
                             MotivoCita = @MotivoCita,
                             NotasCita = @NotasCita
                         WHERE CitaID = @CitaID";

            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@FechaCita", FechaCita);
            cmd.Parameters.AddWithValue("@HoraCita", HoraCita);
            cmd.Parameters.AddWithValue("@MotivoCita", MotivoCita);
            cmd.Parameters.AddWithValue("@NotasCita", NotasCita);
            cmd.Parameters.AddWithValue("@CitaID", CitaID);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCita()
        {
            SqlConnection con = Conexiondb.conectar();

            string comando = "DELETE FROM Citas WHERE CitaID = @CitaID";

            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@CitaID", CitaID);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable CargarCitasCB()
        {
            SqlConnection conexion = Conexiondb.conectar();
            string comando = @"
            SELECT c.CitaId, 
                   (p.NombrePac + ' / ' + pr.NombreProp + ' / ' + CONVERT(varchar, c.FechaCita, 103)) AS InfoCita,
                   c.FechaCita
            FROM Citas c
            INNER JOIN Pacientes p ON c.PacienteID = p.PacienteID
            INNER JOIN Propietarios pr ON c.PropietarioID = pr.PropietarioID
        ";
            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }


        //public void CargarNombresEnComboBox()
        //{
        //    SqlConnection con = Conexiondb.conectar();

        //    string query = "SELECT Nombre FROM Personas";

        //    try
        //    {
        //        con.Open();
        //        SqlCommand command = new SqlCommand(query, con);
        //        SqlDataReader reader = command.ExecuteReader();

        //        comboBoxNombres.Items.Clear(); // Limpia antes de cargar

        //        while (reader.Read())
        //        {
        //            comboBoxNombres.Items.Add(reader["Nombre"].ToString());
        //        }

        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar nombres: " + ex.Message);
        //    }

        //}
    }
}

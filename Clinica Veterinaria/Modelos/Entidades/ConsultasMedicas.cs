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
    public class ConsultasMedicas
    {

        private int CitaID;
        private string Sintomas;
        private string diagnostico;
        private string tratamiento;
        private string observaciones;
        private string pesoActual;
        private string temperatura;


        public int CitaID1 { get => CitaID; set => CitaID = value; }
        public string Sintomas1 { get => Sintomas; set => Sintomas = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string PesoActual { get => pesoActual; set => pesoActual = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }

        public bool InsertarConsultasMedicas()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO ConsultasMedicas (CitaID, Sintomas, Diagnostico, Tratamiento, Observaciones, PesoActual, Temperatura) " +
                "VALUES( @CitaID, @Sintomas, @Diagnostico, @Tratamiento, @Observaciones, @PesoActual,@Temperatura)";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@CitaID", CitaID);
            cmd.Parameters.AddWithValue("@Sintomas", Sintomas);
            cmd.Parameters.AddWithValue("@Diagnostico", diagnostico);
            cmd.Parameters.AddWithValue("@Tratamiento", tratamiento);
            cmd.Parameters.AddWithValue("@Observaciones", observaciones);
            cmd.Parameters.AddWithValue("@PesoActual", pesoActual);
            cmd.Parameters.AddWithValue("@Temperatura", temperatura);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        

        public static DataTable CargarConsultasMedicas()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "select *from CargarConsultasMedicas";

            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;

        }

        public bool ActualizarConsultasMedicas()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "UPDATE ConsultasMedicas SET " +
                             "Sintomas = @Sintomas, " +
                             "Diagnostico = @Diagnostico, " +
                             "Tratamiento = @Tratamiento, " +
                             "Observaciones = @Observaciones, " +
                             "PesoActual = @PesoActual, " +
                             "Temperatura = @Temperatura " +
                             "WHERE CitaID = @CitaID";

            SqlCommand cmd = new SqlCommand(comando, conexion);

            cmd.Parameters.AddWithValue("@CitaID", CitaID);
            cmd.Parameters.AddWithValue("@Sintomas", Sintomas);
            cmd.Parameters.AddWithValue("@Diagnostico", diagnostico);
            cmd.Parameters.AddWithValue("@Tratamiento", tratamiento);
            cmd.Parameters.AddWithValue("@Observaciones", observaciones);
            cmd.Parameters.AddWithValue("@PesoActual", pesoActual);
            cmd.Parameters.AddWithValue("@Temperatura", temperatura);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarConsultasMedicas()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "DELETE FROM ConsultasMedicas WHERE CitaID = @CitaID";

            SqlCommand cmd = new SqlCommand(comando, conexion);
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




    }
}

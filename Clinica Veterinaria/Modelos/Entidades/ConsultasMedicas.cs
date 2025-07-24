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
        
        private int PacienteID;
        private int PersonalID;
        private int CitaID;
        private DateTime FechaConsulta;
        private string Sintomas;
        private string diagnostico;
        private string tratamiento;
        private string observaciones;
        private string pesoActual;
        private string temperatura;

        public int PacienteID1 { get => PacienteID; set => PacienteID = value; }
        public int PersonalID1 { get => PersonalID; set => PersonalID = value; }
        public int CitaID1 { get => CitaID; set => CitaID = value; }
        public DateTime FechaConsulta1 { get => FechaConsulta; set => FechaConsulta = value; }
        public string Sintomas1 { get => Sintomas; set => Sintomas = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string PesoActual { get => pesoActual; set => pesoActual = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }

        public bool InsertarConsultasMedicas()
        {
            SqlConnection conexion = Conexiondb.conectar();

            string comando = "INSERT INTO ConsultasMedicas (PacienteID, PersonalID, CitaID, FechaConsulta, Sintomas, Diagnostico, Tratamiento, Observaciones, PesoActual, Temperatura) " +
                "VALUES(@PacienteID, @PersonalID, @CitaID, @FechaConsulta, @Sintomas, @Diagnostico, @Tratamiento, @Observaciones, @PesoActual,@Temperatura)";

            SqlCommand cmd = new SqlCommand(comando, conexion);

             cmd.Parameters.AddWithValue("@PacienteID", PacienteID);
            cmd.Parameters.AddWithValue("@PersonalID",PersonalID);
            cmd.Parameters.AddWithValue("@CitaID",CitaID);
            cmd.Parameters.AddWithValue("@FechaConsulta",FechaConsulta);
            cmd.Parameters.AddWithValue("@Sintomas",Sintomas);
            cmd.Parameters.AddWithValue("@Diagnostico",diagnostico);
            cmd.Parameters.AddWithValue("@Tratamiento",tratamiento);
            cmd.Parameters.AddWithValue("@Observaciones",observaciones);
            cmd.Parameters.AddWithValue("@PesoActual",pesoActual);
            cmd.Parameters.AddWithValue("@Temperatura",temperatura);

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

            string comando = "select *from ConsultasMedicas;";

            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;

        }



    }
}

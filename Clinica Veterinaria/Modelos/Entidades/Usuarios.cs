using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Usuarios
    {
        private int usuarioId;
        private string usuario;
        private string contraseña;

        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

         

        //public static DataTable CargarUsuarios()
        //{
        //    SqlConnection conexion = Conexiondb.conectar();

        //    string comando = "select *from Usuarios;";

        //    SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);

        //    DataTable dt = new DataTable();
        //    ad.Fill(dt);

        //    return dt;
        //}


    }
}

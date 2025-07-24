using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmIncio_Sesion : Form
    {
        public frmIncio_Sesion()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            SqlConnection con = Conexiondb.conectar();
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string comando = "select *from usuario where nombre_Usuario = @usuario and clave = @clave;";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@clave", contraseña);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Bienvenido");
                frmDashboardPrincipal dashboard = new frmDashboardPrincipal();

                dashboard.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Los Parametros no coinciden");
            }

           // frmDashboardPrincipal dashboard = new frmDashboardPrincipal();
             
           // dashboard.Show();

           //this.Close();
            
        }
    }
}

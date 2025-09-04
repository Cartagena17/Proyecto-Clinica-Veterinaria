using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Conexion;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmGestionPropietarios : Form
    {
        public frmGestionPropietarios()
        {
            InitializeComponent();
        }

        private void btnRegistrarPropietario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Nombre.Text) ||
        !Regex.IsMatch(txtGestionPropietario_Nombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un nombre válido (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Telefono.Text) ||
                !Regex.IsMatch(txtGestionPropietario_Telefono.Text, @"^[0-9]{8,15}$"))
            {
                MessageBox.Show("Debe ingresar un teléfono válido (mínimo 8 dígitos, solo números).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Direccion.Text))
            {
                MessageBox.Show("Debe ingresar una dirección.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Email.Text) ||
                !Regex.IsMatch(txtGestionPropietario_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Debe ingresar un email válido (ejemplo: correo@dominio.com).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            Propietarios p = new Propietarios();
            p.NombreProp1 = txtGestionPropietario_Nombre.Text;
            p.TelefonoProp1 = txtGestionPropietario_Telefono.Text;
            p.DireccionProp1 = txtGestionPropietario_Direccion.Text;
            p.EmailProp1 = txtGestionPropietario_Email.Text;
             
            p.InsertarPropietarios();
            Propietarios.CargarPropietarios();
            MessageBox.Show("Propietario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmGestionPropietarios_Load(object sender, EventArgs e)
        {
            MostarPropietarios();
        }
        private void MostarPropietarios()
        {
            dgvPropietarios.DataSource = null;
            dgvPropietarios.DataSource = Propietarios.CargarPropietarios();
        }

        private void btnVerPropietarios_Click(object sender, EventArgs e)
        {
        //    string nombreProp = string.IsNullOrWhiteSpace(txtGestionPropietario_Nombre.Text) ? null : txtGestionPropietario_Nombre.Text.Trim();
        //    string telefonoProp = string.IsNullOrWhiteSpace(txtGestionPropietario_Telefono.Text) ? null : txtGestionPropietario_Telefono.Text.Trim();
        //    string DireccionProp = string.IsNullOrWhiteSpace(txtGestionPropietario_Direccion.Text) ? null : txtGestionPropietario_Direccion.Text.Trim();
        //    string EmailProp = string.IsNullOrWhiteSpace(txtGestionPropietario_Email.Text) ? null : txtGestionPropietario_Email.Text.Trim();

        //    using (SqlConnection conexion = Conexiondb.conectar())
        //    {
        //        string query = @"SELECT * FROM Propietarios
        //                 WHERE (@nombreProp IS NULL OR NombreProp LIKE '%' + @NombreProp + '%')
        //                 AND (@telefonoProp IS NULL O/74512R TelefonoProp LIKE '%' + @TelefonoProp + '%')
        //                 AND (@direccionProp IS NULL OR DireccionProp LIKE '%' + @DireccionProp + '%')
        //                  AND (@emailProp IS NULL OR emailProp LIKE '%' + @EmailProp + '%')";
                
        //        SqlCommand cmd = new SqlCommand(query, conexion);
        //        cmd.Parameters.AddWithValue("@nombreProp", (object)nombreProp ?? DBNull.Value);
        //        cmd.Parameters.AddWithValue("@telefonoProp", (object)telefonoProp ?? DBNull.Value);
        //        cmd.Parameters.AddWithValue("@direccionProp", (object)DireccionProp ?? DBNull.Value);
        //        cmd.Parameters.AddWithValue("@emailprop", (object)EmailProp ?? DBNull.Value);

        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataTable tabla = new DataTable();

        //        adapter.Fill(tabla);

        //        dgvPropietarios.DataSource = tabla;
            
        }

        private void btnEliminarPropietario_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPropietarios.CurrentRow.Cells[0].Value.ToString());
            Propietarios p = new Propietarios();
            if (p.EliminarPropietario(id) == true)
            {
                MessageBox.Show("El registro se ah borrado con exito");
                MostarPropietarios();
            }
            else
            {
                MessageBox.Show("Se ah producido un ERROR");
            }

        }

        private void btnActualizarInfoPropietario_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Nombre.Text) ||
        !Regex.IsMatch(txtGestionPropietario_Nombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un nombre válido (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Telefono.Text) ||
                !Regex.IsMatch(txtGestionPropietario_Telefono.Text, @"^[0-9]{8,15}$"))
            {
                MessageBox.Show("Debe ingresar un teléfono válido (mínimo 8 dígitos, solo números).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Direccion.Text))
            {
                MessageBox.Show("Debe ingresar una dirección.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Email.Text) ||
                !Regex.IsMatch(txtGestionPropietario_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Debe ingresar un email válido (ejemplo: correo@dominio.com).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Propietarios p = new Propietarios();
            p.NombreProp1 = txtGestionPropietario_Nombre.Text;
            p.TelefonoProp1 = txtGestionPropietario_Telefono.Text;
            p.DireccionProp1 = txtGestionPropietario_Direccion.Text;
            p.EmailProp1 = txtGestionPropietario_Email.Text;
            p.Id = int.Parse(dgvPropietarios.CurrentRow.Cells[0].Value.ToString());

            if (p.ActualizarPropietario() == true)
            {
                MessageBox.Show("El registro se ah actualizado con exito");
                MostarPropietarios();
            }
            else
            {
                MessageBox.Show("ah ocurrido un ERROR");
            }
        }

        private void dgvPropietarios_DoubleClick(object sender, EventArgs e)
        {
            txtGestionPropietario_Nombre.Text = dgvPropietarios.CurrentRow.Cells[1].Value.ToString();
            txtGestionPropietario_Telefono.Text=dgvPropietarios.CurrentRow.Cells[2].Value.ToString();
            txtGestionPropietario_Direccion.Text = dgvPropietarios.CurrentRow.Cells[3].Value.ToString();
            txtGestionPropietario_Email.Text = dgvPropietarios.CurrentRow.Cells[4].Value.ToString();



        }
    }
}

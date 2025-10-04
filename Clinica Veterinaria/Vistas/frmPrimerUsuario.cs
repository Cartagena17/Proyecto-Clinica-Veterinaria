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
using Modelos;
using Modelos.Conexion;
using Modelos.Entidades;

namespace Vistas
{
    public partial class frmPrimerUsuario : Form
    {
        private UsuarioModel usuarioModel = new UsuarioModel();

        public frmPrimerUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexiondb.conectar())
                {
                    // 1️⃣ Verificar si ya existe un administrador
                    string checkAdmin = "SELECT COUNT(*) FROM Usuarios WHERE Rol = 'Admin'";
                    SqlCommand cmdCheck = new SqlCommand(checkAdmin, con);
                    int existeAdmin = (int)cmdCheck.ExecuteScalar();

                    if (existeAdmin > 0)
                    {
                        MessageBox.Show("Ya existe un administrador. Solo se puede crear uno.");
                        return;
                    }

                    // 2️⃣ Validaciones básicas
                    string usuario = txtUsuario.Text.Trim();
                    string contraseña = txtContraseña.Text.Trim();
                    string confirmar = txtConfirmar.Text.Trim();
                    string email = txtEmail.Text.Trim();

                    if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(email))
                    {
                        MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (contraseña.Length < 6)
                    {
                        MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (contraseña != confirmar)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 3️⃣ Obtener el primer empleado registrado para asociar
                    string queryEmpleado = "SELECT TOP 1 personalid FROM Personal ORDER BY personalid ASC";
                    SqlCommand cmdEmpleado = new SqlCommand(queryEmpleado, con);
                    object result = cmdEmpleado.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("No hay empleados registrados para asignar usuario.");
                        return;
                    }

                    int idPersonal = Convert.ToInt32(result);

                    // 4️⃣ Insertar el primer usuario como Admin con email
                    string queryInsert = @"INSERT INTO Usuarios (Usuario, Contraseña, Rol, personalid, Email) 
                                       VALUES (@usuario, @contrasena, @rol, @idpersonal, @correo)";

                    SqlCommand cmdInsert = new SqlCommand(queryInsert, con);
                    cmdInsert.Parameters.AddWithValue("@usuario", usuario);
                    cmdInsert.Parameters.AddWithValue("@contrasena", contraseña);
                    cmdInsert.Parameters.AddWithValue("@rol", "Administrador"); // Primer usuario siempre Admin
                    cmdInsert.Parameters.AddWithValue("@idpersonal", idPersonal);
                    cmdInsert.Parameters.AddWithValue("@correo", email);

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Usuario administrador creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir login y cerrar este form
                    var frmLogin = new frmLogin();
                    frmLogin.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de cancelar? El sistema no podrá usarse sin un administrador.",
                                       "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !chkMostrar.Checked;
            txtConfirmar.UseSystemPasswordChar = !chkMostrar.Checked;
        }
    }
}

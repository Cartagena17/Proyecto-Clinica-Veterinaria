using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

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
                string usuario = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text;
                string confirmar = txtConfirmar.Text;

                if (string.IsNullOrWhiteSpace(usuario))
                {
                    MessageBox.Show("El usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }

                if (contraseña.Length < 6)
                {
                    MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Focus();
                    return;
                }

                if (contraseña != confirmar)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmar.Focus();
                    return;
                }

                if (usuarioModel.CrearPrimerAdministrador(usuario, contraseña))
                {
                    MessageBox.Show($"Usuario administrador creado exitosamente.\n\nUsuario: {usuario}",
                                  "Configuración Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var frmLogin = new frmLogin();
                    frmLogin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al crear el usuario administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

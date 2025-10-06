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
    public partial class frmRecuperarContraseña : Form
    {
        private UsuarioModel usuarioModel = new UsuarioModel();
        private EmailService emailService = new EmailService();
        private string tokenGenerado;

        public frmRecuperarContraseña()
        {
            InitializeComponent();
            ConfigurarPanelesIniciales();
        }

        private void ConfigurarPanelesIniciales()
        {
            pnlEmail.Visible = true;
            pnlEmail.Enabled = true;
            pnlToken.Visible = false;
            pnlToken.Enabled = false;
            pnlNuevaContraseña.Visible = false;
            pnlNuevaContraseña.Enabled = false;
        }

        private async void btnEnviarToken_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Por favor ingrese su email.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 🔹 Validar si existe usuario con ese email
                if (!usuarioModel.EmailExiste(email))
                {
                    MessageBox.Show("No existe un usuario con este email.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generar token de 6 dígitos
                Random random = new Random();
                tokenGenerado = random.Next(100000, 999999).ToString();

                btnEnviarToken.Text = "Enviando...";
                btnEnviarToken.Enabled = false;

                if (usuarioModel.GenerarTokenRecuperacion(email, tokenGenerado))
                {
                    if (await emailService.EnviarEmailRecuperacion(email, tokenGenerado))
                    {
                        pnlEmail.Visible = false;
                        pnlToken.Visible = true;
                        pnlToken.Enabled = true;
                        txtToken.Focus();

                        MessageBox.Show("Código enviado correctamente. Revisa tu email.",
                                      "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnEnviarToken.Text = "Enviar Código";
                btnEnviarToken.Enabled = true;
            }
        }

        private void btnVerificarToken_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string token = txtToken.Text.Trim();

                if (string.IsNullOrWhiteSpace(token))
                {
                    MessageBox.Show("Por favor ingrese el código de verificación.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtToken.Focus();
                    return;
                }

                if (usuarioModel.ValidarTokenRecuperacion(email, token))
                {
                    pnlToken.Visible = false;
                    pnlNuevaContraseña.Visible = true;
                    pnlNuevaContraseña.Enabled = true;
                    txtNuevaContraseña.Focus();

                    MessageBox.Show("Código verificado correctamente. Ahora puede crear una nueva contraseña.",
                                  "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Código inválido o expirado.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtToken.Clear();
                    txtToken.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string nuevaContraseña = txtNuevaContraseña.Text;
                string confirmar = txtConfirmarContraseña.Text;

                if (nuevaContraseña.Length < 6)
                {
                    MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaContraseña.Focus();
                    return;
                }

                if (nuevaContraseña != confirmar)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmarContraseña.Focus();
                    return;
                }

                int idUsuario = usuarioModel.ObtenerIdUsuarioPorEmail(email);
                if (idUsuario <= 0)
                {
                    MessageBox.Show("No se encontró el usuario asociado a este email.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                    if (usuarioModel.CambiarContraseña(idUsuario, nuevaContraseña))
                    {
                        MessageBox.Show("Contraseña cambiada exitosamente. Ahora puede iniciar sesión con su nueva contraseña.",
                                      "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolverEmail_Click(object sender, EventArgs e)
        {
            pnlToken.Visible = false;
            pnlEmail.Visible = true;
            txtEmail.Focus();
        }

        private void btnVolverToken_Click(object sender, EventArgs e)
        {
            pnlNuevaContraseña.Visible = false;
            pnlToken.Visible = true;
            txtToken.Focus();
        }

        private void txtToken_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnVerificarToken_Click(sender, e);
            }
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCambiarContraseña_Click(sender, e);
            }
        }
    }
}

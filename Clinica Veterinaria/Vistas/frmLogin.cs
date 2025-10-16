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
using Vistas.Formularios;

namespace Vistas
{
    public partial class frmLogin : Form
    {
        private UsuarioModel usuarioModel = new UsuarioModel();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text;

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var usuarioAutenticado = usuarioModel.Autenticar(usuario, contraseña);

                if (usuarioAutenticado != null)
                {
                    Session.UsuarioActual = usuarioAutenticado;

                    MessageBox.Show($"¡Bienvenido(a) {usuarioAutenticado.NombreUsuario}!",
                                  "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    if (usuarioAutenticado.Rol == "Administrador")
                    {
                        using (frmDashboardPrincipal frmDashboard = new frmDashboardPrincipal())
                        {
                            frmDashboard.WindowState = FormWindowState.Maximized;
                            frmDashboard.StartPosition = FormStartPosition.CenterScreen;
                            frmDashboard.ShowDialog();
                        }
                    }
                    else if (usuarioAutenticado.Rol == "Empleado")
                    {
                        using (frmDashboardEmpleado frmDashboard = new frmDashboardEmpleado())
                        {
                            frmDashboard.WindowState = FormWindowState.Maximized;
                            frmDashboard.StartPosition = FormStartPosition.CenterScreen;
                            frmDashboard.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El tipo de usuario no tiene un panel asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    this.Close(); // cierra el login definitivamente
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void lnkRecuperar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmRecuperar = new frmRecuperarContraseña();
            frmRecuperar.ShowDialog();
        }
    }
}

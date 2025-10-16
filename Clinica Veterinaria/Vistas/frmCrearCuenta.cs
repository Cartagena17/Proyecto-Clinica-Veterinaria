using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;
using Modelos;

namespace Vistas
{
    public partial class frmCrearCuenta : Form
    {
        private UsuarioModel usuarioModel = new UsuarioModel();
        private EmailService emailService = new EmailService();

        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {
            CargarEmpleadosSinCuenta();
        }

        private void LimpiarCampos()
        {
            cbEmpleadosSinCuenta.SelectedIndex = -1;
            txtEmail.Clear();
            txtContraseñaGenerada.Clear();
            txtUsuarioGenerado.Clear();
        }

        private void CargarEmpleadosSinCuenta()
        {
            List<Personal> Lista = Personal.ObtenerPersonalSinCuenta();

            cbEmpleadosSinCuenta.DataSource = Lista;
            cbEmpleadosSinCuenta.DisplayMember = "NombreCompleto1";
            cbEmpleadosSinCuenta.ValueMember = "personalId";
        }

        private void cbEmpleadosSinCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpleadosSinCuenta.SelectedItem is Personal seleccionado)
            {
                txtEmail.Text = seleccionado.EmailPers;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cbEmpleadosSinCuenta.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = (Personal)cbEmpleadosSinCuenta.SelectedItem;

            txtUsuarioGenerado.Text = usuarioModel.GenerarUsuarioUnico(empleado.NombrePers, empleado.ApellidoPers);
            txtContraseñaGenerada.Text = Utils.GenerarContraseñaSegura();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (cbEmpleadosSinCuenta.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = (Personal)cbEmpleadosSinCuenta.SelectedItem;
            string usuario = txtUsuarioGenerado.Text.Trim();
            string contraseña = txtContraseñaGenerada.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Debe generar primero el usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuarioModel.CrearUsuarioEmpleado(usuario, contraseña, empleado.PersonalID, email))
            {
                MessageBox.Show("Cuenta creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Error al crear la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            string emailDestino = txtEmail.Text;
            string usuario = txtUsuarioGenerado.Text;
            string contraseña = txtContraseñaGenerada.Text;

            if (string.IsNullOrWhiteSpace(emailDestino))
            {
                MessageBox.Show("El empleado no tiene correo registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cuerpo = $"Hola,\n\nTu cuenta para el sistema de la clínica veterinaria ha sido creada.\n\n" +
                            $"Usuario: {usuario}\nContraseña: {contraseña}\n\n" +
                            "Por favor cambia tu contraseña después de iniciar sesión.\n\n¡Bienvenido!";

            try
            {
                using (var smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("pet.saluditr@gmail.com", "rpea yigp hrfq xini");
                    smtp.EnableSsl = true;

                    var msg = new System.Net.Mail.MailMessage("pet.saluditr@gmail.com", emailDestino,
                        "Cuenta de acceso - Clínica Veterinaria", cuerpo);

                    await smtp.SendMailAsync(msg);
                    MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarEmpleadosSinCuenta();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

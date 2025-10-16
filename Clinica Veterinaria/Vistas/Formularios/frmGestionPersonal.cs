using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmGestionPersonal : Form
    {
        public frmGestionPersonal()
        {
            InitializeComponent();
        }

        private void frmGestionPersonal_Load(object sender, EventArgs e)
        {
            dgvPersonal.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvPersonal.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvPersonal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dgvPersonal.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPersonal.EnableHeadersVisualStyles = false; // para que tome el color personalizado

            dgvPersonal.DefaultCellStyle.BackColor = Color.White;
            dgvPersonal.DefaultCellStyle.ForeColor = Color.Black;
            dgvPersonal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // filas alternas más claras

            lblBusqueda.Text = "Busca el personal mediante:Nombre, Apellido, Telefono o Email";
            MostrarPersonal();
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos(out string mensajeError))
                {
                    MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Personal per = new Personal
                {
                    NombrePers = txtGestionPersonal_Nombre.Text,
                    ApellidoPers = txtGestionPersonal_Apellido.Text,
                    TelefonoPers = txtGestionPersonal_Telefono.Text,
                    EmailPers = txtGestionPersonal_Email.Text
                };

                if (per.InsertarPersonal())
                {
                    MessageBox.Show("Registro agregado con éxito.");
                    MostrarPersonal();
                    LimpiarCampos(); // 👈 limpiar después de insertar
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en btnAgregarPersonal: {ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarPersonal()
        {
            dgvPersonal.DataSource = null;
            dgvPersonal.DataSource = Personal.CargarPersonal();
        }

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonal.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(dgvPersonal.CurrentRow.Cells[0].Value.ToString());

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.No)
                {
                    return;
                }

                Personal p = new Personal();
                if (p.EliminarPersonal(id))
                {
                    MessageBox.Show("El registro se ha borrado con éxito.");
                    MostrarPersonal();
                    LimpiarCampos(); // 👈 limpiar después de eliminar
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en btnEliminarPersonal: {ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActualizarInfoPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonal.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para actualizar.");
                    return;
                }

                if (!ValidarCampos(out string mensajeError))
                {
                    MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Personal p = new Personal
                {
                    NombrePers = txtGestionPersonal_Nombre.Text,
                    ApellidoPers = txtGestionPersonal_Apellido.Text,
                    TelefonoPers = txtGestionPersonal_Telefono.Text,
                    EmailPers = txtGestionPersonal_Email.Text,
                    PersonalID = int.Parse(dgvPersonal.CurrentRow.Cells[0].Value.ToString())
                };

                if (p.ActualizarPersonal())
                {
                    MessageBox.Show("El registro se ha actualizado con éxito.");
                    MostrarPersonal();
                    LimpiarCampos(); // 👈 limpiar después de actualizar
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en btnActualizarInfoPersonal: {ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvPersonal_DoubleClick(object sender, EventArgs e)
        {

            txtGestionPersonal_Nombre.Text = dgvPersonal.CurrentRow.Cells[1].Value.ToString();
            txtGestionPersonal_Apellido.Text = dgvPersonal.CurrentRow.Cells[2].Value.ToString();
            txtGestionPersonal_Telefono.Text = dgvPersonal.CurrentRow.Cells[3].Value.ToString();
            txtGestionPersonal_Email.Text = dgvPersonal.CurrentRow.Cells[4].Value.ToString();
        }

        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = "";

            try
            {
                // Nombre
                if (string.IsNullOrWhiteSpace(txtGestionPersonal_Nombre.Text))
                {
                    mensajeError = "El nombre no puede estar vacío.";
                    return false;
                }
                if (txtGestionPersonal_Nombre.Text.Length > 50)
                {
                    mensajeError = "El nombre no puede superar los 50 caracteres.";
                    return false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtGestionPersonal_Nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                {
                    mensajeError = "El nombre solo puede contener letras y espacios.";
                    return false;
                }

                // Apellido
                if (string.IsNullOrWhiteSpace(txtGestionPersonal_Apellido.Text))
                {
                    mensajeError = "El apellido no puede estar vacío.";
                    return false;
                }
                if (txtGestionPersonal_Apellido.Text.Length > 50)
                {
                    mensajeError = "El apellido no puede superar los 50 caracteres.";
                    return false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtGestionPersonal_Apellido.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                {
                    mensajeError = "El apellido solo puede contener letras y espacios.";
                    return false;
                }

                // Teléfono
                if (string.IsNullOrWhiteSpace(txtGestionPersonal_Telefono.Text))
                {
                    mensajeError = "El teléfono no puede estar vacío.";
                    return false;
                }
                if (txtGestionPersonal_Telefono.Text.Length > 12)
                {
                    mensajeError = "El teléfono no puede superar los 12 caracteres.";
                    return false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtGestionPersonal_Telefono.Text, @"^[0-9]+$"))
                {
                    mensajeError = "El teléfono solo puede contener números.";
                    return false;
                }

                // Email
                if (string.IsNullOrWhiteSpace(txtGestionPersonal_Email.Text))
                {
                    mensajeError = "El email no puede estar vacío.";
                    return false;
                }
                if (txtGestionPersonal_Email.Text.Length > 100)
                {
                    mensajeError = "El email no puede superar los 100 caracteres.";
                    return false;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtGestionPersonal_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    mensajeError = "El email no tiene un formato válido.";
                    return false;
                }

                return true; // ✅ pasó todas las validaciones
            }
            catch (Exception ex)
            {
                mensajeError = $"Error inesperado en validación: {ex.Message}";
                return false;
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                txtGestionPersonal_Nombre.Clear();
                txtGestionPersonal_Apellido.Clear();
                txtGestionPersonal_Telefono.Clear();
                txtGestionPersonal_Email.Clear();
                dgvPersonal.ClearSelection();


                // Opcional: dejar el foco en el primer campo
                txtGestionPersonal_Nombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar los campos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valor = txtBusqueda.Text.Trim();

                Personal p = new Personal();
                DataTable dt = p.BuscarPersonal(valor);

                dgvPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en búsqueda: {ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCrearCuenta frm = new frmCrearCuenta();
            frm.ShowDialog();
        }
    }
}
    
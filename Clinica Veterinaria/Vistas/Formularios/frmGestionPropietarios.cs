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
            try
            {
                if (!ValidarCampos()) return;

                Propietarios p = new Propietarios
                {
                    NombreProp1 = txtGestionPropietario_Nombre.Text.Trim(),
                    TelefonoProp1 = txtGestionPropietario_Telefono.Text.Trim(),
                    DireccionProp1 = txtGestionPropietario_Direccion.Text.Trim(),
                    EmailProp1 = txtGestionPropietario_Email.Text.Trim()
                };

                if (p.InsertarPropietarios())
                {
                    MessageBox.Show("Propietario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostarPropietarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar propietario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGestionPropietarios_Load(object sender, EventArgs e)
        {
            dgvPropietarios.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvPropietarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvPropietarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dgvPropietarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPropietarios.EnableHeadersVisualStyles = false; // para que tome el color personalizado

            dgvPropietarios.DefaultCellStyle.BackColor = Color.White;
            dgvPropietarios.DefaultCellStyle.ForeColor = Color.Black;
            dgvPropietarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // filas alternas más claras

            MostarPropietarios();
        }
        private void MostarPropietarios()
        {
            dgvPropietarios.DataSource = null;
            dgvPropietarios.DataSource = Propietarios.CargarPropietarios();
        }

        private void btnEliminarPropietario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPropietarios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para eliminar.");
                    return;
                }

                int id = int.Parse(dgvPropietarios.CurrentRow.Cells[0].Value.ToString());

                DialogResult confirm = MessageBox.Show("¿Está seguro de eliminar este propietario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No) return;

                Propietarios p = new Propietarios();
                if (p.EliminarPropietario(id))
                {
                    MessageBox.Show("Propietario eliminado con éxito.");
                    MostarPropietarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar propietario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        

        }

        private void btnActualizarInfoPropietario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPropietarios.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para actualizar.");
                    return;
                }

                if (!ValidarCampos()) return;

                Propietarios p = new Propietarios
                {
                    NombreProp1 = txtGestionPropietario_Nombre.Text.Trim(),
                    TelefonoProp1 = txtGestionPropietario_Telefono.Text.Trim(),
                    DireccionProp1 = txtGestionPropietario_Direccion.Text.Trim(),
                    EmailProp1 = txtGestionPropietario_Email.Text.Trim(),
                    Id = int.Parse(dgvPropietarios.CurrentRow.Cells[0].Value.ToString())
                };

                if (p.ActualizarPropietario())
                {
                    MessageBox.Show("Propietario actualizado con éxito.");
                    MostarPropietarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar propietario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dgvPropietarios_DoubleClick(object sender, EventArgs e)
        {
            txtGestionPropietario_Nombre.Text = dgvPropietarios.CurrentRow.Cells[1].Value.ToString();
            txtGestionPropietario_Telefono.Text=dgvPropietarios.CurrentRow.Cells[2].Value.ToString();
            txtGestionPropietario_Direccion.Text = dgvPropietarios.CurrentRow.Cells[3].Value.ToString();
            txtGestionPropietario_Email.Text = dgvPropietarios.CurrentRow.Cells[4].Value.ToString();



        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtGestionPropietario_Nombre.Clear();
            txtGestionPropietario_Telefono.Clear();
            txtGestionPropietario_Direccion.Clear();
            txtGestionPropietario_Email.Clear();
            txtGestionPropietario_Nombre.Focus();
            dgvPropietarios.ClearSelection();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvPropietarios.DataSource = Propietarios.BuscarPropietarios(txtBuscar.Text.Trim());

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Nombre.Text) ||
                !Regex.IsMatch(txtGestionPropietario_Nombre.Text, @"^[a-zA-Z\s]+$") ||
                txtGestionPropietario_Nombre.Text.Length > 100)
            {
                MessageBox.Show("Debe ingresar un nombre válido (solo letras, máx. 100 caracteres).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Telefono.Text) ||
                !Regex.IsMatch(txtGestionPropietario_Telefono.Text, @"^[0-9]{8,20}$"))
            {
                MessageBox.Show("Debe ingresar un teléfono válido (8-20 dígitos numéricos).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Direccion.Text) ||
                txtGestionPropietario_Direccion.Text.Length > 150)
            {
                MessageBox.Show("Debe ingresar una dirección (máx. 150 caracteres).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGestionPropietario_Email.Text) ||
                !Regex.IsMatch(txtGestionPropietario_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ||
                txtGestionPropietario_Email.Text.Length > 100)
            {
                MessageBox.Show("Debe ingresar un email válido (máx. 100 caracteres).");
                return false;
            }

            return true;
        }
            
    }
}

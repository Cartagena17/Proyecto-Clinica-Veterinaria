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

namespace Vistas.Formularios
{
    public partial class frmAtencionMedica : Form
    {
        public frmAtencionMedica()
        {
            InitializeComponent();
        }

        private void frmAtencionMedica_Load(object sender, EventArgs e)
        {
            CargarCitasComboBox();
            MostarConsultasMedicas();
        }

        // Cargar citas en ComboBox con nombre paciente, propietario y fecha
        private void CargarCitasComboBox(int citaSeleccionada = 0)
        {
            try
            {
                DataTable dt;
                if (citaSeleccionada > 0)
                {
                    // Incluir la cita seleccionada más las que no tienen consulta
                    dt = Citas.CargarCitasCBConCitaSeleccionada(citaSeleccionada);
                }
                else
                {
                    // Solo citas sin consulta
                    dt = Citas.CargarCitasCB();
                }

                cmbAtencionMedica_Cita.DataSource = dt;
                cmbAtencionMedica_Cita.DisplayMember = "InfoCita";
                cmbAtencionMedica_Cita.ValueMember = "CitaID";

                if (citaSeleccionada > 0)
                    cmbAtencionMedica_Cita.SelectedValue = citaSeleccionada;
                else
                    cmbAtencionMedica_Cita.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando citas: " + ex.Message);
            }
        }


        private void cmbAtencionMedica_Cita_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbAtencionMedica_Cita.SelectedValue != null)
            {
                try
                {
                    DataRowView drv = (DataRowView)cmbAtencionMedica_Cita.SelectedItem;
                    dtpAtencionMedica_Fecha.Value = Convert.ToDateTime(drv["FechaCita"]);
                    dtpAtencionMedica_Fecha.Enabled = false; // Bloqueado
                }
                catch { }
            }
        }

        private void btnRegistrarConsultaMedica_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarConsulta()) return;

                ConsultasMedicas CM = new ConsultasMedicas();
                CM.CitaID1 = Convert.ToInt32(cmbAtencionMedica_Cita.SelectedValue);
                CM.Sintomas1 = txtAtencionMedica_Sintomas.Text;
                CM.Diagnostico = txtAtencionMedica_Diagnostico.Text;
                CM.Tratamiento = txtAtencionMedica_Tratamiento.Text;
                CM.Observaciones = txtAtencionMedica_Observaciones.Text;
                CM.PesoActual = txtAtencionMedica_Peso.Text;
                CM.Temperatura = txtAtencionMedica_Temperatura.Text;

                if (CM.InsertarConsultasMedicas())
                {
                    MessageBox.Show("Consulta médica registrada correctamente.");
                    MostarConsultasMedicas();
                    CargarCitasComboBox();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar la consulta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la consulta: " + ex.Message);
            }
        }

        private void MostarConsultasMedicas()
        {
            try
            {
                dgvConsultasMedicas.DataSource = ConsultasMedicas.CargarConsultasMedicas();

                // Ocultar columna CitaID
                if (dgvConsultasMedicas.Columns["CodigoCita"] != null)
                {
                    dgvConsultasMedicas.Columns["CodigoCita"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando consultas: " + ex.Message);
            }
        }

        private void dgvConsultasMedicas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsultasMedicas.CurrentRow != null)
            {
                int citaId = Convert.ToInt32(dgvConsultasMedicas.CurrentRow.Cells["CodigoCita"].Value);

                // Cargar el ComboBox incluyendo la cita seleccionada
                CargarCitasComboBox(citaId);
                cmbAtencionMedica_Cita.Enabled = false;

                // Bloquear fecha
                dtpAtencionMedica_Fecha.Value = Convert.ToDateTime(dgvConsultasMedicas.CurrentRow.Cells["Fecha_Consulta"].Value);
                dtpAtencionMedica_Fecha.Enabled = false;

                // Llenar los campos de texto
                txtAtencionMedica_Sintomas.Text = dgvConsultasMedicas.CurrentRow.Cells["Sintomas"].Value.ToString();
                txtAtencionMedica_Diagnostico.Text = dgvConsultasMedicas.CurrentRow.Cells["Diagnostico"].Value.ToString();
                txtAtencionMedica_Tratamiento.Text = dgvConsultasMedicas.CurrentRow.Cells["Tratamiento"].Value.ToString();
                txtAtencionMedica_Observaciones.Text = dgvConsultasMedicas.CurrentRow.Cells["Observaciones"].Value.ToString();
                txtAtencionMedica_Peso.Text = dgvConsultasMedicas.CurrentRow.Cells["Peso_Actual"].Value.ToString();
                txtAtencionMedica_Temperatura.Text = dgvConsultasMedicas.CurrentRow.Cells["Temperatura"].Value.ToString();
            }
        }



        private void btnEliminarConsultaMedica_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultasMedicas.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una consulta para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int citaId = Convert.ToInt32(dgvConsultasMedicas.CurrentRow.Cells["CodigoCita"].Value);

                var confirm = MessageBox.Show("¿Está seguro de eliminar esta consulta?", "Confirmación",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    ConsultasMedicas CM = new ConsultasMedicas();
                    CM.CitaID1 = citaId;

                    if (CM.EliminarConsultasMedicas())
                    {
                        MessageBox.Show("Consulta médica eliminada correctamente.");
                        MostarConsultasMedicas();
                        CargarCitasComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar la consulta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la consulta: " + ex.Message);
            }
        
        }

        private void btnActualizarConsultaMedica_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarConsulta()) return;

                if (dgvConsultasMedicas.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una consulta para actualizar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int citaId = Convert.ToInt32(dgvConsultasMedicas.CurrentRow.Cells["CodigoCita"].Value);

                ConsultasMedicas CM = new ConsultasMedicas();
                CM.CitaID1 = citaId;
                CM.Sintomas1 = txtAtencionMedica_Sintomas.Text;
                CM.Diagnostico = txtAtencionMedica_Diagnostico.Text;
                CM.Tratamiento = txtAtencionMedica_Tratamiento.Text;
                CM.Observaciones = txtAtencionMedica_Observaciones.Text;
                CM.PesoActual = txtAtencionMedica_Peso.Text;
                CM.Temperatura = txtAtencionMedica_Temperatura.Text;

                if (CM.ActualizarConsultasMedicas())
                {
                    MessageBox.Show("Consulta médica actualizada correctamente.");
                    MostarConsultasMedicas();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar la consulta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la consulta: " + ex.Message);
            }
        }

        private void btnLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            txtAtencionMedica_Sintomas.Clear();
            txtAtencionMedica_Diagnostico.Clear();
            txtAtencionMedica_Tratamiento.Clear();
            txtAtencionMedica_Observaciones.Clear();
            txtAtencionMedica_Peso.Clear();
            txtAtencionMedica_Temperatura.Clear();

            // Solo cargar citas sin consulta
            CargarCitasComboBox();
            cmbAtencionMedica_Cita.Enabled = true;

            dtpAtencionMedica_Fecha.Value = DateTime.Today;
            dtpAtencionMedica_Fecha.Enabled = false;
            dgvConsultasMedicas.ClearSelection();
        }

        private bool ValidarConsulta()
        {
            // Validar que haya cita seleccionada
            if (cmbAtencionMedica_Cita.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Sintomas (varchar(100))
            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Sintomas.Text) || int.TryParse(txtAtencionMedica_Sintomas.Text, out _))
            {
                MessageBox.Show("Debe ingresar síntomas válidos (no solo números).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAtencionMedica_Sintomas.Text.Length > 100)
            {
                MessageBox.Show("Los síntomas no pueden superar los 100 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Diagnóstico (varchar(60))
            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Diagnostico.Text) || int.TryParse(txtAtencionMedica_Diagnostico.Text, out _))
            {
                MessageBox.Show("Debe ingresar un diagnóstico válido (no solo números).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAtencionMedica_Diagnostico.Text.Length > 60)
            {
                MessageBox.Show("El diagnóstico no puede superar los 60 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Tratamiento (varchar(100))
            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Tratamiento.Text) || int.TryParse(txtAtencionMedica_Tratamiento.Text, out _))
            {
                MessageBox.Show("Debe ingresar un tratamiento válido (no solo números).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAtencionMedica_Tratamiento.Text.Length > 100)
            {
                MessageBox.Show("El tratamiento no puede superar los 100 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Observaciones (varchar(100))
            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Observaciones.Text) || int.TryParse(txtAtencionMedica_Observaciones.Text, out _))
            {
                MessageBox.Show("Debe ingresar observaciones válidas (no solo números).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAtencionMedica_Observaciones.Text.Length > 100)
            {
                MessageBox.Show("Las observaciones no pueden superar los 100 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // PesoActual (decimal(6,2))
            if (!decimal.TryParse(txtAtencionMedica_Peso.Text, out decimal peso) || peso <= 0)
            {
                MessageBox.Show("Debe ingresar un peso válido (número mayor que 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (peso > 9999.99m)
            {
                MessageBox.Show("El peso no puede superar 9999.99 kg.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Temperatura (decimal(4,1))
            if (!decimal.TryParse(txtAtencionMedica_Temperatura.Text, out decimal temperatura) || temperatura <= 0)
            {
                MessageBox.Show("Debe ingresar una temperatura válida (número mayor que 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (temperatura > 99.9m)
            {
                MessageBox.Show("La temperatura no puede superar 99.9 °C.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}

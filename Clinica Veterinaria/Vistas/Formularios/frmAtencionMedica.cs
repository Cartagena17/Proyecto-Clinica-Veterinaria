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
        private void CargarCitasComboBox()
        {
            try
            {
                DataTable dt = Citas.CargarCitasCB();
                cmbAtencionMedica_Cita.DataSource = dt;
                cmbAtencionMedica_Cita.DisplayMember = "InfoCita"; // Ej: "Juan / Ana / 01/10/2025"
                cmbAtencionMedica_Cita.ValueMember = "CitaId";
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
                if (cmbAtencionMedica_Cita.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtAtencionMedica_Temperatura.Text, out double temperatura))
                {
                    MessageBox.Show("Debe ingresar una temperatura válida (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtAtencionMedica_Peso.Text, out double peso))
                {
                    MessageBox.Show("Debe ingresar un peso válido (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAtencionMedica_Sintomas.Text) ||
                    string.IsNullOrWhiteSpace(txtAtencionMedica_Diagnostico.Text) ||
                    string.IsNullOrWhiteSpace(txtAtencionMedica_Tratamiento.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ConsultasMedicas CM = new ConsultasMedicas
                {
                    CitaID1 = Convert.ToInt32(cmbAtencionMedica_Cita.SelectedValue),
                    Temperatura = txtAtencionMedica_Temperatura.Text,
                    PesoActual = txtAtencionMedica_Peso.Text,
                    Sintomas1 = txtAtencionMedica_Sintomas.Text,
                    Observaciones = txtAtencionMedica_Observaciones.Text,
                    Tratamiento = txtAtencionMedica_Tratamiento.Text,
                    Diagnostico = txtAtencionMedica_Diagnostico.Text
                };

                if (CM.InsertarConsultasMedicas())
                {
                    MessageBox.Show("Consulta médica registrada correctamente.");
                    MostarConsultasMedicas();
                    btnLimpiarCampos_Click(null, null); // Limpiar para nueva
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar la consulta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                try
                {
                    txtAtencionMedica_Sintomas.Text = dgvConsultasMedicas.CurrentRow.Cells["Sintomas"].Value.ToString();
                    txtAtencionMedica_Diagnostico.Text = dgvConsultasMedicas.CurrentRow.Cells["Diagnostico"].Value.ToString();
                    txtAtencionMedica_Tratamiento.Text = dgvConsultasMedicas.CurrentRow.Cells["Tratamiento"].Value.ToString();
                    txtAtencionMedica_Observaciones.Text = dgvConsultasMedicas.CurrentRow.Cells["Observaciones"].Value.ToString();
                    txtAtencionMedica_Peso.Text = dgvConsultasMedicas.CurrentRow.Cells["Peso_Actual"].Value.ToString();
                    txtAtencionMedica_Temperatura.Text = dgvConsultasMedicas.CurrentRow.Cells["Temperatura"].Value.ToString();

                    int citaId = Convert.ToInt32(dgvConsultasMedicas.CurrentRow.Cells["CodigoCita"].Value);
                    cmbAtencionMedica_Cita.SelectedValue = citaId;
                    cmbAtencionMedica_Cita.Enabled = false; // Bloqueado

                    dtpAtencionMedica_Fecha.Value = Convert.ToDateTime(dgvConsultasMedicas.CurrentRow.Cells["Fecha_Consulta"].Value);
                    dtpAtencionMedica_Fecha.Enabled = false; // Bloqueado
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cargando la consulta: " + ex.Message);
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtAtencionMedica_Sintomas.Clear();
            txtAtencionMedica_Diagnostico.Clear();
            txtAtencionMedica_Tratamiento.Clear();
            txtAtencionMedica_Observaciones.Clear();
            txtAtencionMedica_Peso.Clear();
            txtAtencionMedica_Temperatura.Clear();

            cmbAtencionMedica_Cita.SelectedIndex = -1;
            cmbAtencionMedica_Cita.Enabled = true;

            dtpAtencionMedica_Fecha.Value = DateTime.Today;
            dtpAtencionMedica_Fecha.Enabled = false;
        }

      
    }
}

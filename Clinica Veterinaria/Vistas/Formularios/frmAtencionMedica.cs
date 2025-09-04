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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarConsultaMedica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAtencionMedica_CitaID.Text) || !int.TryParse(txtAtencionMedica_CitaID.Text, out int citaID))
            {
                MessageBox.Show("Debe ingresar un ID de cita válido (número entero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Temperatura.Text) || !double.TryParse(txtAtencionMedica_Temperatura.Text, out double temperatura))
            {
                MessageBox.Show("Debe ingresar una temperatura válida (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Peso.Text) || !double.TryParse(txtAtencionMedica_Peso.Text, out double peso))
            {
                MessageBox.Show("Debe ingresar un peso válido (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Sintomas.Text))
            {
                MessageBox.Show("Debe ingresar los síntomas del paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Diagnostico.Text))
            {
                MessageBox.Show("Debe ingresar un diagnóstico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Tratamiento.Text))
            {
                MessageBox.Show("Debe ingresar un tratamiento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ConsultasMedicas CM = new ConsultasMedicas();
            CM.CitaID1 = int.Parse(txtAtencionMedica_CitaID.Text);
            CM.Temperatura = txtAtencionMedica_Temperatura.Text;
            CM.FechaConsulta1 = dtpAtencionMedica_Fecha.Value;
            CM.PesoActual = txtAtencionMedica_Peso.Text;
            CM.Sintomas1 = txtAtencionMedica_Sintomas.Text;
            CM.Observaciones = txtAtencionMedica_Observaciones.Text;
            CM.Tratamiento = txtAtencionMedica_Tratamiento.Text;
            CM.Diagnostico = txtAtencionMedica_Diagnostico.Text;

            CM.InsertarConsultasMedicas();
            ConsultasMedicas.CargarConsultasMedicas();


        }

        private void MostarConsultasMedicas()
        {
            dgvConsultasMedicas.DataSource = null;
            dgvConsultasMedicas.DataSource = ConsultasMedicas.CargarConsultasMedicas();
        }

        private void frmAtencionMedica_Load(object sender, EventArgs e)
        {
            MostarConsultasMedicas();
        }

        private void btnEliminarConsultaMedica_Click(object sender, EventArgs e)
        {
            ConsultasMedicas CM = new ConsultasMedicas();
            CM.CitaID1 = int.Parse(dgvConsultasMedicas.CurrentRow.Cells[0].Value.ToString());

            if (CM.EliminarConsultasMedicas() == true)
            {
                MessageBox.Show("Consulta médica eliminada correctamente.");
                MostarConsultasMedicas();
            }
            else
            {
                MessageBox.Show("Ah ocurrido un ERROR");
            }
        }

        private void btnActualizarConsultaMedica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAtencionMedica_CitaID.Text) || !int.TryParse(txtAtencionMedica_CitaID.Text, out int citaID))
            {
                MessageBox.Show("Debe ingresar un ID de cita válido (número entero).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Temperatura.Text) || !double.TryParse(txtAtencionMedica_Temperatura.Text, out double temperatura))
            {
                MessageBox.Show("Debe ingresar una temperatura válida (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Peso.Text) || !double.TryParse(txtAtencionMedica_Peso.Text, out double peso))
            {
                MessageBox.Show("Debe ingresar un peso válido (número).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Sintomas.Text))
            {
                MessageBox.Show("Debe ingresar los síntomas del paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Diagnostico.Text))
            {
                MessageBox.Show("Debe ingresar un diagnóstico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAtencionMedica_Tratamiento.Text))
            {
                MessageBox.Show("Debe ingresar un tratamiento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConsultasMedicas CM = new ConsultasMedicas();
            CM.CitaID1 = int.Parse(dgvConsultasMedicas.CurrentRow.Cells[0].Value.ToString());
            CM.Temperatura = txtAtencionMedica_Temperatura.Text;
            CM.FechaConsulta1 = dtpAtencionMedica_Fecha.Value;
            CM.PesoActual = txtAtencionMedica_Peso.Text;
            CM.Sintomas1 = txtAtencionMedica_Sintomas.Text;
            CM.Observaciones = txtAtencionMedica_Observaciones.Text;
            CM.Tratamiento = txtAtencionMedica_Tratamiento.Text;
            CM.Diagnostico = txtAtencionMedica_Diagnostico.Text;

            if (CM.ActualizarConsultasMedicas() == true)
            {
                MessageBox.Show("Consulta médica actualizada correctamente.");
                MostarConsultasMedicas();
            }
            else
            {
                MessageBox.Show("Ah ocurrido un ERROR");
            }
        }

        private void dgvConsultasMedicas_DoubleClick(object sender, EventArgs e)
        {

            txtAtencionMedica_CitaID.Text = dgvConsultasMedicas.CurrentRow.Cells[1].Value.ToString();
            dtpAtencionMedica_Fecha.Value = Convert.ToDateTime(dgvConsultasMedicas.CurrentRow.Cells[5].Value);
            txtAtencionMedica_Sintomas.Text = dgvConsultasMedicas.CurrentRow.Cells[6].Value.ToString();
            txtAtencionMedica_Diagnostico.Text = dgvConsultasMedicas.CurrentRow.Cells[7].Value.ToString();
            txtAtencionMedica_Tratamiento.Text = dgvConsultasMedicas.CurrentRow.Cells[8].Value.ToString();
            txtAtencionMedica_Observaciones.Text = dgvConsultasMedicas.CurrentRow.Cells[9].Value.ToString();
            txtAtencionMedica_Peso.Text = dgvConsultasMedicas.CurrentRow.Cells[10].Value.ToString();
            txtAtencionMedica_Temperatura.Text = dgvConsultasMedicas.CurrentRow.Cells[11].Value.ToString();

        }
    }
}

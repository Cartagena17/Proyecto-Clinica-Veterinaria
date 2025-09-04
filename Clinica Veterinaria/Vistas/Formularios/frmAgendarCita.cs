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
using Modelos.Conexion;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmAgendarCita : Form
    {
        public frmAgendarCita()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgendarCita_Load(object sender, EventArgs e)
        {
            MostrarCitas();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtAgendarCita_Veterinario.Text))
            {
                MessageBox.Show("Debe ingresar el ID del veterinario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Propietario.Text))
            {
                MessageBox.Show("Debe ingresar el ID del propietario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Paciente.Text))
            {
                MessageBox.Show("Debe ingresar el ID del paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Hora.Text))
            {
                MessageBox.Show("Debe ingresar la hora de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Motivo.Text))
            {
                MessageBox.Show("Debe ingresar el motivo de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(txtAgendarCita_Veterinario.Text, out int veterinarioID))
            {
                MessageBox.Show("El ID del veterinario debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAgendarCita_Propietario.Text, out int propietarioID))
            {
                MessageBox.Show("El ID del propietario debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAgendarCita_Paciente.Text, out int pacienteID))
            {
                MessageBox.Show("El ID del paciente debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (dtpAgendarCita_Fecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de la cita no puede ser anterior al día de hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Citas c = new Citas();
            c.PersonalID = int.Parse(txtAgendarCita_Veterinario.Text);
            c.PropietarioID = int.Parse(txtAgendarCita_Propietario.Text);
            c.PacientID = int.Parse(txtAgendarCita_Paciente.Text);
            c.PersonalID = int.Parse(txtAgendarCita_Veterinario.Text);
            c.HoraCita = txtAgendarCita_Hora.Text;
            c.FechaCita = dtpAgendarCita_Fecha.Value;
            c.MotivoCita = txtAgendarCita_Motivo.Text;
            c.NotasCita = txtAgendarCitas_Notas.Text;

            c.InsertarCita();
            Citas.CargarCitas();
            //MostrarCitas();


        }

        private void MostrarCitas()
        {
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = Citas.CargarCitas();
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarCita_Click(object sender, EventArgs e)
        {
        }



        private void dgvCitas_DoubleClick(object sender, EventArgs e)
        {
            txtAgendarCita_Propietario.Text = dgvCitas.CurrentRow.Cells[1].Value.ToString();
            txtAgendarCita_Paciente.Text = dgvCitas.CurrentRow.Cells[2].Value.ToString();
            txtAgendarCita_Veterinario.Text = dgvCitas.CurrentRow.Cells[3].Value.ToString();
            dtpAgendarCita_Fecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells[4].Value.ToString());
            txtAgendarCita_Hora.Text = dgvCitas.CurrentRow.Cells[5].Value.ToString();
            txtAgendarCita_Motivo.Text = dgvCitas.CurrentRow.Cells[6].Value.ToString();
            txtAgendarCitas_Notas.Text = dgvCitas.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnEliminarCIta_Click_1(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }
            Citas c = new Citas();
            c.CitaID = int.Parse(dgvCitas.CurrentRow.Cells[0].Value.ToString());
            if (c.EliminarCita() == true)
            {
                MessageBox.Show("La cita se ha eliminado con éxito ");
                MostrarCitas();
            }
            else
            {
                MessageBox.Show("Se ha producido un ERROR ");
            }
        }

        private void btnActualizarCita_Click_1(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para actualizar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAgendarCita_Veterinario.Text))
            {
                MessageBox.Show("Debe ingresar el ID del veterinario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Propietario.Text))
            {
                MessageBox.Show("Debe ingresar el ID del propietario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Paciente.Text))
            {
                MessageBox.Show("Debe ingresar el ID del paciente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Hora.Text))
            {
                MessageBox.Show("Debe ingresar la hora de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAgendarCita_Motivo.Text))
            {
                MessageBox.Show("Debe ingresar el motivo de la cita.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(txtAgendarCita_Veterinario.Text, out int veterinarioID))
            {
                MessageBox.Show("El ID del veterinario debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAgendarCita_Propietario.Text, out int propietarioID))
            {
                MessageBox.Show("El ID del propietario debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAgendarCita_Paciente.Text, out int pacienteID))
            {
                MessageBox.Show("El ID del paciente debe ser un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dtpAgendarCita_Fecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de la cita no puede ser anterior al día de hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Citas c = new Citas();
            c.CitaID = int.Parse(dgvCitas.CurrentRow.Cells[0].Value.ToString());
            c.PropietarioID = int.Parse(txtAgendarCita_Propietario.Text);
            c.PacientID = int.Parse(txtAgendarCita_Paciente.Text);
            c.PersonalID = int.Parse(txtAgendarCita_Veterinario.Text);
            c.FechaCita = dtpAgendarCita_Fecha.Value;
            c.HoraCita = txtAgendarCita_Hora.Text;
            c.MotivoCita = txtAgendarCita_Motivo.Text;
            c.NotasCita = txtAgendarCitas_Notas.Text;

            if (c.ActualizarCita() == true)
            {
                MessageBox.Show("La cita se ha actualizado con éxito ");
                MostrarCitas();
            }
            else
            {
                MessageBox.Show("Se ha producido un ERROR ");
            }
        }

        private void txtAgendarCita_Hora_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerCita_Click(object sender, EventArgs e)
        {

                DateTime? fechaCita = dtpAgendarCita_Fecha.Checked ? dtpAgendarCita_Fecha.Value : (DateTime?)null;
                string horaCita = string.IsNullOrWhiteSpace(txtAgendarCita_Hora.Text) ? null : txtAgendarCita_Hora.Text.Trim();
                string motivo = string.IsNullOrWhiteSpace(txtAgendarCita_Motivo.Text) ? null : txtAgendarCita_Motivo.Text.Trim();
                string notas = string.IsNullOrWhiteSpace(txtAgendarCitas_Notas.Text) ? null : txtAgendarCitas_Notas.Text.Trim();

                using (SqlConnection conexion = Conexiondb.conectar())
                {
                    string query = @"SELECT * FROM Citas
                 WHERE (@fechaCita IS NULL OR FechaCita = @fechaCita)
                 AND (@horaCita IS NULL OR HoraCita LIKE '%' + @horaCita + '%')
                 AND (@motivo IS NULL OR MotivoCita LIKE '%' + @motivo + '%')
                 AND (@notas IS NULL OR NotasCita LIKE '%' + @notas + '%')";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // Agregar parámetros con manejo de valores nulos
                    cmd.Parameters.AddWithValue("@fechaCita", (object)fechaCita ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@horaCita", (object)horaCita ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@motivo", (object)motivo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@notas", (object)notas ?? DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();

                    adapter.Fill(tabla);

                    dgvCitas.DataSource = tabla;
                }
        }

        private void txtAgendarCita_Propietario_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
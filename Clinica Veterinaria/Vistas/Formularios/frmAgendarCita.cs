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

        private void frmAgendarCita_Load(object sender, EventArgs e)
        {
            dgvCitas.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvCitas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvCitas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dgvCitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvCitas.EnableHeadersVisualStyles = false; // para que tome el color personalizado

            dgvCitas.DefaultCellStyle.BackColor = Color.White;
            dgvCitas.DefaultCellStyle.ForeColor = Color.Black;
            dgvCitas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // filas alternas más claras

            label1.Text = "Busca las Citas:";
            MostrarCitas();
            CargarPersonalEnComboBox();
            CargarPropietariosEnComboBox();
        }

        #region Carga de ComboBox

        private void CargarPersonalEnComboBox()
        {
            try
            {
                cmbVeterinario.Items.Clear();
                List<Personal> personal = Personal.CargarPersonalCB();

                if (personal.Count == 0)
                {
                    MessageBox.Show("No se encontró personal registrado.", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (Personal p in personal)
                    cmbVeterinario.Items.Add(p);

                cmbVeterinario.DisplayMember = "NombreCompleto";
                cmbVeterinario.ValueMember = "PersonalID";
                cmbVeterinario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar veterinarios: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPropietariosEnComboBox()
        {
            try
            {
                cmbPropietario.Items.Clear();
                List<Propietarios> propietarios = Propietarios.CargarPropietariosCB();

                foreach (Propietarios prop in propietarios)
                    cmbPropietario.Items.Add(prop);

                cmbPropietario.DisplayMember = "NombreProp";
                cmbPropietario.ValueMember = "PropietarioID";
                cmbPropietario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar propietarios: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPacientesPorPropietario(int propietarioID)
        {
            try
            {
                cmbPaciente.Items.Clear();
                cmbPaciente.Enabled = false;

                List<Pacientes> pacientes = Pacientes.CargarPacientesPorPropietario(propietarioID);

                if (pacientes.Count == 0)
                {
                    MessageBox.Show("El propietario seleccionado no tiene pacientes registrados.", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (Pacientes pac in pacientes)
                    cmbPaciente.Items.Add(pac);

                cmbPaciente.DisplayMember = "NombreCompleto";
                cmbPaciente.ValueMember = "PacienteID";
                cmbPaciente.SelectedIndex = -1;
                cmbPaciente.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPaciente.Enabled = false;
            }
        }

        private void cmbPropietario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbPropietario.SelectedItem != null)
            {
                Propietarios propietarioSeleccionado = (Propietarios)cmbPropietario.SelectedItem;
                CargarPacientesPorPropietario(propietarioSeleccionado.Id);
            }
            else
            {
                cmbPaciente.Items.Clear();
                cmbPaciente.Enabled = false;
            }
        }

        #endregion

        #region Métodos de selección en ComboBox

        private void SeleccionarPropietarioEnComboBox(string nombrePropietario)
        {
            foreach (Propietarios prop in cmbPropietario.Items)
            {
                if (prop.NombreProp1 == nombrePropietario)
                {
                    cmbPropietario.SelectedItem = prop;
                    break;
                }
            }
        }

        private void SeleccionarPacienteEnComboBox(string nombrePaciente)
        {
            if (cmbPaciente.Enabled && cmbPaciente.Items.Count > 0)
            {
                foreach (Pacientes pac in cmbPaciente.Items)
                {
                    if (pac.NombrePac == nombrePaciente)
                    {
                        cmbPaciente.SelectedItem = pac;
                        break;
                    }
                }
            }
        }

        private void SeleccionarVeterinarioEnComboBox(string nombrePersonal)
        {
            foreach (Personal p in cmbVeterinario.Items)
            {
                if (p.NombrePers == nombrePersonal)
                {
                    cmbVeterinario.SelectedItem = p;
                    break;
                }
            }
        }

        #endregion

        #region Bloqueo / Desbloqueo de ComboBox

        private void BloquearComboBox()
        {
            cmbVeterinario.Enabled = false;
            cmbPropietario.Enabled = false;
            cmbPaciente.Enabled = false;

            cmbVeterinario.BackColor = Color.LightGray;
            cmbPropietario.BackColor = Color.LightGray;
            cmbPaciente.BackColor = Color.LightGray;
        }

        private void DesbloquearComboBox()
        {
            cmbVeterinario.Enabled = true;
            cmbPropietario.Enabled = true;
            cmbPaciente.Enabled = cmbPropietario.SelectedItem != null;

            cmbVeterinario.BackColor = SystemColors.Window;
            cmbPropietario.BackColor = SystemColors.Window;
            cmbPaciente.BackColor = SystemColors.Window;
        }

        #endregion

        #region Limpiar campos

        private void LimpiarCampos()
        {
            cmbVeterinario.SelectedIndex = -1;
            cmbPropietario.SelectedIndex = -1;
            cmbPaciente.Items.Clear();
            cmbPaciente.Enabled = false;

            txtAgendarCita_Hora.Clear();
            txtAgendarCita_Motivo.Clear();
            txtAgendarCitas_Notas.Clear();
            dtpAgendarCita_Fecha.Value = DateTime.Now;

            txtBusquedaCitas.Clear();
            dgvCitas.ClearSelection();


            DesbloquearComboBox();
        }

        #endregion

        #region Validaciones

        private bool ValidarCita(out string mensajeError)
        {
            mensajeError = "";

            // Validar selección de combobox
            if (cmbVeterinario.SelectedItem == null)
            {
                mensajeError = "Debe seleccionar un veterinario.";
                return false;
            }

            if (cmbPropietario.SelectedItem == null)
            {
                mensajeError = "Debe seleccionar un propietario.";
                return false;
            }

            if (cmbPaciente.SelectedItem == null)
            {
                mensajeError = "Debe seleccionar un paciente.";
                return false;
            }

            // Validar HoraCita
            if (string.IsNullOrWhiteSpace(txtAgendarCita_Hora.Text))
            {
                mensajeError = "Debe ingresar la hora de la cita.";
                return false;
            }
            if (txtAgendarCita_Hora.Text.Length > 20)
            {
                mensajeError = "La hora de la cita no puede superar los 20 caracteres.";
                return false;
            }

            // Validar MotivoCita
            if (string.IsNullOrWhiteSpace(txtAgendarCita_Motivo.Text))
            {
                mensajeError = "Debe ingresar el motivo de la cita.";
                return false;
            }
            if (txtAgendarCita_Motivo.Text.Length > 100)
            {
                mensajeError = "El motivo de la cita no puede superar los 100 caracteres.";
                return false;
            }
            if (int.TryParse(txtAgendarCita_Motivo.Text, out _))
            {
                mensajeError = "El motivo de la cita no puede ser solo números.";
                return false;
            }

            // Validar NotasCita (opcional)
            if (!string.IsNullOrWhiteSpace(txtAgendarCitas_Notas.Text) && txtAgendarCitas_Notas.Text.Length > 100)
            {
                mensajeError = "Las notas de la cita no pueden superar los 100 caracteres.";
                return false;
            }
            if (int.TryParse(txtAgendarCitas_Notas.Text, out _))
            {
                mensajeError = "Las notas de la cita no pueden ser solo números.";
                return false;
            }

            // Validar fecha
            if (dtpAgendarCita_Fecha.Value.Date < DateTime.Today)
            {
                mensajeError = "La fecha de la cita no puede ser anterior al día de hoy.";
                return false;
            }

            // Validar IDs de los objetos seleccionados
            Personal veterinarioSeleccionado = (Personal)cmbVeterinario.SelectedItem;
            Propietarios propietarioSeleccionado = (Propietarios)cmbPropietario.SelectedItem;
            Pacientes pacienteSeleccionado = (Pacientes)cmbPaciente.SelectedItem;

            if (veterinarioSeleccionado.PersonalID <= 0)
            {
                mensajeError = "El veterinario seleccionado no es válido.";
                return false;
            }

            if (propietarioSeleccionado.Id <= 0)
            {
                mensajeError = "El propietario seleccionado no es válido.";
                return false;
            }

            if (pacienteSeleccionado.PacienteID <= 0)
            {
                mensajeError = "El paciente seleccionado no es válido.";
                return false;
            }

            return true;
        }

        #endregion

        #region Mostrar citas

        private void MostrarCitas()
        {
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = Citas.CargarCitas();
        }

        #endregion

        #region Eventos de botones

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            if (!ValidarCita(out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Personal veterinarioSeleccionado = (Personal)cmbVeterinario.SelectedItem;
            Propietarios propietarioSeleccionado = (Propietarios)cmbPropietario.SelectedItem;
            Pacientes pacienteSeleccionado = (Pacientes)cmbPaciente.SelectedItem;

            Citas c = new Citas();
            c.PropietarioID = propietarioSeleccionado.Id;
            c.PacienteID = pacienteSeleccionado.PacienteID;
            c.PersonalID = veterinarioSeleccionado.PersonalID;
            c.FechaCita = dtpAgendarCita_Fecha.Value;
            c.HoraCita = txtAgendarCita_Hora.Text;
            c.MotivoCita = txtAgendarCita_Motivo.Text;
            c.NotasCita = txtAgendarCitas_Notas.Text;

            if (c.InsertarCita())
            {
                MessageBox.Show("Cita agendada con éxito.");
                MostrarCitas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agendar la cita.");
            }
        }

        private void btnActualizarCita_Click_1(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para actualizar.");
                return;
            }

            if (!ValidarCita(out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int citaID = Convert.ToInt32(dgvCitas.CurrentRow.Cells[0].Value);

            Personal veterinarioSeleccionado = (Personal)cmbVeterinario.SelectedItem;
            Propietarios propietarioSeleccionado = (Propietarios)cmbPropietario.SelectedItem;
            Pacientes pacienteSeleccionado = (Pacientes)cmbPaciente.SelectedItem;

            Citas c = new Citas();
            c.CitaID = citaID;
            c.PersonalID = veterinarioSeleccionado.PersonalID;
            c.PropietarioID = propietarioSeleccionado.Id;
            c.PacienteID = pacienteSeleccionado.PacienteID;
            c.FechaCita = dtpAgendarCita_Fecha.Value;
            c.HoraCita = txtAgendarCita_Hora.Text;
            c.MotivoCita = txtAgendarCita_Motivo.Text;
            c.NotasCita = txtAgendarCitas_Notas.Text;

            if (c.ActualizarCita())
            {
                MessageBox.Show("Cita actualizada con éxito.");
                MostrarCitas();
            }
            else
            {
                MessageBox.Show("Error al actualizar la cita.");
            }
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

            if (c.EliminarCita())
            {
                MessageBox.Show("La cita se ha eliminado con éxito.");
                MostrarCitas();
            }
            else
            {
                MessageBox.Show("Se ha producido un ERROR.");
            }
        }

        private void btnLimpiarCamposCitas_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region Selección de fila para ver/editar

        private void dgvCitas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null) return;

            string nombrePropietario = dgvCitas.CurrentRow.Cells[1].Value?.ToString() ?? "";
            string nombrePaciente = dgvCitas.CurrentRow.Cells[2].Value?.ToString() ?? "";
            string nombreVeterinario = dgvCitas.CurrentRow.Cells[3].Value?.ToString() ?? "";

            // 1️⃣ Seleccionar propietario
            if (!string.IsNullOrEmpty(nombrePropietario))
            {
                SeleccionarPropietarioEnComboBox(nombrePropietario);

                // 2️⃣ Cargar pacientes del propietario seleccionado
                Propietarios propSeleccionado = (Propietarios)cmbPropietario.SelectedItem;
                CargarPacientesPorPropietario(propSeleccionado.Id);

                // 3️⃣ Seleccionar paciente
                if (!string.IsNullOrEmpty(nombrePaciente))
                {
                    foreach (Pacientes pac in cmbPaciente.Items)
                    {
                        if (pac.NombrePac == nombrePaciente)
                        {
                            cmbPaciente.SelectedItem = pac;
                            break;
                        }
                    }
                }
            }

            // Seleccionar veterinario
            if (!string.IsNullOrEmpty(nombreVeterinario))
                SeleccionarVeterinarioEnComboBox(nombreVeterinario);

            // Rellenar fecha, hora, motivo y notas
            dtpAgendarCita_Fecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells[4].Value);
            txtAgendarCita_Hora.Text = dgvCitas.CurrentRow.Cells[5].Value.ToString();
            txtAgendarCita_Motivo.Text = dgvCitas.CurrentRow.Cells[6].Value.ToString();
            txtAgendarCitas_Notas.Text = dgvCitas.CurrentRow.Cells[7].Value.ToString();

            // Bloquear ComboBox
            BloquearComboBox();
        }


        #endregion

        private void txtBusquedaCitas_TextChanged(object sender, EventArgs e)
        {
            BuscarCitas();
        }
        #region Búsqueda de Citas

        private void BuscarCitas()
        {
            try
            {
                string textoBusqueda = txtBusquedaCitas.Text.Trim();

                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    DataTable resultados = Citas.BuscarCita(textoBusqueda);
                    dgvCitas.DataSource = resultados;

                    if (resultados.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron citas con los criterios de búsqueda.",
                                      "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Si está vacío, mostrar todas las citas
                    MostrarCitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar citas: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            #endregion

        }
}
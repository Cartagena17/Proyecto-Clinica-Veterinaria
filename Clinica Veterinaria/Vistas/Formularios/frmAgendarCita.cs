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
            CargarPersonalEnComboBox();
            CargarPropietariosEnComboBox();
        }

        private void CargarPersonalEnComboBox()
        {
            try
            {
                cmbVeterinario.Items.Clear();

                // Obtener la lista de personal
                List<Personal> personal = Personal.CargarPersonalCB();
                // Verificar si hay personal cargado
                if (personal.Count == 0)
                {
                    MessageBox.Show("No se encontró personal registrado.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Agregar cada personal al ComboBox
                foreach (Personal p in personal)
                {
                    cmbVeterinario.Items.Add(p);
                }

                // Configurar qué propiedad mostrar
                cmbVeterinario.DisplayMember = "NombreCompleto";
                cmbVeterinario.ValueMember = "PersonalID";

                // Sin selección por defecto
                cmbVeterinario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Aquí SÍ podemos usar MessageBox porque estamos en el formulario
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
                {
                    cmbPropietario.Items.Add(prop);
                }

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
                cmbPaciente.Enabled = false; // Deshabilitar hasta que se carguen los datos

                List<Pacientes> pacientes = Pacientes.CargarPacientesPorPropietario(propietarioID);

                if (pacientes.Count == 0)
                {
                    MessageBox.Show("El propietario seleccionado no tiene pacientes registrados.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPaciente.Enabled = false;
                    return;
                }

                foreach (Pacientes pac in pacientes)
                {
                    cmbPaciente.Items.Add(pac);
                }

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

        // Evento cuando se selecciona un propietario
        private void cmbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {

            if (cmbVeterinario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un veterinario.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPropietario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un propietario.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPaciente.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un paciente.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


            if (dtpAgendarCita_Fecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de la cita no puede ser anterior al día de hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Personal veterinarioSeleccionado = (Personal)cmbVeterinario.SelectedItem;
            Propietarios propietarioSeleccionado = (Propietarios)cmbPropietario.SelectedItem;
            Pacientes pacienteSeleccionado = (Pacientes)cmbPaciente.SelectedItem;

            Citas c = new Citas();
            c.CitaID = int.Parse(dgvCitas.CurrentRow.Cells[0].Value.ToString());
            c.PropietarioID = propietarioSeleccionado.Id;
            c.PacienteID = pacienteSeleccionado.PacienteID;
            c.PersonalID = veterinarioSeleccionado.PersonalID;
            c.FechaCita = dtpAgendarCita_Fecha.Value;
            c.HoraCita = txtAgendarCita_Hora.Text;
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
            string nombrePropietario = dgvCitas.CurrentRow.Cells[1].Value?.ToString() ?? "";
            string nombrePaciente = dgvCitas.CurrentRow.Cells[2].Value?.ToString() ?? "";
            string nombreVeterinario = dgvCitas.CurrentRow.Cells[3].Value?.ToString() ?? "";

            if (!string.IsNullOrEmpty(nombrePropietario))
            {
                SeleccionarPropietarioEnComboBox(nombrePropietario);
            }

            // Cargar paciente por NOMBRE
            if (!string.IsNullOrEmpty(nombrePaciente))
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 100;
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    SeleccionarPacienteEnComboBox(nombrePaciente);
                };
                timer.Start();
            }

            // Cargar veterinario por NOMBRE
            if (!string.IsNullOrEmpty(nombreVeterinario))
            {
                SeleccionarVeterinarioEnComboBox(nombreVeterinario);
            }   

            dtpAgendarCita_Fecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells[4].Value.ToString());
            txtAgendarCita_Hora.Text = dgvCitas.CurrentRow.Cells[5].Value.ToString();
            txtAgendarCita_Motivo.Text = dgvCitas.CurrentRow.Cells[6].Value.ToString();
            txtAgendarCitas_Notas.Text = dgvCitas.CurrentRow.Cells[7].Value.ToString();
            //DeshabilitarComboBox();

        }


        //private void DeshabilitarComboBox()
        //{
        //    cmbVeterinario.Enabled = true;
        //    cmbPropietario.Enabled = false;
        //    cmbPaciente.Enabled = false;

        //    // Opcional: Cambiar el color de fondo para indicar que son de solo lectura
        //    cmbVeterinario.BackColor = SystemColors.Window;
        //    cmbPropietario.BackColor = Color.LightGray;
        //    cmbPaciente.BackColor = Color.LightGray;
        //}
        //private void HabilitarComboBox()
        //{
        //    cmbVeterinario.Enabled = true;
        //    cmbPropietario.Enabled = true;

        //    // Restaurar color original
        //    cmbVeterinario.BackColor = SystemColors.Window;
        //    cmbPropietario.BackColor = SystemColors.Window;
        //    // cmbPaciente se habilita automáticamente cuando se selecciona un propietario
        //}

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
                    // Solo comparar el nombre (sin la especie)
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

            //HabilitarComboBox();

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
            if (cmbVeterinario.SelectedItem == null || cmbPropietario.SelectedItem == null || cmbPaciente.SelectedItem == null)
            {
                MessageBox.Show("Debe tener seleccionados veterinario, propietario y paciente.", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (dtpAgendarCita_Fecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de la cita no puede ser anterior al día de hoy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnLimpiarCamposCitas_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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

        
    }
}
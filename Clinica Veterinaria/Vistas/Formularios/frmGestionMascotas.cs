using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmGestionMascotas : Form
    {
        private int propietarioIDActual = 0; // Variable para almacenar el propietario actual al seleccionar

        public frmGestionMascotas()
        {
            InitializeComponent();
        }

        private void frmGestionMascotas_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
            CargarPropietariosEnComboBox();
            rbMacho.Checked = true; // Valor por defecto
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                // Obtener propietario seleccionado
                if (cmbPropietario.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un propietario.", "Validación", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Propietarios propietarioSeleccionado = (Propietarios)cmbPropietario.SelectedItem;

                Pacientes pac = new Pacientes();
                pac.NombrePac = txtGestionMascota_Nombre.Text.Trim();
                pac.RazaPac = txtGestionMascota_Raza.Text.Trim();
                pac.ColorPac = txtGestionMascota_Color.Text.Trim();
                pac.NacimientoPac = dtpGestionMascota_Nacimiento.Value;
                pac.PesoPac = txtGestionMascota_Peso.Text.Trim();
                pac.EspeciePac = txtGestionMascota_Especie.Text.Trim();
                pac.SexoPac = rbMacho.Checked ? "Macho" : "Hembra";
                pac.PropietarioID = propietarioSeleccionado.Id;

                bool resultado = pac.InsertarPacientes();
                
                if (resultado)
                {
                    MessageBox.Show("Mascota registrada correctamente.", "Éxito", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    MostrarPacientes();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la mascota.", "Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar mascota: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Nombre.Text) ||
                !Regex.IsMatch(txtGestionMascota_Nombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un nombre válido para la mascota (solo letras).", 
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Nombre.Focus();
                return false;
            }

            // Validar especie
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Especie.Text) ||
                !Regex.IsMatch(txtGestionMascota_Especie.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar una especie válida (solo letras).", 
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Especie.Focus();
                return false;
            }

            // Validar raza
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Raza.Text) ||
                !Regex.IsMatch(txtGestionMascota_Raza.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar una raza válida (solo letras).", 
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Raza.Focus();
                return false;
            }

            // Validar color
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Color.Text) ||
                !Regex.IsMatch(txtGestionMascota_Color.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un color válido (solo letras).", 
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Color.Focus();
                return false;
            }

            // Validar peso
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Peso.Text) ||
                !double.TryParse(txtGestionMascota_Peso.Text, out double peso) || peso <= 0)
            {
                MessageBox.Show("Debe ingresar un peso válido (número mayor que 0).", 
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Peso.Focus();
                return false;
            }

            // Validar fecha
            if (dtpGestionMascota_Nacimiento.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", 
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpGestionMascota_Nacimiento.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtGestionMascota_Nombre.Clear();
            txtGestionMascota_Especie.Clear();
            txtGestionMascota_Raza.Clear();
            txtGestionMascota_Color.Clear();
            txtGestionMascota_Peso.Clear();
            dtpGestionMascota_Nacimiento.Value = DateTime.Today;
            rbMacho.Checked = true;
            cmbPropietario.SelectedIndex = -1;
            cmbPropietario.Enabled = true; // Habilitar para nuevos registros
            propietarioIDActual = 0;
        }

        private void MostrarPacientes()
        {
            try
            {
                dgvMascotas.DataSource = null;
                dgvMascotas.DataSource = Pacientes.CargarPacientes();
                
                // Opcional: Configurar el ancho de las columnas
                if (dgvMascotas.Columns.Count > 0)
                {
                    dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error", 
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

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMascotas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para eliminar.", 
                                  "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = int.Parse(dgvMascotas.CurrentRow.Cells[0].Value.ToString());
                
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta mascota?", 
                                                       "Confirmar Eliminación", 
                                                       MessageBoxButtons.YesNo, 
                                                       MessageBoxIcon.Question);
                
                if (resultado == DialogResult.Yes)
                {
                    Pacientes p = new Pacientes();
                    if (p.EliminarPaciente(id))
                    {
                        MessageBox.Show("El registro se ha borrado con éxito", "Éxito", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarPacientes();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Error", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar mascota: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarInfoMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMascotas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para actualizar.", 
                                  "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarCampos())
                    return;

                // Validar que tenemos un propietarioID almacenado
                if (propietarioIDActual == 0)
                {
                    MessageBox.Show("No se puede actualizar. Propietario no identificado.", "Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Pacientes pac = new Pacientes();
                pac.PacienteID = int.Parse(dgvMascotas.CurrentRow.Cells[0].Value.ToString());
                pac.NombrePac = txtGestionMascota_Nombre.Text.Trim();
                pac.EspeciePac = txtGestionMascota_Especie.Text.Trim();
                pac.RazaPac = txtGestionMascota_Raza.Text.Trim();
                pac.NacimientoPac = dtpGestionMascota_Nacimiento.Value;
                pac.PesoPac = txtGestionMascota_Peso.Text.Trim();
                pac.SexoPac = rbMacho.Checked ? "Macho" : "Hembra";
                pac.ColorPac = txtGestionMascota_Color.Text.Trim();
                pac.PropietarioID = propietarioIDActual; // Usar el propietario original

                bool resultado = pac.ActualizarPaciente();
                
                if (resultado)
                {
                    MessageBox.Show("El registro se ha actualizado con éxito", "Éxito", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPacientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro", "Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar mascota: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMascotas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvMascotas.CurrentRow == null) return;

                // Cargar datos en los campos
                txtGestionMascota_Nombre.Text = dgvMascotas.CurrentRow.Cells[1].Value.ToString();
                txtGestionMascota_Especie.Text = dgvMascotas.CurrentRow.Cells[2].Value.ToString();
                txtGestionMascota_Raza.Text = dgvMascotas.CurrentRow.Cells[3].Value.ToString();
                dtpGestionMascota_Nacimiento.Value = Convert.ToDateTime(dgvMascotas.CurrentRow.Cells[4].Value);
                txtGestionMascota_Peso.Text = dgvMascotas.CurrentRow.Cells[5].Value.ToString();
                
                // Manejar el sexo con los RadioButtons
                string sexo = dgvMascotas.CurrentRow.Cells[6].Value.ToString();
                if (sexo.ToLower() == "macho")
                {
                    rbMacho.Checked = true;
                }
                else
                {
                    rbHembra.Checked = true;
                }
                
                txtGestionMascota_Color.Text = dgvMascotas.CurrentRow.Cells[7].Value.ToString();

                // Cargar y bloquear el propietario
                if (dgvMascotas.CurrentRow.Cells.Count > 8 && dgvMascotas.CurrentRow.Cells[8].Value != null)
                {
                    propietarioIDActual = Convert.ToInt32(dgvMascotas.CurrentRow.Cells[8].Value);
                    
                    // Buscar y mostrar el propietario en el ComboBox
                    foreach (Propietarios prop in cmbPropietario.Items)
                    {
                        if (prop.Id == propietarioIDActual)
                        {
                            cmbPropietario.SelectedItem = prop;
                            break;
                        }
                    }

                    // Deshabilitar el ComboBox para evitar cambios
                    cmbPropietario.Enabled = false;
                    
                    // Mostrar información al usuario
                    lblInfoPropietario.Visible = true;
                    lblInfoPropietario.Text = "Propietario: No se puede modificar en actualizaciones";
                    lblInfoPropietario.ForeColor = Color.Blue;
                }
                else
                {
                    propietarioIDActual = 0;
                    cmbPropietario.Enabled = true;
                    lblInfoPropietario.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            // Método para preparar el formulario para un nuevo registro
            LimpiarCampos();
            cmbPropietario.Enabled = true;
            lblInfoPropietario.Visible = false;
        }

        // Eventos para los labels (puedes eliminar si no son necesarios)
        private void label2_Click(object sender, EventArgs e) { }
    }
}
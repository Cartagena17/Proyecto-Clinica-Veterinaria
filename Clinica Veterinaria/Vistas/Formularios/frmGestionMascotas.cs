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
        
        private int propietarioIDActual = 0;
        private int pacienteIDSeleccionado = 0;
        private bool cargandoDatos = false;


        public frmGestionMascotas()
        {
            InitializeComponent();
        }

        private void frmGestionMascotas_Load(object sender, EventArgs e)
        {
            lblBusqueda1.Text = "Busca las mascotas por\r\nNombre, Especie, Raza o Propietario:";
            MostrarPacientes();
            CargarPropietariosEnComboBox();
            rbMacho.Checked = true;
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvMascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMascotas.MultiSelect = false;
            dgvMascotas.ReadOnly = true;
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

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

                // Validación específica para decimal (6,1)
                if (!decimal.TryParse(txtGestionMascota_Peso.Text, out decimal peso) || peso <= 0 || peso > 9999.9m)
                {
                    MessageBox.Show("Debe ingresar un peso válido (número entre 0.1 y 9999.9).", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                pac.PesoPac = peso;

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
            // Validar nombre (varchar(100) not null)
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Nombre.Text) ||
                txtGestionMascota_Nombre.Text.Length > 100)
            {
                MessageBox.Show("Debe ingresar un nombre válido para la mascota (máximo 100 caracteres).",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Nombre.Focus();
                return false;
            }

            // Validar especie (varchar(100) not null)
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Especie.Text) ||
                txtGestionMascota_Especie.Text.Length > 100)
            {
                MessageBox.Show("Debe ingresar una especie válida (máximo 100 caracteres).",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Especie.Focus();
                return false;
            }

            // Validar raza (varchar(100) not null)
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Raza.Text) ||
                txtGestionMascota_Raza.Text.Length > 100)
            {
                MessageBox.Show("Debe ingresar una raza válida (máximo 100 caracteres).",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Raza.Focus();
                return false;
            }

            // Validar color (varchar(20) not null)
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Color.Text) ||
                txtGestionMascota_Color.Text.Length > 20)
            {
                MessageBox.Show("Debe ingresar un color válido (máximo 20 caracteres).",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Color.Focus();
                return false;
            }

            // Validar peso (decimal(6,1) not null)
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Peso.Text) ||
                !decimal.TryParse(txtGestionMascota_Peso.Text, out decimal peso) ||
                peso <= 0 || peso > 9999.9m)
            {
                MessageBox.Show("Debe ingresar un peso válido (número entre 0.1 y 9999.9).",
                              "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGestionMascota_Peso.Focus();
                return false;
            }

            // Validar fecha (date not null)
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
            cmbPropietario.Enabled = true;
            propietarioIDActual = 0;
            pacienteIDSeleccionado = 0;

            if (lblInfoPropietario != null)
                lblInfoPropietario.Visible = false;
        }

        private void LimpiarBusqueda()
        {
            // 🔹 DESCONECTAR temporalmente el evento para evitar el loop
            txtBusqueda.TextChanged -= textBox1_TextChanged;

            try
            {
                txtBusqueda.Clear();
                MostrarPacientes();

                if (dgvMascotas != null)
                {
                    dgvMascotas.ClearSelection();
                    dgvMascotas.CurrentCell = null;
                }
            }
            finally
            {
                // 🔹 VOLVER a conectar el evento
                txtBusqueda.TextChanged += textBox1_TextChanged;
            }
        }

        private void MostrarPacientes()
        {
            try
            {
                // evitar que el SelectionChanged haga cosas mientras asignamos el DataSource
                dgvMascotas.SelectionChanged -= dgvMascotas_SelectionChanged;

                dgvMascotas.DataSource = null;
                DataTable pacientes = Pacientes.CargarPacientes();
                dgvMascotas.DataSource = pacientes;

                if (dgvMascotas.Columns.Count > 0)
                {
                    ConfigurarColumnasDataGridView();
                }

                // Ejecutar después del layout/focus para asegurarnos de que no vuelva a seleccionarse
                this.BeginInvoke((Action)(() =>
                {
                    try
                    {
                        dgvMascotas.ClearSelection();
                        dgvMascotas.CurrentCell = null;
                    }
                    catch { /* ignorar si no hay celdas */ }

                    // reconectar el evento ahora que ya no hay selección
                    dgvMascotas.SelectionChanged += dgvMascotas_SelectionChanged;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ConfigurarColumnasDataGridView()
        {
            if (dgvMascotas.Columns.Count > 0)
            {
                dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 🔹 Ocultar columna interna que no queremos mostrar al usuario
                if (dgvMascotas.Columns.Contains("PropietarioID"))
                {
                    dgvMascotas.Columns["PropietarioID"].Visible = false;
                }
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

                cmbPropietario.DisplayMember = "NombreProp1";
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
                if (dgvMascotas.CurrentRow == null || pacienteIDSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un registro para eliminar.",
                                  "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta mascota?",
                                                       "Confirmar Eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Pacientes p = new Pacientes();
                    if (p.EliminarPaciente(pacienteIDSeleccionado))
                    {
                        MessageBox.Show("El registro se ha borrado con éxito", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarPacientes();
                        LimpiarCampos();
                        LimpiarBusqueda();
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
                if (dgvMascotas.CurrentRow == null || pacienteIDSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un registro para actualizar.",
                                  "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidarCampos())
                    return;

                if (propietarioIDActual == 0)
                {
                    MessageBox.Show("No se puede actualizar. Propietario no identificado.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Pacientes pac = new Pacientes();
                pac.PacienteID = pacienteIDSeleccionado;
                pac.NombrePac = txtGestionMascota_Nombre.Text.Trim();
                pac.EspeciePac = txtGestionMascota_Especie.Text.Trim();
                pac.RazaPac = txtGestionMascota_Raza.Text.Trim();
                pac.NacimientoPac = dtpGestionMascota_Nacimiento.Value;

                // Validación específica para decimal (6,1)
                if (!decimal.TryParse(txtGestionMascota_Peso.Text, out decimal peso) || peso <= 0 || peso > 9999.9m)
                {
                    MessageBox.Show("Debe ingresar un peso válido (número entre 0.1 y 9999.9).", "Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                pac.PesoPac = peso;

                pac.SexoPac = rbMacho.Checked ? "Macho" : "Hembra";
                pac.ColorPac = txtGestionMascota_Color.Text.Trim();
                pac.PropietarioID = propietarioIDActual;

                bool resultado = pac.ActualizarPaciente();

                if (resultado)
                {
                    MessageBox.Show("El registro se ha actualizado con éxito", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPacientes();
                    LimpiarCampos();
                    LimpiarBusqueda();
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

        private void dgvMascotas_SelectionChanged(object sender, EventArgs e)
        {
            if (cargandoDatos) return;
            CargarDatosSeleccionados();
        }

        private void dgvMascotas_DoubleClick(object sender, EventArgs e)
        {
            CargarDatosSeleccionados();
        }

        //private void CargarDatosSeleccionados()
        //{
        //    try
        //    {
        //        if (dgvMascotas.CurrentRow == null)
        //            return;

        //        DataRowView row = (DataRowView)dgvMascotas.CurrentRow.DataBoundItem;

        //        // 🔹 VERIFICA PRIMERO QUÉ COLUMNAS TIENES DISPONIBLES
        //        Console.WriteLine("Columnas disponibles:");
        //        foreach (DataColumn col in row.DataView.Table.Columns)
        //        {
        //            Console.WriteLine($"- {col.ColumnName}");
        //        }

        //        // 🔹 USA LOS NOMBRES CORRECTOS DE COLUMNAS (ajusta según lo que veas arriba)
        //        txtGestionMascota_Nombre.Text = row["NombrePac"]?.ToString() ??
        //                                       row["Nombre_Paciente"]?.ToString() ??
        //                                       row["NombrePaciente"]?.ToString() ?? "";

        //        txtGestionMascota_Especie.Text = row["EspeciePac"]?.ToString() ??
        //                                        row["Especie"]?.ToString() ?? "";

        //        txtGestionMascota_Raza.Text = row["RazaPac"]?.ToString() ??
        //                                     row["Raza"]?.ToString() ?? "";

        //        // Fecha - maneja diferentes nombres
        //        if (row["NacimientoPac"] != DBNull.Value)
        //            dtpGestionMascota_Nacimiento.Value = Convert.ToDateTime(row["NacimientoPac"]);
        //        else if (row["Nacimiento"] != DBNull.Value)
        //            dtpGestionMascota_Nacimiento.Value = Convert.ToDateTime(row["Nacimiento"]);

        //        // Peso
        //        txtGestionMascota_Peso.Text = row["PesoPac"]?.ToString() ??
        //                                     row["Peso"]?.ToString() ?? "";

        //        // Color
        //        txtGestionMascota_Color.Text = row["ColorPac"]?.ToString() ??
        //                                      row["Color"]?.ToString() ?? "";

        //        // Sexo
        //        string sexo = row["SexoPac"]?.ToString() ??
        //                     row["Sexo"]?.ToString() ?? "";
        //        rbMacho.Checked = sexo.Equals("Macho", StringComparison.OrdinalIgnoreCase);
        //        rbHembra.Checked = sexo.Equals("Hembra", StringComparison.OrdinalIgnoreCase);

        //        // IDs - usa los nombres correctos
        //        pacienteIDSeleccionado = Convert.ToInt32(row["PacienteID"] ?? row["pacienteid"] ?? row["#"] ?? 0);
        //        propietarioIDActual = Convert.ToInt32(row["PropietarioID"] ?? row["PropietarioId"] ?? 0);

        //        // Resto del código...
        //        foreach (Propietarios prop in cmbPropietario.Items)
        //        {
        //            if (prop.Id == propietarioIDActual)
        //            {
        //                cmbPropietario.SelectedItem = prop;
        //                break;
        //            }
        //        }

        //        cmbPropietario.Enabled = false;

        //        if (lblInfoPropietario != null)
        //        {
        //            lblInfoPropietario.Visible = true;
        //            lblInfoPropietario.Text = "Propietario: No se puede modificar en actualizaciones";
        //            lblInfoPropietario.ForeColor = Color.Blue;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar datos: {ex.Message}\n\nColumnas disponibles:\n{string.Join(", ", GetColumnNames())}",
        //                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// Método auxiliar para ver columnas
        //private List<string> GetColumnNames()
        //{
        //    List<string> columns = new List<string>();
        //    if (dgvMascotas.DataSource != null && dgvMascotas.Rows.Count > 0)
        //    {
        //        foreach (DataGridViewColumn col in dgvMascotas.Columns)
        //        {
        //            columns.Add(col.Name);
        //        }
        //    }
        //    return columns;
        //}

        private void CargarDatosSeleccionados()
        {
            try
            {
                if (dgvMascotas.CurrentRow == null)
                    return;

                DataRowView row = (DataRowView)dgvMascotas.CurrentRow.DataBoundItem;


                Console.WriteLine("Columnas disponibles:");
                foreach (DataColumn col in row.DataView.Table.Columns)
                {
                    Console.WriteLine($"- {col.ColumnName}");
                }

                // Cargar datos de la mascota
                txtGestionMascota_Nombre.Text = row["Nombre_Paciente"].ToString();
                txtGestionMascota_Especie.Text = row["Especie"].ToString();
                txtGestionMascota_Raza.Text = row["Raza"].ToString();
                dtpGestionMascota_Nacimiento.Value = Convert.ToDateTime(row["Nacimiento"]);
                txtGestionMascota_Peso.Text = row["Peso"].ToString();
                txtGestionMascota_Color.Text = row["Color"].ToString();

                // Sexo
                string sexo = row["Sexo"].ToString();
                rbMacho.Checked = sexo.Equals("Macho", StringComparison.OrdinalIgnoreCase);
                rbHembra.Checked = sexo.Equals("Hembra", StringComparison.OrdinalIgnoreCase);

                // IDs
                pacienteIDSeleccionado = Convert.ToInt32(row["#"]);  // PacienteID
                propietarioIDActual = Convert.ToInt32(row["PropietarioID"]); // PropietarioID de la vista

                // Buscar en el ComboBox el propietario por ID (no por nombre)
                foreach (Propietarios prop in cmbPropietario.Items)
                {
                    if (prop.Id == propietarioIDActual)
                    {
                        cmbPropietario.SelectedItem = prop;
                        break;
                    }
                }

                // Deshabilitar el combo para que no cambien el propietario
                cmbPropietario.Enabled = false;

                // Mostrar info
                if (lblInfoPropietario != null)
                {
                    lblInfoPropietario.Visible = true;
                    lblInfoPropietario.Text = "Propietario: No se puede modificar en actualizaciones";
                    lblInfoPropietario.ForeColor = Color.Blue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarBusqueda();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Pequeño delay para evitar búsquedas con cada tecla
            Timer searchTimer = new Timer();
            searchTimer.Interval = 500; // 500ms
            searchTimer.Tick += (s, args) =>
            {
                searchTimer.Stop();

                // 🔹 DESCONECTAR evento durante la actualización
                dgvMascotas.SelectionChanged -= dgvMascotas_SelectionChanged;

                try
                {
                    string texto = txtBusqueda.Text.Trim();
                    if (string.IsNullOrEmpty(texto))
                    {
                        MostrarPacientes(); // Volver a mostrar todos
                    }
                    else
                    {
                        dgvMascotas.DataSource = Pacientes.BuscarCita(texto);
                    }

                    // 🔹 LIMPIAR selección y campos
                    dgvMascotas.ClearSelection();
                    dgvMascotas.CurrentCell = null;
                    LimpiarCampos();
                }
                finally
                {
                    // 🔹 VOLVER a conectar el evento
                    dgvMascotas.SelectionChanged += dgvMascotas_SelectionChanged;
                }
            };
            searchTimer.Start();
        }
    }
}
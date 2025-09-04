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
        public frmGestionMascotas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Nombre.Text) ||
                !Regex.IsMatch(txtGestionMascota_Nombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un nombre válido para la mascota (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Especie.Text) ||
                !Regex.IsMatch(txtGestionMascota_Especie.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar una especie válida (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Raza.Text) ||
                !Regex.IsMatch(txtGestionMascota_Raza.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar una raza válida (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Color.Text) ||
                !Regex.IsMatch(txtGestionMascota_Color.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un color válido (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Sexo.Text) ||
                !Regex.IsMatch(txtGestionMascota_Sexo.Text, @"^(Macho|Hembra)$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Debe ingresar el sexo de la mascota (Macho o Hembra).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Peso.Text) ||
                !double.TryParse(txtGestionMascota_Peso.Text, out double peso) || peso <= 0)
            {
                MessageBox.Show("Debe ingresar un peso válido (número mayor que 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (dtpGestionMascota_Nacimiento.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Pacientes pac = new Pacientes();
            pac.NombrePac = txtGestionMascota_Nombre.Text;
            pac.RazaPac = txtGestionMascota_Raza.Text;
            pac.ColorPac = txtGestionMascota_Color.Text;
            pac.NacimientoPac = dtpGestionMascota_Nacimiento.Value;
            pac.PesoPac = txtGestionMascota_Peso.Text;
            pac.EspeciePac = txtGestionMascota_Especie.Text;
            pac.SexoPac = txtGestionMascota_Sexo.Text;

            pac.InsertarPacientes();
            Pacientes.CargarPacientes();
            MostrarPacientes();

        }

        private void frmGestionMascotas_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void MostrarPacientes()
        {
            dgvMascotas.DataSource = null;
            dgvMascotas.DataSource = Pacientes.CargarPacientes();
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }
            int id = int.Parse(dgvMascotas.CurrentRow.Cells[0].Value.ToString());
            Pacientes p = new Pacientes();
            if (p.EliminarPaciente(id) == true)
            {
                MessageBox.Show("El registro se ah borrado con exito");
                MostrarPacientes();
            }
            else
            {
                MessageBox.Show("Se ah producido un ERROR");
            }
        }

            private void btnActualizarInfoMascota_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para actualizar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGestionMascota_Nombre.Text) ||
                !Regex.IsMatch(txtGestionMascota_Nombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un nombre válido para la mascota (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Especie.Text) ||
                !Regex.IsMatch(txtGestionMascota_Especie.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar una especie válida (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Raza.Text) ||
                !Regex.IsMatch(txtGestionMascota_Raza.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar una raza válida (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Color.Text) ||
                !Regex.IsMatch(txtGestionMascota_Color.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Debe ingresar un color válido (solo letras).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Sexo.Text) ||
                !Regex.IsMatch(txtGestionMascota_Sexo.Text, @"^(Macho|Hembra)$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Debe ingresar el sexo de la mascota (Macho o Hembra).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtGestionMascota_Peso.Text) ||
                !double.TryParse(txtGestionMascota_Peso.Text, out double peso) || peso <= 0)
            {
                MessageBox.Show("Debe ingresar un peso válido (número mayor que 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (dtpGestionMascota_Nacimiento.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Pacientes pac = new Pacientes();
            pac.NombrePac = txtGestionMascota_Nombre.Text;
            pac.EspeciePac = txtGestionMascota_Especie.Text;
            pac.RazaPac = txtGestionMascota_Raza.Text;
            pac.NacimientoPac = dtpGestionMascota_Nacimiento.Value;
            pac.PesoPac = txtGestionMascota_Peso.Text;
            pac.SexoPac = txtGestionMascota_Sexo.Text;
            pac.ColorPac = txtGestionMascota_Color.Text;
            pac.PacienteID = int.Parse(dgvMascotas.CurrentRow.Cells[0].Value.ToString());

            if (pac.ActualizarPaciente() == true)
            {
                MessageBox.Show("El registro se ha actualizado con exito");
                MostrarPacientes();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un ERROR");
            }
        }
        

        private void dgvMascotas_DoubleClick(object sender, EventArgs e)
        {
            txtGestionMascota_Nombre.Text = dgvMascotas.CurrentRow.Cells[1].Value.ToString();
            txtGestionMascota_Especie.Text = dgvMascotas.CurrentRow.Cells[2].Value.ToString();
            txtGestionMascota_Raza.Text = dgvMascotas.CurrentRow.Cells[3].Value.ToString();
            dtpGestionMascota_Nacimiento.Value = Convert.ToDateTime(dgvMascotas.CurrentRow.Cells[4].Value);
            txtGestionMascota_Peso.Text = dgvMascotas.CurrentRow.Cells[5].Value.ToString();
            txtGestionMascota_Sexo.Text = dgvMascotas.CurrentRow.Cells[6].Value.ToString();
            txtGestionMascota_Color.Text = dgvMascotas.CurrentRow.Cells[7].Value.ToString();
        }
    }
}

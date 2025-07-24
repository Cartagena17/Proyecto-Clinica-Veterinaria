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
            Pacientes pac = new Pacientes();
            pac.PropietarioID = int.Parse(txtGestionMascota_Prop.Text);
            pac.NombrePac = txtGestionMascota_Nombre.Text;
            pac.RazaPac = txtGestionMascota_Raza.Text;
            pac.ColorPac = txtGestionMascota_Color.Text;
            pac.NacimientoPac = dtpGestionMascota_Nacimiento.Value;
            pac.PesoPac = txtGestionMascota_Peso.Text;
            pac.EspeciePac = txtGestionMascota_Especie.Text;
            pac.SexoPac = txtGestionMascota_Sexo.Text;

            pac.InsertarPacientes();
            Pacientes.CargarPacientes();

        }

        private void frmGestionMascotas_Load(object sender, EventArgs e)
        {
           
        }

        private void MostrarPacientes()
        {
            dgvMascotas.DataSource = null;
            dgvMascotas.DataSource = Pacientes.CargarPacientes();
        }
    }
}

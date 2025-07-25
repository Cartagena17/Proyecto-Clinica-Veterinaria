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
            Citas c = new Citas();
            c.PersonalID1 = int.Parse(txtAgendarCita_Veterinario.Text);
            c.PropietarioID1 = int.Parse(txtAgendarCita_Propietario.Text);
            c.PacientID1 = int.Parse(txtAgendarCita_Paciente.Text);
            c.HoraCita1 = txtAgendarCita_Hora.Text;
            c.FechaCita1 = dtpAgendarCita_Fecha.Value;
            c.MotivoCita1 = txtAgendarCita_Motivo.Text;

            c.InsertarCita();
            Citas.CargarCitas();
            MostrarCitas();

           
        }

        private void MostrarCitas()
        {
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = Citas.CargarCitas();
        }
    }
}

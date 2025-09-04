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
            c.PersonalID = int.Parse(txtAgendarCita_Veterinario.Text);
            c.PropietarioID = int.Parse(cbAgendarCita_Propietario.);
            c.PacientID = int.Parse(txtAgendarCita_Paciente.Text);
            c.HoraCita = txtAgendarCita_Hora.Text;
            c.FechaCita = dtpAgendarCita_Fecha.Value;
            c.MotivoCita = txtAgendarCita_Motivo.Text;

            c.InsertarCita();
            Citas.CargarCitas();
            MostrarCitas();


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

            dtpAgendarCita_Fecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells[4].Value.ToString());
            txtAgendarCita_Hora.Text = dgvCitas.CurrentRow.Cells[5].Value.ToString();
            txtAgendarCita_Motivo.Text = dgvCitas.CurrentRow.Cells[6].Value.ToString();
            txtAgendarCitas_Notas.Text = dgvCitas.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnEliminarCIta_Click_1(object sender, EventArgs e)
        {

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

            Citas c = new Citas();
            c.CitaID = int.Parse(dgvCitas.CurrentRow.Cells[0].Value.ToString());
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
    }
}
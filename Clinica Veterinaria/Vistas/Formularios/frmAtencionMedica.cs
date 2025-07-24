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
            ConsultasMedicas CM = new ConsultasMedicas();
            CM.CitaID1 = int.Parse(txtAtencionMedica_CitaID.Text);
            CM.PersonalID1 = int.Parse(txtAtencionMedica_NombrePers.Text);
            CM.PacienteID1 = int.Parse(txtAtencionMedica_NombrePac.Text);
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
    }
}

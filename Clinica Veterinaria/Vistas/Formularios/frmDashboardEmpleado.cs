using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmDashboardEmpleado : Form
    {
        public frmDashboardEmpleado()
        {
            InitializeComponent();
        }
        #region
        private Form activarForm = null;
        private void AbrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            //Vamos a darle todo lo q recibe por parametros al atributo
            //Esto con el fin de manipular los formularios q se reciben por parametro
            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void ibtnGestionCitas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgendarCita());
        }

        private void ibtnGestionMedica_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAtencionMedica());

        }

        private void ibtnGestionPropietarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionPropietarios());

        }

        private void ibtnGestionMascotas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionMascotas());

        }

        private void frmDashboardEmpleado_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0); // 120 = semi-transparente, negro

        }
    }
}

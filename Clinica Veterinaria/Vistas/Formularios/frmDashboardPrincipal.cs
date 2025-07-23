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
    public partial class frmDashboardPrincipal : Form
    {
        public frmDashboardPrincipal()
        {
            InitializeComponent();
        }

        private void btnDashboard_GestionPersonal_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionPersonal());
        }

        private void btnDashboard_GestionCitas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgendarCita());
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

        private void btnDashboard_GestionMedica_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAtencionMedica());
        }

        private void btnDashboard_GestionMascotas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionMascotas());
        }

        private void btnDashboard_GestionPropietarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionPropietarios());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInventario());
        }

        private void btnDashboard_Facturacion_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmFacturacion());
        }
    }
}

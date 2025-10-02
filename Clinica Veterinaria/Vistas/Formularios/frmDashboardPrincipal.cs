using System;
using System.Windows.Forms;
using Modelos;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmDashboardPrincipal : Form
    {




        public frmDashboardPrincipal()
        {
            InitializeComponent();
        }

        //private void ConfigurarMenuSegunRol()
        //{
        //    // VERIFICAR PRIMERO SI HAY USUARIO EN SESIÓN
        //    if (Session.UsuarioActual == null)
        //    {
        //        MessageBox.Show("Error: No hay usuario en sesión. Cerrando aplicación...",
        //                      "Error de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Application.Exit();
        //        return;
        //    }

        //    // AHORA SÍ VERIFICAR EL ROL
        //    if (Session.EsEmpleado)
        //    {
        //        empleadosToolStrip.Visible = false;
        //        // Ocultar otros menús que no deben ver los empleados
        //        gestionUsuariosToolStrip.Visible = false;
        //        reportesToolStrip.Visible = false; // si existe
        //    }

        //    // Mostrar información del usuario
        //    MostrarInformacionUsuario();
        //}

        //private void MostrarInformacionUsuario()
        //{
        //    if (Session.UsuarioActual != null)
        //    {
        //        // Actualizar labels si los tienes
        //        // lblUsuario.Text = $"Usuario: {Session.UsuarioActual.NombreUsuario}";
        //        // lblRol.Text = $"Rol: {Session.UsuarioActual.Rol}";
        //    }
        //}

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


        private void btnVolverDashboard_Click(object sender, EventArgs e)
        {
            frmDashboardPrincipal dashboard = new frmDashboardPrincipal();
            dashboard.Show();



        }



        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmDashboardPrincipal_load(object sender, PaintEventArgs e)
        {

            MostrarCitasPendientes();
        }

        private void MostrarCitasPendientes()
        {
            dgvCitasPendientes.DataSource = null;
            dgvCitasPendientes.DataSource = Citas.CargarCitas();
        }

        private void btnMostrarCitasPendientes_Click(object sender, EventArgs e)
        {
            Citas.CargarCitas();
            MostrarCitasPendientes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

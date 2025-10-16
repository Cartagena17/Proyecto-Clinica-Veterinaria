using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Modelos;
using Modelos.Entidades;
using System.Drawing;


namespace Vistas.Formularios
{
    public partial class frmDashboardPrincipal : Form
    {
       




        public frmDashboardPrincipal()
        {
            InitializeComponent();
            pnlMenuPrincipal.AutoScroll = false;

            
        
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

       



        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmDashboardPrincipal_load(object sender, PaintEventArgs e)
        {

        }


    
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void frmDashboardPrincipal_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0); // 120 = semi-transparente, negro

            ////Icono Citas
            //IconButton btnDashboard_GestionCitas = new IconButton();
            //btnDashboard_GestionCitas.Text = "Gestión de Citas";
            //btnDashboard_GestionCitas.IconChar = IconChar.CalendarCheck; // Ícono
            //btnDashboard_GestionCitas.IconColor = Color.White;
            //btnDashboard_GestionCitas.TextImageRelation = TextImageRelation.ImageBeforeText;
            //btnDashboard_GestionCitas.FlatStyle = FlatStyle.Flat;
            //btnDashboard_GestionCitas.ForeColor = Color.White;
            //btnDashboard_GestionCitas.BackColor = Color.FromArgb(58, 124, 165);
            //btnDashboard_GestionCitas.Dock = DockStyle.Top;   // igual que los botones originales
            //btnDashboard_GestionCitas.Height = 65;           // tamaño similar al Designer
            //btnDashboard_GestionCitas.Padding = new Padding(27, 0, 0, 0); // texto alineado
            //btnDashboard_GestionCitas.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold);
            //Icono Medicas
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

        private void ibtnGestionPersonal_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionPersonal());

        }
    }
}

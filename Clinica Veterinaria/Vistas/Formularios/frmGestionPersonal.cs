using Modelos.Entidades;
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
    public partial class frmGestionPersonal : Form
    {
        public frmGestionPersonal()
        {
            InitializeComponent();
        }

        private void frmGestionPersonal_Load(object sender, EventArgs e)
        {
            MostrarPersonal();
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.NombrePers = txtGestionPersonal_Nombre.Text;
            per.ApellidoPers = txtGestionPersonal_Apellido.Text;
            per.Rol = txtGestionPersonal_Rol.Text;
            per.TelefonoPers = txtGestionPersonal_Telefono.Text;
            per.EmailPers = txtGestionPersonal_Email.Text;

            per.InsertarPersonal();
            MostrarPersonal();
        }

        private void MostrarPersonal()
        {
            dgvPersonal.DataSource = null;
            dgvPersonal.DataSource = Personal.CargarPersonal();
        }
    }
}

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

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dgvPersonal.CurrentRow.Cells[0].Value.ToString());
            Personal p = new Personal();
            if (p.EliminarPersonal(id) == true)
            {
                MessageBox.Show("El registro se ah borrado con exito");
                MostrarPersonal();
            }
            else
            {
                MessageBox.Show("Se ah producido un ERROR");
            }

        }

        private void btnActualizarInfoPersonal_Click(object sender, EventArgs e)
        {
            Personal p = new Personal();
            p.NombrePers=txtGestionPersonal_Nombre.Text;
            p.ApellidoPers=txtGestionPersonal_Apellido.Text;
            p.EmailPers=txtGestionPersonal_Email.Text;
            p.TelefonoPers=txtGestionPersonal_Telefono.Text;
            p.PersonalID = int.Parse(dgvPersonal.CurrentRow.Cells[0].Value.ToString());
           




            if (p.ActualizarPersonal() == true)
            {
                MessageBox.Show("El registro se ah actualizado con exito");
                MostrarPersonal();
            }
            else
            {
                MessageBox.Show("ah ocurrido un ERROR");
            }
        }


        private void dgvPersonal_DoubleClick(object sender, EventArgs e)
        {

            txtGestionPersonal_Nombre.Text = dgvPersonal.CurrentRow.Cells[1].Value.ToString();
            txtGestionPersonal_Apellido.Text = dgvPersonal.CurrentRow.Cells[2].Value.ToString();
            txtGestionPersonal_Telefono.Text = dgvPersonal.CurrentRow.Cells[3].Value.ToString();
            txtGestionPersonal_Email.Text = dgvPersonal.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
    
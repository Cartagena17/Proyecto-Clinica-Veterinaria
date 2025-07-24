namespace Vistas.Formularios
{
    partial class frmGestionPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGestionPersonal = new System.Windows.Forms.Label();
            this.pnlGestionPersonal = new System.Windows.Forms.Panel();
            this.btnVerPersonal = new System.Windows.Forms.Button();
            this.btnActualizarInfoPersonal = new System.Windows.Forms.Button();
            this.btnEliminarPersonal = new System.Windows.Forms.Button();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.txtGestionPersonal_Email = new System.Windows.Forms.TextBox();
            this.txtGestionPersonal_Telefono = new System.Windows.Forms.TextBox();
            this.txtGestionPersonal_Rol = new System.Windows.Forms.TextBox();
            this.txtGestionPersonal_Apellido = new System.Windows.Forms.TextBox();
            this.txtGestionPersonal_Nombre = new System.Windows.Forms.TextBox();
            this.lblGestionPersonal_Email = new System.Windows.Forms.Label();
            this.lblGestionPersonal_Telefono = new System.Windows.Forms.Label();
            this.lblGestionPersonal_Rol = new System.Windows.Forms.Label();
            this.lblGestionPersonal_Apellido = new System.Windows.Forms.Label();
            this.lblGestionPersonal_Nombre = new System.Windows.Forms.Label();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.pnlGestionPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPersonal
            // 
            this.lblGestionPersonal.AutoSize = true;
            this.lblGestionPersonal.Location = new System.Drawing.Point(240, 21);
            this.lblGestionPersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionPersonal.Name = "lblGestionPersonal";
            this.lblGestionPersonal.Size = new System.Drawing.Size(104, 13);
            this.lblGestionPersonal.TabIndex = 0;
            this.lblGestionPersonal.Text = "Gestion del Personal";
            // 
            // pnlGestionPersonal
            // 
            this.pnlGestionPersonal.Controls.Add(this.btnVerPersonal);
            this.pnlGestionPersonal.Controls.Add(this.btnActualizarInfoPersonal);
            this.pnlGestionPersonal.Controls.Add(this.btnEliminarPersonal);
            this.pnlGestionPersonal.Controls.Add(this.btnAgregarPersonal);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Email);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Telefono);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Rol);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Apellido);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Nombre);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Email);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Telefono);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Rol);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Apellido);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Nombre);
            this.pnlGestionPersonal.Location = new System.Drawing.Point(58, 67);
            this.pnlGestionPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGestionPersonal.Name = "pnlGestionPersonal";
            this.pnlGestionPersonal.Size = new System.Drawing.Size(473, 229);
            this.pnlGestionPersonal.TabIndex = 1;
            // 
            // btnVerPersonal
            // 
            this.btnVerPersonal.Location = new System.Drawing.Point(361, 150);
            this.btnVerPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerPersonal.Name = "btnVerPersonal";
            this.btnVerPersonal.Size = new System.Drawing.Size(88, 41);
            this.btnVerPersonal.TabIndex = 13;
            this.btnVerPersonal.Text = "Ver Personal";
            this.btnVerPersonal.UseVisualStyleBackColor = true;
            // 
            // btnActualizarInfoPersonal
            // 
            this.btnActualizarInfoPersonal.Location = new System.Drawing.Point(266, 152);
            this.btnActualizarInfoPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizarInfoPersonal.Name = "btnActualizarInfoPersonal";
            this.btnActualizarInfoPersonal.Size = new System.Drawing.Size(80, 40);
            this.btnActualizarInfoPersonal.TabIndex = 12;
            this.btnActualizarInfoPersonal.Text = "Actualizar Informacion";
            this.btnActualizarInfoPersonal.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.Location = new System.Drawing.Point(160, 151);
            this.btnEliminarPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(86, 41);
            this.btnEliminarPersonal.TabIndex = 11;
            this.btnEliminarPersonal.Text = "Eliminar Personal";
            this.btnEliminarPersonal.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.Location = new System.Drawing.Point(69, 151);
            this.btnAgregarPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(77, 40);
            this.btnAgregarPersonal.TabIndex = 10;
            this.btnAgregarPersonal.Text = "Agregar Personal";
            this.btnAgregarPersonal.UseVisualStyleBackColor = true;
            this.btnAgregarPersonal.Click += new System.EventHandler(this.btnAgregarPersonal_Click);
            // 
            // txtGestionPersonal_Email
            // 
            this.txtGestionPersonal_Email.Location = new System.Drawing.Point(326, 59);
            this.txtGestionPersonal_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGestionPersonal_Email.Name = "txtGestionPersonal_Email";
            this.txtGestionPersonal_Email.Size = new System.Drawing.Size(125, 20);
            this.txtGestionPersonal_Email.TabIndex = 9;
            // 
            // txtGestionPersonal_Telefono
            // 
            this.txtGestionPersonal_Telefono.Location = new System.Drawing.Point(326, 15);
            this.txtGestionPersonal_Telefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGestionPersonal_Telefono.Name = "txtGestionPersonal_Telefono";
            this.txtGestionPersonal_Telefono.Size = new System.Drawing.Size(125, 20);
            this.txtGestionPersonal_Telefono.TabIndex = 8;
            // 
            // txtGestionPersonal_Rol
            // 
            this.txtGestionPersonal_Rol.Location = new System.Drawing.Point(109, 106);
            this.txtGestionPersonal_Rol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGestionPersonal_Rol.Name = "txtGestionPersonal_Rol";
            this.txtGestionPersonal_Rol.Size = new System.Drawing.Size(120, 20);
            this.txtGestionPersonal_Rol.TabIndex = 7;
            // 
            // txtGestionPersonal_Apellido
            // 
            this.txtGestionPersonal_Apellido.Location = new System.Drawing.Point(130, 59);
            this.txtGestionPersonal_Apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGestionPersonal_Apellido.Name = "txtGestionPersonal_Apellido";
            this.txtGestionPersonal_Apellido.Size = new System.Drawing.Size(116, 20);
            this.txtGestionPersonal_Apellido.TabIndex = 6;
            // 
            // txtGestionPersonal_Nombre
            // 
            this.txtGestionPersonal_Nombre.Location = new System.Drawing.Point(130, 18);
            this.txtGestionPersonal_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGestionPersonal_Nombre.Name = "txtGestionPersonal_Nombre";
            this.txtGestionPersonal_Nombre.Size = new System.Drawing.Size(116, 20);
            this.txtGestionPersonal_Nombre.TabIndex = 5;
            // 
            // lblGestionPersonal_Email
            // 
            this.lblGestionPersonal_Email.AutoSize = true;
            this.lblGestionPersonal_Email.Location = new System.Drawing.Point(288, 64);
            this.lblGestionPersonal_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionPersonal_Email.Name = "lblGestionPersonal_Email";
            this.lblGestionPersonal_Email.Size = new System.Drawing.Size(35, 13);
            this.lblGestionPersonal_Email.TabIndex = 4;
            this.lblGestionPersonal_Email.Text = "Email:";
            // 
            // lblGestionPersonal_Telefono
            // 
            this.lblGestionPersonal_Telefono.AutoSize = true;
            this.lblGestionPersonal_Telefono.Location = new System.Drawing.Point(273, 18);
            this.lblGestionPersonal_Telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionPersonal_Telefono.Name = "lblGestionPersonal_Telefono";
            this.lblGestionPersonal_Telefono.Size = new System.Drawing.Size(52, 13);
            this.lblGestionPersonal_Telefono.TabIndex = 3;
            this.lblGestionPersonal_Telefono.Text = "Telefono:";
            // 
            // lblGestionPersonal_Rol
            // 
            this.lblGestionPersonal_Rol.AutoSize = true;
            this.lblGestionPersonal_Rol.Location = new System.Drawing.Point(22, 106);
            this.lblGestionPersonal_Rol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionPersonal_Rol.Name = "lblGestionPersonal_Rol";
            this.lblGestionPersonal_Rol.Size = new System.Drawing.Size(87, 13);
            this.lblGestionPersonal_Rol.TabIndex = 2;
            this.lblGestionPersonal_Rol.Text = "Rol del Personal:";
            // 
            // lblGestionPersonal_Apellido
            // 
            this.lblGestionPersonal_Apellido.AutoSize = true;
            this.lblGestionPersonal_Apellido.Location = new System.Drawing.Point(22, 59);
            this.lblGestionPersonal_Apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionPersonal_Apellido.Name = "lblGestionPersonal_Apellido";
            this.lblGestionPersonal_Apellido.Size = new System.Drawing.Size(108, 13);
            this.lblGestionPersonal_Apellido.TabIndex = 1;
            this.lblGestionPersonal_Apellido.Text = "Apellido del Personal:";
            // 
            // lblGestionPersonal_Nombre
            // 
            this.lblGestionPersonal_Nombre.AutoSize = true;
            this.lblGestionPersonal_Nombre.Location = new System.Drawing.Point(22, 18);
            this.lblGestionPersonal_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionPersonal_Nombre.Name = "lblGestionPersonal_Nombre";
            this.lblGestionPersonal_Nombre.Size = new System.Drawing.Size(108, 13);
            this.lblGestionPersonal_Nombre.TabIndex = 0;
            this.lblGestionPersonal_Nombre.Text = "Nombre del Personal:";
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(58, 310);
            this.dgvPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.RowHeadersWidth = 51;
            this.dgvPersonal.RowTemplate.Height = 24;
            this.dgvPersonal.Size = new System.Drawing.Size(644, 245);
            this.dgvPersonal.TabIndex = 2;
            // 
            // frmGestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 578);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.pnlGestionPersonal);
            this.Controls.Add(this.lblGestionPersonal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionPersonal";
            this.Text = "frmGestionPersonal";
            this.Load += new System.EventHandler(this.frmGestionPersonal_Load);
            this.pnlGestionPersonal.ResumeLayout(false);
            this.pnlGestionPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPersonal;
        private System.Windows.Forms.Panel pnlGestionPersonal;
        private System.Windows.Forms.Label lblGestionPersonal_Email;
        private System.Windows.Forms.Label lblGestionPersonal_Telefono;
        private System.Windows.Forms.Label lblGestionPersonal_Rol;
        private System.Windows.Forms.Label lblGestionPersonal_Apellido;
        private System.Windows.Forms.Label lblGestionPersonal_Nombre;
        private System.Windows.Forms.TextBox txtGestionPersonal_Email;
        private System.Windows.Forms.TextBox txtGestionPersonal_Telefono;
        private System.Windows.Forms.TextBox txtGestionPersonal_Rol;
        private System.Windows.Forms.TextBox txtGestionPersonal_Apellido;
        private System.Windows.Forms.TextBox txtGestionPersonal_Nombre;
        private System.Windows.Forms.Button btnVerPersonal;
        private System.Windows.Forms.Button btnActualizarInfoPersonal;
        private System.Windows.Forms.Button btnEliminarPersonal;
        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.DataGridView dgvPersonal;
    }
}
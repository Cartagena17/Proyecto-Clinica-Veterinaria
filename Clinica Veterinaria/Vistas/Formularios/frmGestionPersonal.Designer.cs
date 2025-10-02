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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarInfoPersonal = new System.Windows.Forms.Button();
            this.btnEliminarPersonal = new System.Windows.Forms.Button();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.txtGestionPersonal_Email = new System.Windows.Forms.TextBox();
            this.txtGestionPersonal_Telefono = new System.Windows.Forms.TextBox();
            this.txtGestionPersonal_Apellido = new System.Windows.Forms.TextBox();
            this.txtGestionPersonal_Nombre = new System.Windows.Forms.TextBox();
            this.lblGestionPersonal_Email = new System.Windows.Forms.Label();
            this.lblGestionPersonal_Telefono = new System.Windows.Forms.Label();
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
            this.lblGestionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.lblGestionPersonal.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPersonal.Location = new System.Drawing.Point(384, 9);
            this.lblGestionPersonal.Name = "lblGestionPersonal";
            this.lblGestionPersonal.Size = new System.Drawing.Size(314, 38);
            this.lblGestionPersonal.TabIndex = 0;
            this.lblGestionPersonal.Text = "Gestion del Personal";
            // 
            // pnlGestionPersonal
            // 
            this.pnlGestionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.pnlGestionPersonal.Controls.Add(this.lblBusqueda);
            this.pnlGestionPersonal.Controls.Add(this.txtBusqueda);
            this.pnlGestionPersonal.Controls.Add(this.btnLimpiarCampos);
            this.pnlGestionPersonal.Controls.Add(this.btnActualizarInfoPersonal);
            this.pnlGestionPersonal.Controls.Add(this.btnEliminarPersonal);
            this.pnlGestionPersonal.Controls.Add(this.btnAgregarPersonal);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Email);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Telefono);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Apellido);
            this.pnlGestionPersonal.Controls.Add(this.txtGestionPersonal_Nombre);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Email);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Telefono);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Apellido);
            this.pnlGestionPersonal.Controls.Add(this.lblGestionPersonal_Nombre);
            this.pnlGestionPersonal.Location = new System.Drawing.Point(87, 41);
            this.pnlGestionPersonal.Name = "pnlGestionPersonal";
            this.pnlGestionPersonal.Size = new System.Drawing.Size(846, 335);
            this.pnlGestionPersonal.TabIndex = 1;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(57, 134);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(65, 24);
            this.lblBusqueda.TabIndex = 15;
            this.lblBusqueda.Text = "label1";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(61, 194);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(531, 32);
            this.txtBusqueda.TabIndex = 14;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(460, 232);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(132, 60);
            this.btnLimpiarCampos.TabIndex = 13;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarInfoPersonal
            // 
            this.btnActualizarInfoPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnActualizarInfoPersonal.FlatAppearance.BorderSize = 0;
            this.btnActualizarInfoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInfoPersonal.Location = new System.Drawing.Point(320, 232);
            this.btnActualizarInfoPersonal.Name = "btnActualizarInfoPersonal";
            this.btnActualizarInfoPersonal.Size = new System.Drawing.Size(141, 60);
            this.btnActualizarInfoPersonal.TabIndex = 12;
            this.btnActualizarInfoPersonal.Text = "Actualizar Informacion";
            this.btnActualizarInfoPersonal.UseVisualStyleBackColor = false;
            this.btnActualizarInfoPersonal.Click += new System.EventHandler(this.btnActualizarInfoPersonal_Click);
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnEliminarPersonal.FlatAppearance.BorderSize = 0;
            this.btnEliminarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPersonal.Location = new System.Drawing.Point(194, 232);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(129, 60);
            this.btnEliminarPersonal.TabIndex = 11;
            this.btnEliminarPersonal.Text = "Eliminar Personal";
            this.btnEliminarPersonal.UseVisualStyleBackColor = false;
            this.btnEliminarPersonal.Click += new System.EventHandler(this.btnEliminarPersonal_Click);
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnAgregarPersonal.FlatAppearance.BorderSize = 0;
            this.btnAgregarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPersonal.Location = new System.Drawing.Point(61, 232);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(137, 60);
            this.btnAgregarPersonal.TabIndex = 10;
            this.btnAgregarPersonal.Text = "Agregar Personal";
            this.btnAgregarPersonal.UseVisualStyleBackColor = false;
            this.btnAgregarPersonal.Click += new System.EventHandler(this.btnAgregarPersonal_Click);
            // 
            // txtGestionPersonal_Email
            // 
            this.txtGestionPersonal_Email.Location = new System.Drawing.Point(516, 86);
            this.txtGestionPersonal_Email.Name = "txtGestionPersonal_Email";
            this.txtGestionPersonal_Email.Size = new System.Drawing.Size(256, 32);
            this.txtGestionPersonal_Email.TabIndex = 9;
            // 
            // txtGestionPersonal_Telefono
            // 
            this.txtGestionPersonal_Telefono.Location = new System.Drawing.Point(516, 23);
            this.txtGestionPersonal_Telefono.Name = "txtGestionPersonal_Telefono";
            this.txtGestionPersonal_Telefono.Size = new System.Drawing.Size(256, 32);
            this.txtGestionPersonal_Telefono.TabIndex = 8;
            // 
            // txtGestionPersonal_Apellido
            // 
            this.txtGestionPersonal_Apellido.Location = new System.Drawing.Point(195, 86);
            this.txtGestionPersonal_Apellido.Name = "txtGestionPersonal_Apellido";
            this.txtGestionPersonal_Apellido.Size = new System.Drawing.Size(194, 32);
            this.txtGestionPersonal_Apellido.TabIndex = 6;
            // 
            // txtGestionPersonal_Nombre
            // 
            this.txtGestionPersonal_Nombre.Location = new System.Drawing.Point(195, 26);
            this.txtGestionPersonal_Nombre.Name = "txtGestionPersonal_Nombre";
            this.txtGestionPersonal_Nombre.Size = new System.Drawing.Size(194, 32);
            this.txtGestionPersonal_Nombre.TabIndex = 5;
            // 
            // lblGestionPersonal_Email
            // 
            this.lblGestionPersonal_Email.AutoSize = true;
            this.lblGestionPersonal_Email.Location = new System.Drawing.Point(432, 94);
            this.lblGestionPersonal_Email.Name = "lblGestionPersonal_Email";
            this.lblGestionPersonal_Email.Size = new System.Drawing.Size(65, 24);
            this.lblGestionPersonal_Email.TabIndex = 4;
            this.lblGestionPersonal_Email.Text = "Email:";
            // 
            // lblGestionPersonal_Telefono
            // 
            this.lblGestionPersonal_Telefono.AutoSize = true;
            this.lblGestionPersonal_Telefono.Location = new System.Drawing.Point(432, 31);
            this.lblGestionPersonal_Telefono.Name = "lblGestionPersonal_Telefono";
            this.lblGestionPersonal_Telefono.Size = new System.Drawing.Size(96, 24);
            this.lblGestionPersonal_Telefono.TabIndex = 3;
            this.lblGestionPersonal_Telefono.Text = "Telefono:";
            // 
            // lblGestionPersonal_Apellido
            // 
            this.lblGestionPersonal_Apellido.AutoSize = true;
            this.lblGestionPersonal_Apellido.Location = new System.Drawing.Point(21, 94);
            this.lblGestionPersonal_Apellido.Name = "lblGestionPersonal_Apellido";
            this.lblGestionPersonal_Apellido.Size = new System.Drawing.Size(209, 24);
            this.lblGestionPersonal_Apellido.TabIndex = 1;
            this.lblGestionPersonal_Apellido.Text = "Apellido del Personal:";
            // 
            // lblGestionPersonal_Nombre
            // 
            this.lblGestionPersonal_Nombre.AutoSize = true;
            this.lblGestionPersonal_Nombre.Location = new System.Drawing.Point(21, 31);
            this.lblGestionPersonal_Nombre.Name = "lblGestionPersonal_Nombre";
            this.lblGestionPersonal_Nombre.Size = new System.Drawing.Size(210, 24);
            this.lblGestionPersonal_Nombre.TabIndex = 0;
            this.lblGestionPersonal_Nombre.Text = "Nombre del Personal:";
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(72, 382);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.RowHeadersWidth = 51;
            this.dgvPersonal.RowTemplate.Height = 24;
            this.dgvPersonal.Size = new System.Drawing.Size(1092, 299);
            this.dgvPersonal.TabIndex = 2;
            this.dgvPersonal.DoubleClick += new System.EventHandler(this.dgvPersonal_DoubleClick);
            // 
            // frmGestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 845);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.pnlGestionPersonal);
            this.Controls.Add(this.lblGestionPersonal);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label lblGestionPersonal_Apellido;
        private System.Windows.Forms.Label lblGestionPersonal_Nombre;
        private System.Windows.Forms.TextBox txtGestionPersonal_Email;
        private System.Windows.Forms.TextBox txtGestionPersonal_Telefono;
        private System.Windows.Forms.TextBox txtGestionPersonal_Apellido;
        private System.Windows.Forms.TextBox txtGestionPersonal_Nombre;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarInfoPersonal;
        private System.Windows.Forms.Button btnEliminarPersonal;
        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}
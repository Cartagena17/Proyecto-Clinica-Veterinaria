namespace Vistas.Formularios
{
    partial class frmGestionPropietarios
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
            this.lblGestionPropietarios = new System.Windows.Forms.Label();
            this.pnlGestionPropietario = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarInfoPropietario = new System.Windows.Forms.Button();
            this.btnEliminarPropietario = new System.Windows.Forms.Button();
            this.btnRegistrarPropietario = new System.Windows.Forms.Button();
            this.txtGestionPropietario_Email = new System.Windows.Forms.TextBox();
            this.txtGestionPropietario_Direccion = new System.Windows.Forms.TextBox();
            this.txtGestionPropietario_Telefono = new System.Windows.Forms.TextBox();
            this.txtGestionPropietario_Nombre = new System.Windows.Forms.TextBox();
            this.lblGestionPropietario_Email = new System.Windows.Forms.Label();
            this.lblGestionPropietario_Direccion = new System.Windows.Forms.Label();
            this.lblGestionPropietario_Telefono = new System.Windows.Forms.Label();
            this.lblGestionPropietario_Nombre = new System.Windows.Forms.Label();
            this.dgvPropietarios = new System.Windows.Forms.DataGridView();
            this.pnlGestionPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPropietarios
            // 
            this.lblGestionPropietarios.AutoSize = true;
            this.lblGestionPropietarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.lblGestionPropietarios.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPropietarios.Location = new System.Drawing.Point(287, 61);
            this.lblGestionPropietarios.Name = "lblGestionPropietarios";
            this.lblGestionPropietarios.Size = new System.Drawing.Size(357, 38);
            this.lblGestionPropietarios.TabIndex = 0;
            this.lblGestionPropietarios.Text = "Gestión de propietarios";
            // 
            // pnlGestionPropietario
            // 
            this.pnlGestionPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.pnlGestionPropietario.Controls.Add(this.txtBuscar);
            this.pnlGestionPropietario.Controls.Add(this.lblBuscar);
            this.pnlGestionPropietario.Controls.Add(this.btnLimpiarCampos);
            this.pnlGestionPropietario.Controls.Add(this.btnActualizarInfoPropietario);
            this.pnlGestionPropietario.Controls.Add(this.btnEliminarPropietario);
            this.pnlGestionPropietario.Controls.Add(this.btnRegistrarPropietario);
            this.pnlGestionPropietario.Controls.Add(this.txtGestionPropietario_Email);
            this.pnlGestionPropietario.Controls.Add(this.txtGestionPropietario_Direccion);
            this.pnlGestionPropietario.Controls.Add(this.txtGestionPropietario_Telefono);
            this.pnlGestionPropietario.Controls.Add(this.txtGestionPropietario_Nombre);
            this.pnlGestionPropietario.Controls.Add(this.lblGestionPropietario_Email);
            this.pnlGestionPropietario.Controls.Add(this.lblGestionPropietario_Direccion);
            this.pnlGestionPropietario.Controls.Add(this.lblGestionPropietario_Telefono);
            this.pnlGestionPropietario.Controls.Add(this.lblGestionPropietario_Nombre);
            this.pnlGestionPropietario.Location = new System.Drawing.Point(146, 94);
            this.pnlGestionPropietario.Name = "pnlGestionPropietario";
            this.pnlGestionPropietario.Size = new System.Drawing.Size(589, 434);
            this.pnlGestionPropietario.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(17, 389);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(400, 32);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(13, 347);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(194, 24);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar Propietarios:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(432, 255);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(128, 56);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarInfoPropietario
            // 
            this.btnActualizarInfoPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnActualizarInfoPropietario.FlatAppearance.BorderSize = 0;
            this.btnActualizarInfoPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInfoPropietario.Location = new System.Drawing.Point(285, 255);
            this.btnActualizarInfoPropietario.Name = "btnActualizarInfoPropietario";
            this.btnActualizarInfoPropietario.Size = new System.Drawing.Size(141, 56);
            this.btnActualizarInfoPropietario.TabIndex = 10;
            this.btnActualizarInfoPropietario.Text = "Actualizar Informacion";
            this.btnActualizarInfoPropietario.UseVisualStyleBackColor = false;
            this.btnActualizarInfoPropietario.Click += new System.EventHandler(this.btnActualizarInfoPropietario_Click);
            // 
            // btnEliminarPropietario
            // 
            this.btnEliminarPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnEliminarPropietario.FlatAppearance.BorderSize = 0;
            this.btnEliminarPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPropietario.Location = new System.Drawing.Point(148, 255);
            this.btnEliminarPropietario.Name = "btnEliminarPropietario";
            this.btnEliminarPropietario.Size = new System.Drawing.Size(131, 56);
            this.btnEliminarPropietario.TabIndex = 9;
            this.btnEliminarPropietario.Text = "Eliminar Propietario";
            this.btnEliminarPropietario.UseVisualStyleBackColor = false;
            this.btnEliminarPropietario.Click += new System.EventHandler(this.btnEliminarPropietario_Click);
            // 
            // btnRegistrarPropietario
            // 
            this.btnRegistrarPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnRegistrarPropietario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPropietario.Location = new System.Drawing.Point(17, 255);
            this.btnRegistrarPropietario.Name = "btnRegistrarPropietario";
            this.btnRegistrarPropietario.Size = new System.Drawing.Size(125, 56);
            this.btnRegistrarPropietario.TabIndex = 8;
            this.btnRegistrarPropietario.Text = "Registrar Propietario";
            this.btnRegistrarPropietario.UseVisualStyleBackColor = false;
            this.btnRegistrarPropietario.Click += new System.EventHandler(this.btnRegistrarPropietario_Click);
            // 
            // txtGestionPropietario_Email
            // 
            this.txtGestionPropietario_Email.Location = new System.Drawing.Point(266, 147);
            this.txtGestionPropietario_Email.Name = "txtGestionPropietario_Email";
            this.txtGestionPropietario_Email.ShortcutsEnabled = false;
            this.txtGestionPropietario_Email.Size = new System.Drawing.Size(166, 32);
            this.txtGestionPropietario_Email.TabIndex = 7;
            // 
            // txtGestionPropietario_Direccion
            // 
            this.txtGestionPropietario_Direccion.Location = new System.Drawing.Point(266, 104);
            this.txtGestionPropietario_Direccion.Name = "txtGestionPropietario_Direccion";
            this.txtGestionPropietario_Direccion.ShortcutsEnabled = false;
            this.txtGestionPropietario_Direccion.Size = new System.Drawing.Size(166, 32);
            this.txtGestionPropietario_Direccion.TabIndex = 6;
            // 
            // txtGestionPropietario_Telefono
            // 
            this.txtGestionPropietario_Telefono.Location = new System.Drawing.Point(266, 64);
            this.txtGestionPropietario_Telefono.Name = "txtGestionPropietario_Telefono";
            this.txtGestionPropietario_Telefono.ShortcutsEnabled = false;
            this.txtGestionPropietario_Telefono.Size = new System.Drawing.Size(166, 32);
            this.txtGestionPropietario_Telefono.TabIndex = 5;
            // 
            // txtGestionPropietario_Nombre
            // 
            this.txtGestionPropietario_Nombre.Location = new System.Drawing.Point(266, 25);
            this.txtGestionPropietario_Nombre.Name = "txtGestionPropietario_Nombre";
            this.txtGestionPropietario_Nombre.ShortcutsEnabled = false;
            this.txtGestionPropietario_Nombre.Size = new System.Drawing.Size(166, 32);
            this.txtGestionPropietario_Nombre.TabIndex = 4;
            // 
            // lblGestionPropietario_Email
            // 
            this.lblGestionPropietario_Email.AutoSize = true;
            this.lblGestionPropietario_Email.Location = new System.Drawing.Point(28, 150);
            this.lblGestionPropietario_Email.Name = "lblGestionPropietario_Email";
            this.lblGestionPropietario_Email.Size = new System.Drawing.Size(206, 24);
            this.lblGestionPropietario_Email.TabIndex = 3;
            this.lblGestionPropietario_Email.Text = "Email del propietario:";
            // 
            // lblGestionPropietario_Direccion
            // 
            this.lblGestionPropietario_Direccion.AutoSize = true;
            this.lblGestionPropietario_Direccion.Location = new System.Drawing.Point(28, 107);
            this.lblGestionPropietario_Direccion.Name = "lblGestionPropietario_Direccion";
            this.lblGestionPropietario_Direccion.Size = new System.Drawing.Size(244, 24);
            this.lblGestionPropietario_Direccion.TabIndex = 2;
            this.lblGestionPropietario_Direccion.Text = "Dirección del propietario:";
            // 
            // lblGestionPropietario_Telefono
            // 
            this.lblGestionPropietario_Telefono.AutoSize = true;
            this.lblGestionPropietario_Telefono.Location = new System.Drawing.Point(28, 67);
            this.lblGestionPropietario_Telefono.Name = "lblGestionPropietario_Telefono";
            this.lblGestionPropietario_Telefono.Size = new System.Drawing.Size(237, 24);
            this.lblGestionPropietario_Telefono.TabIndex = 1;
            this.lblGestionPropietario_Telefono.Text = "Telefono del propietario:";
            // 
            // lblGestionPropietario_Nombre
            // 
            this.lblGestionPropietario_Nombre.AutoSize = true;
            this.lblGestionPropietario_Nombre.Location = new System.Drawing.Point(28, 28);
            this.lblGestionPropietario_Nombre.Name = "lblGestionPropietario_Nombre";
            this.lblGestionPropietario_Nombre.Size = new System.Drawing.Size(233, 24);
            this.lblGestionPropietario_Nombre.TabIndex = 0;
            this.lblGestionPropietario_Nombre.Text = "Nombre del propietario:";
            // 
            // dgvPropietarios
            // 
            this.dgvPropietarios.AllowUserToAddRows = false;
            this.dgvPropietarios.AllowUserToDeleteRows = false;
            this.dgvPropietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropietarios.Location = new System.Drawing.Point(40, 534);
            this.dgvPropietarios.Name = "dgvPropietarios";
            this.dgvPropietarios.ReadOnly = true;
            this.dgvPropietarios.RowHeadersWidth = 51;
            this.dgvPropietarios.RowTemplate.Height = 24;
            this.dgvPropietarios.Size = new System.Drawing.Size(864, 247);
            this.dgvPropietarios.TabIndex = 2;
            this.dgvPropietarios.DoubleClick += new System.EventHandler(this.dgvPropietarios_DoubleClick);
            // 
            // frmGestionPropietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 793);
            this.Controls.Add(this.dgvPropietarios);
            this.Controls.Add(this.pnlGestionPropietario);
            this.Controls.Add(this.lblGestionPropietarios);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGestionPropietarios";
            this.Text = "frmGestionPropietarios";
            this.Load += new System.EventHandler(this.frmGestionPropietarios_Load);
            this.pnlGestionPropietario.ResumeLayout(false);
            this.pnlGestionPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPropietarios;
        private System.Windows.Forms.Panel pnlGestionPropietario;
        private System.Windows.Forms.TextBox txtGestionPropietario_Email;
        private System.Windows.Forms.TextBox txtGestionPropietario_Direccion;
        private System.Windows.Forms.TextBox txtGestionPropietario_Telefono;
        private System.Windows.Forms.TextBox txtGestionPropietario_Nombre;
        private System.Windows.Forms.Label lblGestionPropietario_Email;
        private System.Windows.Forms.Label lblGestionPropietario_Direccion;
        private System.Windows.Forms.Label lblGestionPropietario_Telefono;
        private System.Windows.Forms.Label lblGestionPropietario_Nombre;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarInfoPropietario;
        private System.Windows.Forms.Button btnEliminarPropietario;
        private System.Windows.Forms.Button btnRegistrarPropietario;
        private System.Windows.Forms.DataGridView dgvPropietarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}
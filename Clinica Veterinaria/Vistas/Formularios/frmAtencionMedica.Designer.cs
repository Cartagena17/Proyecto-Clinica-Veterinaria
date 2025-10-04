namespace Vistas.Formularios
{
    partial class frmAtencionMedica
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
            this.lblConsultaMedica = new System.Windows.Forms.Label();
            this.pnlConsultaMedica = new System.Windows.Forms.Panel();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cmbAtencionMedica_Cita = new System.Windows.Forms.ComboBox();
            this.btnActualizarConsultaMedica = new System.Windows.Forms.Button();
            this.btnEliminarConsultaMedica = new System.Windows.Forms.Button();
            this.btnRegistrarConsultaMedica = new System.Windows.Forms.Button();
            this.dtpAtencionMedica_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txtAtencionMedica_Tratamiento = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Diagnostico = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Observaciones = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Sintomas = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Temperatura = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Peso = new System.Windows.Forms.TextBox();
            this.lblAtencionMedica_Temperatura = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Peso = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Observaciones = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Tratamiento = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Diagnostico = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Sintomas = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Fecha = new System.Windows.Forms.Label();
            this.lblAtencionMedica_CitaID = new System.Windows.Forms.Label();
            this.dgvConsultasMedicas = new System.Windows.Forms.DataGridView();
            this.pnlConsultaMedica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasMedicas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaMedica
            // 
            this.lblConsultaMedica.AutoSize = true;
            this.lblConsultaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.lblConsultaMedica.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaMedica.Location = new System.Drawing.Point(352, 21);
            this.lblConsultaMedica.Name = "lblConsultaMedica";
            this.lblConsultaMedica.Size = new System.Drawing.Size(259, 38);
            this.lblConsultaMedica.TabIndex = 0;
            this.lblConsultaMedica.Text = "Consulta Medica";
            // 
            // pnlConsultaMedica
            // 
            this.pnlConsultaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.pnlConsultaMedica.Controls.Add(this.btnLimpiarCampos);
            this.pnlConsultaMedica.Controls.Add(this.cmbAtencionMedica_Cita);
            this.pnlConsultaMedica.Controls.Add(this.btnActualizarConsultaMedica);
            this.pnlConsultaMedica.Controls.Add(this.btnEliminarConsultaMedica);
            this.pnlConsultaMedica.Controls.Add(this.btnRegistrarConsultaMedica);
            this.pnlConsultaMedica.Controls.Add(this.dtpAtencionMedica_Fecha);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Tratamiento);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Diagnostico);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Observaciones);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Sintomas);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Temperatura);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Peso);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Temperatura);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Peso);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Observaciones);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Tratamiento);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Diagnostico);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Sintomas);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Fecha);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_CitaID);
            this.pnlConsultaMedica.Location = new System.Drawing.Point(42, 51);
            this.pnlConsultaMedica.Name = "pnlConsultaMedica";
            this.pnlConsultaMedica.Size = new System.Drawing.Size(884, 339);
            this.pnlConsultaMedica.TabIndex = 1;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(258, 248);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(218, 53);
            this.btnLimpiarCampos.TabIndex = 25;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click_1);
            // 
            // cmbAtencionMedica_Cita
            // 
            this.cmbAtencionMedica_Cita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtencionMedica_Cita.FormattingEnabled = true;
            this.cmbAtencionMedica_Cita.Location = new System.Drawing.Point(181, 54);
            this.cmbAtencionMedica_Cita.Name = "cmbAtencionMedica_Cita";
            this.cmbAtencionMedica_Cita.Size = new System.Drawing.Size(279, 32);
            this.cmbAtencionMedica_Cita.TabIndex = 24;
            this.cmbAtencionMedica_Cita.SelectedIndexChanged += new System.EventHandler(this.cmbAtencionMedica_Cita_SelectedIndexChanged_1);
            // 
            // btnActualizarConsultaMedica
            // 
            this.btnActualizarConsultaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnActualizarConsultaMedica.FlatAppearance.BorderSize = 0;
            this.btnActualizarConsultaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarConsultaMedica.Location = new System.Drawing.Point(31, 247);
            this.btnActualizarConsultaMedica.Name = "btnActualizarConsultaMedica";
            this.btnActualizarConsultaMedica.Size = new System.Drawing.Size(218, 53);
            this.btnActualizarConsultaMedica.TabIndex = 23;
            this.btnActualizarConsultaMedica.Text = "Actualizar Consulta";
            this.btnActualizarConsultaMedica.UseVisualStyleBackColor = false;
            this.btnActualizarConsultaMedica.Click += new System.EventHandler(this.btnActualizarConsultaMedica_Click);
            // 
            // btnEliminarConsultaMedica
            // 
            this.btnEliminarConsultaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnEliminarConsultaMedica.FlatAppearance.BorderSize = 0;
            this.btnEliminarConsultaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConsultaMedica.Location = new System.Drawing.Point(258, 182);
            this.btnEliminarConsultaMedica.Name = "btnEliminarConsultaMedica";
            this.btnEliminarConsultaMedica.Size = new System.Drawing.Size(218, 53);
            this.btnEliminarConsultaMedica.TabIndex = 21;
            this.btnEliminarConsultaMedica.Text = "Eliminar Consulta";
            this.btnEliminarConsultaMedica.UseVisualStyleBackColor = false;
            this.btnEliminarConsultaMedica.Click += new System.EventHandler(this.btnEliminarConsultaMedica_Click);
            // 
            // btnRegistrarConsultaMedica
            // 
            this.btnRegistrarConsultaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnRegistrarConsultaMedica.FlatAppearance.BorderSize = 0;
            this.btnRegistrarConsultaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarConsultaMedica.Location = new System.Drawing.Point(31, 182);
            this.btnRegistrarConsultaMedica.Name = "btnRegistrarConsultaMedica";
            this.btnRegistrarConsultaMedica.Size = new System.Drawing.Size(218, 53);
            this.btnRegistrarConsultaMedica.TabIndex = 20;
            this.btnRegistrarConsultaMedica.Text = "Registrar Consulta Medica";
            this.btnRegistrarConsultaMedica.UseVisualStyleBackColor = false;
            this.btnRegistrarConsultaMedica.Click += new System.EventHandler(this.btnRegistrarConsultaMedica_Click);
            // 
            // dtpAtencionMedica_Fecha
            // 
            this.dtpAtencionMedica_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAtencionMedica_Fecha.Location = new System.Drawing.Point(258, 106);
            this.dtpAtencionMedica_Fecha.Name = "dtpAtencionMedica_Fecha";
            this.dtpAtencionMedica_Fecha.Size = new System.Drawing.Size(139, 32);
            this.dtpAtencionMedica_Fecha.TabIndex = 19;
            // 
            // txtAtencionMedica_Tratamiento
            // 
            this.txtAtencionMedica_Tratamiento.Location = new System.Drawing.Point(629, 269);
            this.txtAtencionMedica_Tratamiento.Name = "txtAtencionMedica_Tratamiento";
            this.txtAtencionMedica_Tratamiento.ShortcutsEnabled = false;
            this.txtAtencionMedica_Tratamiento.Size = new System.Drawing.Size(173, 32);
            this.txtAtencionMedica_Tratamiento.TabIndex = 18;
            // 
            // txtAtencionMedica_Diagnostico
            // 
            this.txtAtencionMedica_Diagnostico.Location = new System.Drawing.Point(629, 224);
            this.txtAtencionMedica_Diagnostico.Name = "txtAtencionMedica_Diagnostico";
            this.txtAtencionMedica_Diagnostico.ShortcutsEnabled = false;
            this.txtAtencionMedica_Diagnostico.Size = new System.Drawing.Size(173, 32);
            this.txtAtencionMedica_Diagnostico.TabIndex = 17;
            // 
            // txtAtencionMedica_Observaciones
            // 
            this.txtAtencionMedica_Observaciones.Location = new System.Drawing.Point(652, 183);
            this.txtAtencionMedica_Observaciones.Name = "txtAtencionMedica_Observaciones";
            this.txtAtencionMedica_Observaciones.ShortcutsEnabled = false;
            this.txtAtencionMedica_Observaciones.Size = new System.Drawing.Size(173, 32);
            this.txtAtencionMedica_Observaciones.TabIndex = 16;
            // 
            // txtAtencionMedica_Sintomas
            // 
            this.txtAtencionMedica_Sintomas.Location = new System.Drawing.Point(609, 135);
            this.txtAtencionMedica_Sintomas.Name = "txtAtencionMedica_Sintomas";
            this.txtAtencionMedica_Sintomas.ShortcutsEnabled = false;
            this.txtAtencionMedica_Sintomas.Size = new System.Drawing.Size(173, 32);
            this.txtAtencionMedica_Sintomas.TabIndex = 15;
            // 
            // txtAtencionMedica_Temperatura
            // 
            this.txtAtencionMedica_Temperatura.Location = new System.Drawing.Point(609, 92);
            this.txtAtencionMedica_Temperatura.Name = "txtAtencionMedica_Temperatura";
            this.txtAtencionMedica_Temperatura.ShortcutsEnabled = false;
            this.txtAtencionMedica_Temperatura.Size = new System.Drawing.Size(173, 32);
            this.txtAtencionMedica_Temperatura.TabIndex = 14;
            // 
            // txtAtencionMedica_Peso
            // 
            this.txtAtencionMedica_Peso.Location = new System.Drawing.Point(609, 49);
            this.txtAtencionMedica_Peso.Name = "txtAtencionMedica_Peso";
            this.txtAtencionMedica_Peso.ShortcutsEnabled = false;
            this.txtAtencionMedica_Peso.Size = new System.Drawing.Size(173, 32);
            this.txtAtencionMedica_Peso.TabIndex = 13;
            // 
            // lblAtencionMedica_Temperatura
            // 
            this.lblAtencionMedica_Temperatura.AutoSize = true;
            this.lblAtencionMedica_Temperatura.Location = new System.Drawing.Point(466, 94);
            this.lblAtencionMedica_Temperatura.Name = "lblAtencionMedica_Temperatura";
            this.lblAtencionMedica_Temperatura.Size = new System.Drawing.Size(135, 24);
            this.lblAtencionMedica_Temperatura.TabIndex = 9;
            this.lblAtencionMedica_Temperatura.Text = "Temperatura:";
            // 
            // lblAtencionMedica_Peso
            // 
            this.lblAtencionMedica_Peso.AutoSize = true;
            this.lblAtencionMedica_Peso.Location = new System.Drawing.Point(466, 56);
            this.lblAtencionMedica_Peso.Name = "lblAtencionMedica_Peso";
            this.lblAtencionMedica_Peso.Size = new System.Drawing.Size(120, 24);
            this.lblAtencionMedica_Peso.TabIndex = 8;
            this.lblAtencionMedica_Peso.Text = "Peso actual:";
            // 
            // lblAtencionMedica_Observaciones
            // 
            this.lblAtencionMedica_Observaciones.AutoSize = true;
            this.lblAtencionMedica_Observaciones.Location = new System.Drawing.Point(495, 186);
            this.lblAtencionMedica_Observaciones.Name = "lblAtencionMedica_Observaciones";
            this.lblAtencionMedica_Observaciones.Size = new System.Drawing.Size(151, 24);
            this.lblAtencionMedica_Observaciones.TabIndex = 7;
            this.lblAtencionMedica_Observaciones.Text = "Observaciones:";
            // 
            // lblAtencionMedica_Tratamiento
            // 
            this.lblAtencionMedica_Tratamiento.AutoSize = true;
            this.lblAtencionMedica_Tratamiento.Location = new System.Drawing.Point(495, 272);
            this.lblAtencionMedica_Tratamiento.Name = "lblAtencionMedica_Tratamiento";
            this.lblAtencionMedica_Tratamiento.Size = new System.Drawing.Size(128, 24);
            this.lblAtencionMedica_Tratamiento.TabIndex = 6;
            this.lblAtencionMedica_Tratamiento.Text = "Tratamiento:";
            // 
            // lblAtencionMedica_Diagnostico
            // 
            this.lblAtencionMedica_Diagnostico.AutoSize = true;
            this.lblAtencionMedica_Diagnostico.Location = new System.Drawing.Point(498, 227);
            this.lblAtencionMedica_Diagnostico.Name = "lblAtencionMedica_Diagnostico";
            this.lblAtencionMedica_Diagnostico.Size = new System.Drawing.Size(125, 24);
            this.lblAtencionMedica_Diagnostico.TabIndex = 5;
            this.lblAtencionMedica_Diagnostico.Text = "Diagnostico:";
            // 
            // lblAtencionMedica_Sintomas
            // 
            this.lblAtencionMedica_Sintomas.AutoSize = true;
            this.lblAtencionMedica_Sintomas.Location = new System.Drawing.Point(466, 137);
            this.lblAtencionMedica_Sintomas.Name = "lblAtencionMedica_Sintomas";
            this.lblAtencionMedica_Sintomas.Size = new System.Drawing.Size(100, 24);
            this.lblAtencionMedica_Sintomas.TabIndex = 4;
            this.lblAtencionMedica_Sintomas.Text = "Sintomas:";
            // 
            // lblAtencionMedica_Fecha
            // 
            this.lblAtencionMedica_Fecha.AutoSize = true;
            this.lblAtencionMedica_Fecha.Location = new System.Drawing.Point(78, 112);
            this.lblAtencionMedica_Fecha.Name = "lblAtencionMedica_Fecha";
            this.lblAtencionMedica_Fecha.Size = new System.Drawing.Size(155, 24);
            this.lblAtencionMedica_Fecha.TabIndex = 3;
            this.lblAtencionMedica_Fecha.Text = "Fecha Consulta:";
            // 
            // lblAtencionMedica_CitaID
            // 
            this.lblAtencionMedica_CitaID.AutoSize = true;
            this.lblAtencionMedica_CitaID.Location = new System.Drawing.Point(3, 54);
            this.lblAtencionMedica_CitaID.Name = "lblAtencionMedica_CitaID";
            this.lblAtencionMedica_CitaID.Size = new System.Drawing.Size(172, 24);
            this.lblAtencionMedica_CitaID.TabIndex = 2;
            this.lblAtencionMedica_CitaID.Text = "Selecciona la cita:";
            // 
            // dgvConsultasMedicas
            // 
            this.dgvConsultasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasMedicas.Location = new System.Drawing.Point(42, 407);
            this.dgvConsultasMedicas.Name = "dgvConsultasMedicas";
            this.dgvConsultasMedicas.RowHeadersWidth = 51;
            this.dgvConsultasMedicas.RowTemplate.Height = 24;
            this.dgvConsultasMedicas.Size = new System.Drawing.Size(1170, 222);
            this.dgvConsultasMedicas.TabIndex = 2;
            this.dgvConsultasMedicas.DoubleClick += new System.EventHandler(this.dgvConsultasMedicas_DoubleClick);
            // 
            // frmAtencionMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 676);
            this.Controls.Add(this.dgvConsultasMedicas);
            this.Controls.Add(this.pnlConsultaMedica);
            this.Controls.Add(this.lblConsultaMedica);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAtencionMedica";
            this.Text = "frmAtencionMedica";
            this.Load += new System.EventHandler(this.frmAtencionMedica_Load);
            this.pnlConsultaMedica.ResumeLayout(false);
            this.pnlConsultaMedica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasMedicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaMedica;
        private System.Windows.Forms.Panel pnlConsultaMedica;
        private System.Windows.Forms.Label lblAtencionMedica_Temperatura;
        private System.Windows.Forms.Label lblAtencionMedica_Peso;
        private System.Windows.Forms.Label lblAtencionMedica_Observaciones;
        private System.Windows.Forms.Label lblAtencionMedica_Tratamiento;
        private System.Windows.Forms.Label lblAtencionMedica_Diagnostico;
        private System.Windows.Forms.Label lblAtencionMedica_Sintomas;
        private System.Windows.Forms.Label lblAtencionMedica_Fecha;
        private System.Windows.Forms.Label lblAtencionMedica_CitaID;
        private System.Windows.Forms.DateTimePicker dtpAtencionMedica_Fecha;
        private System.Windows.Forms.TextBox txtAtencionMedica_Tratamiento;
        private System.Windows.Forms.TextBox txtAtencionMedica_Diagnostico;
        private System.Windows.Forms.TextBox txtAtencionMedica_Observaciones;
        private System.Windows.Forms.TextBox txtAtencionMedica_Sintomas;
        private System.Windows.Forms.TextBox txtAtencionMedica_Temperatura;
        private System.Windows.Forms.TextBox txtAtencionMedica_Peso;
        private System.Windows.Forms.Button btnRegistrarConsultaMedica;
        private System.Windows.Forms.DataGridView dgvConsultasMedicas;
        private System.Windows.Forms.Button btnActualizarConsultaMedica;
        private System.Windows.Forms.Button btnEliminarConsultaMedica;
        private System.Windows.Forms.ComboBox cmbAtencionMedica_Cita;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}
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
            this.btnRegistrarConsultaMedica = new System.Windows.Forms.Button();
            this.dtpAtencionMedica_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txtAtencionMedica_Tratamiento = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Diagnostico = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Observaciones = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Sintomas = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Temperatura = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_Peso = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_CitaID = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_NombrePers = new System.Windows.Forms.TextBox();
            this.txtAtencionMedica_NombrePac = new System.Windows.Forms.TextBox();
            this.lblAtencionMedica_Temperatura = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Peso = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Observaciones = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Tratamiento = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Diagnostico = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Sintomas = new System.Windows.Forms.Label();
            this.lblAtencionMedica_Fecha = new System.Windows.Forms.Label();
            this.lblAtencionMedica_CitaID = new System.Windows.Forms.Label();
            this.lblAtencionMedica_NombrePers = new System.Windows.Forms.Label();
            this.lblAtencionMedica_NombrePac = new System.Windows.Forms.Label();
            this.dgvConsultasMedicas = new System.Windows.Forms.DataGridView();
            this.pnlConsultaMedica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasMedicas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaMedica
            // 
            this.lblConsultaMedica.AutoSize = true;
            this.lblConsultaMedica.Location = new System.Drawing.Point(362, 32);
            this.lblConsultaMedica.Name = "lblConsultaMedica";
            this.lblConsultaMedica.Size = new System.Drawing.Size(107, 16);
            this.lblConsultaMedica.TabIndex = 0;
            this.lblConsultaMedica.Text = "Consulta Medica";
            // 
            // pnlConsultaMedica
            // 
            this.pnlConsultaMedica.Controls.Add(this.btnRegistrarConsultaMedica);
            this.pnlConsultaMedica.Controls.Add(this.dtpAtencionMedica_Fecha);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Tratamiento);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Diagnostico);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Observaciones);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Sintomas);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Temperatura);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_Peso);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_CitaID);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_NombrePers);
            this.pnlConsultaMedica.Controls.Add(this.txtAtencionMedica_NombrePac);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Temperatura);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Peso);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Observaciones);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Tratamiento);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Diagnostico);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Sintomas);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_Fecha);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_CitaID);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_NombrePers);
            this.pnlConsultaMedica.Controls.Add(this.lblAtencionMedica_NombrePac);
            this.pnlConsultaMedica.Location = new System.Drawing.Point(36, 67);
            this.pnlConsultaMedica.Name = "pnlConsultaMedica";
            this.pnlConsultaMedica.Size = new System.Drawing.Size(803, 322);
            this.pnlConsultaMedica.TabIndex = 1;
            // 
            // btnRegistrarConsultaMedica
            // 
            this.btnRegistrarConsultaMedica.Location = new System.Drawing.Point(62, 233);
            this.btnRegistrarConsultaMedica.Name = "btnRegistrarConsultaMedica";
            this.btnRegistrarConsultaMedica.Size = new System.Drawing.Size(134, 44);
            this.btnRegistrarConsultaMedica.TabIndex = 20;
            this.btnRegistrarConsultaMedica.Text = "Registrar Consulta Medica";
            this.btnRegistrarConsultaMedica.UseVisualStyleBackColor = true;
            this.btnRegistrarConsultaMedica.Click += new System.EventHandler(this.btnRegistrarConsultaMedica_Click);
            // 
            // dtpAtencionMedica_Fecha
            // 
            this.dtpAtencionMedica_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAtencionMedica_Fecha.Location = new System.Drawing.Point(178, 157);
            this.dtpAtencionMedica_Fecha.Name = "dtpAtencionMedica_Fecha";
            this.dtpAtencionMedica_Fecha.Size = new System.Drawing.Size(114, 22);
            this.dtpAtencionMedica_Fecha.TabIndex = 19;
            // 
            // txtAtencionMedica_Tratamiento
            // 
            this.txtAtencionMedica_Tratamiento.Location = new System.Drawing.Point(498, 233);
            this.txtAtencionMedica_Tratamiento.Name = "txtAtencionMedica_Tratamiento";
            this.txtAtencionMedica_Tratamiento.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_Tratamiento.TabIndex = 18;
            // 
            // txtAtencionMedica_Diagnostico
            // 
            this.txtAtencionMedica_Diagnostico.Location = new System.Drawing.Point(498, 192);
            this.txtAtencionMedica_Diagnostico.Name = "txtAtencionMedica_Diagnostico";
            this.txtAtencionMedica_Diagnostico.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_Diagnostico.TabIndex = 17;
            // 
            // txtAtencionMedica_Observaciones
            // 
            this.txtAtencionMedica_Observaciones.Location = new System.Drawing.Point(519, 157);
            this.txtAtencionMedica_Observaciones.Name = "txtAtencionMedica_Observaciones";
            this.txtAtencionMedica_Observaciones.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_Observaciones.TabIndex = 16;
            // 
            // txtAtencionMedica_Sintomas
            // 
            this.txtAtencionMedica_Sintomas.Location = new System.Drawing.Point(483, 112);
            this.txtAtencionMedica_Sintomas.Name = "txtAtencionMedica_Sintomas";
            this.txtAtencionMedica_Sintomas.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_Sintomas.TabIndex = 15;
            // 
            // txtAtencionMedica_Temperatura
            // 
            this.txtAtencionMedica_Temperatura.Location = new System.Drawing.Point(505, 81);
            this.txtAtencionMedica_Temperatura.Name = "txtAtencionMedica_Temperatura";
            this.txtAtencionMedica_Temperatura.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_Temperatura.TabIndex = 14;
            // 
            // txtAtencionMedica_Peso
            // 
            this.txtAtencionMedica_Peso.Location = new System.Drawing.Point(498, 47);
            this.txtAtencionMedica_Peso.Name = "txtAtencionMedica_Peso";
            this.txtAtencionMedica_Peso.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_Peso.TabIndex = 13;
            // 
            // txtAtencionMedica_CitaID
            // 
            this.txtAtencionMedica_CitaID.Location = new System.Drawing.Point(213, 119);
            this.txtAtencionMedica_CitaID.Name = "txtAtencionMedica_CitaID";
            this.txtAtencionMedica_CitaID.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_CitaID.TabIndex = 12;
            // 
            // txtAtencionMedica_NombrePers
            // 
            this.txtAtencionMedica_NombrePers.Location = new System.Drawing.Point(213, 82);
            this.txtAtencionMedica_NombrePers.Name = "txtAtencionMedica_NombrePers";
            this.txtAtencionMedica_NombrePers.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_NombrePers.TabIndex = 11;
            // 
            // txtAtencionMedica_NombrePac
            // 
            this.txtAtencionMedica_NombrePac.Location = new System.Drawing.Point(213, 47);
            this.txtAtencionMedica_NombrePac.Name = "txtAtencionMedica_NombrePac";
            this.txtAtencionMedica_NombrePac.Size = new System.Drawing.Size(100, 22);
            this.txtAtencionMedica_NombrePac.TabIndex = 10;
            this.txtAtencionMedica_NombrePac.TextChanged += new System.EventHandler(this.txtAtencionMedica_NombrePac_TextChanged);
            // 
            // lblAtencionMedica_Temperatura
            // 
            this.lblAtencionMedica_Temperatura.AutoSize = true;
            this.lblAtencionMedica_Temperatura.Location = new System.Drawing.Point(410, 82);
            this.lblAtencionMedica_Temperatura.Name = "lblAtencionMedica_Temperatura";
            this.lblAtencionMedica_Temperatura.Size = new System.Drawing.Size(88, 16);
            this.lblAtencionMedica_Temperatura.TabIndex = 9;
            this.lblAtencionMedica_Temperatura.Text = "Temperatura:";
            // 
            // lblAtencionMedica_Peso
            // 
            this.lblAtencionMedica_Peso.AutoSize = true;
            this.lblAtencionMedica_Peso.Location = new System.Drawing.Point(410, 47);
            this.lblAtencionMedica_Peso.Name = "lblAtencionMedica_Peso";
            this.lblAtencionMedica_Peso.Size = new System.Drawing.Size(81, 16);
            this.lblAtencionMedica_Peso.TabIndex = 8;
            this.lblAtencionMedica_Peso.Text = "Peso actual:";
            // 
            // lblAtencionMedica_Observaciones
            // 
            this.lblAtencionMedica_Observaciones.AutoSize = true;
            this.lblAtencionMedica_Observaciones.Location = new System.Drawing.Point(410, 157);
            this.lblAtencionMedica_Observaciones.Name = "lblAtencionMedica_Observaciones";
            this.lblAtencionMedica_Observaciones.Size = new System.Drawing.Size(102, 16);
            this.lblAtencionMedica_Observaciones.TabIndex = 7;
            this.lblAtencionMedica_Observaciones.Text = "Observaciones:";
            // 
            // lblAtencionMedica_Tratamiento
            // 
            this.lblAtencionMedica_Tratamiento.AutoSize = true;
            this.lblAtencionMedica_Tratamiento.Location = new System.Drawing.Point(416, 233);
            this.lblAtencionMedica_Tratamiento.Name = "lblAtencionMedica_Tratamiento";
            this.lblAtencionMedica_Tratamiento.Size = new System.Drawing.Size(82, 16);
            this.lblAtencionMedica_Tratamiento.TabIndex = 6;
            this.lblAtencionMedica_Tratamiento.Text = "Tratamiento:";
            // 
            // lblAtencionMedica_Diagnostico
            // 
            this.lblAtencionMedica_Diagnostico.AutoSize = true;
            this.lblAtencionMedica_Diagnostico.Location = new System.Drawing.Point(410, 192);
            this.lblAtencionMedica_Diagnostico.Name = "lblAtencionMedica_Diagnostico";
            this.lblAtencionMedica_Diagnostico.Size = new System.Drawing.Size(82, 16);
            this.lblAtencionMedica_Diagnostico.TabIndex = 5;
            this.lblAtencionMedica_Diagnostico.Text = "Diagnostico:";
            // 
            // lblAtencionMedica_Sintomas
            // 
            this.lblAtencionMedica_Sintomas.AutoSize = true;
            this.lblAtencionMedica_Sintomas.Location = new System.Drawing.Point(410, 119);
            this.lblAtencionMedica_Sintomas.Name = "lblAtencionMedica_Sintomas";
            this.lblAtencionMedica_Sintomas.Size = new System.Drawing.Size(66, 16);
            this.lblAtencionMedica_Sintomas.TabIndex = 4;
            this.lblAtencionMedica_Sintomas.Text = "Sintomas:";
            // 
            // lblAtencionMedica_Fecha
            // 
            this.lblAtencionMedica_Fecha.AutoSize = true;
            this.lblAtencionMedica_Fecha.Location = new System.Drawing.Point(69, 157);
            this.lblAtencionMedica_Fecha.Name = "lblAtencionMedica_Fecha";
            this.lblAtencionMedica_Fecha.Size = new System.Drawing.Size(103, 16);
            this.lblAtencionMedica_Fecha.TabIndex = 3;
            this.lblAtencionMedica_Fecha.Text = "Fecha Consulta:";
            // 
            // lblAtencionMedica_CitaID
            // 
            this.lblAtencionMedica_CitaID.AutoSize = true;
            this.lblAtencionMedica_CitaID.Location = new System.Drawing.Point(69, 119);
            this.lblAtencionMedica_CitaID.Name = "lblAtencionMedica_CitaID";
            this.lblAtencionMedica_CitaID.Size = new System.Drawing.Size(113, 16);
            this.lblAtencionMedica_CitaID.TabIndex = 2;
            this.lblAtencionMedica_CitaID.Text = "Codigo de la Cita:";
            // 
            // lblAtencionMedica_NombrePers
            // 
            this.lblAtencionMedica_NombrePers.AutoSize = true;
            this.lblAtencionMedica_NombrePers.Location = new System.Drawing.Point(69, 82);
            this.lblAtencionMedica_NombrePers.Name = "lblAtencionMedica_NombrePers";
            this.lblAtencionMedica_NombrePers.Size = new System.Drawing.Size(144, 16);
            this.lblAtencionMedica_NombrePers.TabIndex = 1;
            this.lblAtencionMedica_NombrePers.Text = "Codigo del Veterinario:";
            // 
            // lblAtencionMedica_NombrePac
            // 
            this.lblAtencionMedica_NombrePac.AutoSize = true;
            this.lblAtencionMedica_NombrePac.Location = new System.Drawing.Point(69, 47);
            this.lblAtencionMedica_NombrePac.Name = "lblAtencionMedica_NombrePac";
            this.lblAtencionMedica_NombrePac.Size = new System.Drawing.Size(129, 16);
            this.lblAtencionMedica_NombrePac.TabIndex = 0;
            this.lblAtencionMedica_NombrePac.Text = "Codigo del Paciente";
            this.lblAtencionMedica_NombrePac.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvConsultasMedicas
            // 
            this.dgvConsultasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasMedicas.Location = new System.Drawing.Point(36, 395);
            this.dgvConsultasMedicas.Name = "dgvConsultasMedicas";
            this.dgvConsultasMedicas.RowHeadersWidth = 51;
            this.dgvConsultasMedicas.RowTemplate.Height = 24;
            this.dgvConsultasMedicas.Size = new System.Drawing.Size(1109, 338);
            this.dgvConsultasMedicas.TabIndex = 2;
            // 
            // frmAtencionMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 756);
            this.Controls.Add(this.dgvConsultasMedicas);
            this.Controls.Add(this.pnlConsultaMedica);
            this.Controls.Add(this.lblConsultaMedica);
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
        private System.Windows.Forms.Label lblAtencionMedica_NombrePers;
        private System.Windows.Forms.Label lblAtencionMedica_NombrePac;
        private System.Windows.Forms.DateTimePicker dtpAtencionMedica_Fecha;
        private System.Windows.Forms.TextBox txtAtencionMedica_Tratamiento;
        private System.Windows.Forms.TextBox txtAtencionMedica_Diagnostico;
        private System.Windows.Forms.TextBox txtAtencionMedica_Observaciones;
        private System.Windows.Forms.TextBox txtAtencionMedica_Sintomas;
        private System.Windows.Forms.TextBox txtAtencionMedica_Temperatura;
        private System.Windows.Forms.TextBox txtAtencionMedica_Peso;
        private System.Windows.Forms.TextBox txtAtencionMedica_CitaID;
        private System.Windows.Forms.TextBox txtAtencionMedica_NombrePers;
        private System.Windows.Forms.TextBox txtAtencionMedica_NombrePac;
        private System.Windows.Forms.Button btnRegistrarConsultaMedica;
        private System.Windows.Forms.DataGridView dgvConsultasMedicas;
    }
}
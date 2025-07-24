namespace Vistas.Formularios
{
    partial class frmAgendarCita
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
            this.lblAgendarCitas = new System.Windows.Forms.Label();
            this.pnlAgendarCitas = new System.Windows.Forms.Panel();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.txtAgendarCita_Motivo = new System.Windows.Forms.TextBox();
            this.txtAgendarCita_Hora = new System.Windows.Forms.TextBox();
            this.dtpAgendarCita_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txtAgendarCita_Veterinario = new System.Windows.Forms.TextBox();
            this.txtAgendarCita_Paciente = new System.Windows.Forms.TextBox();
            this.txtAgendarCita_Propietario = new System.Windows.Forms.TextBox();
            this.lblAgendarCita_Hora = new System.Windows.Forms.Label();
            this.lblAgendarCita_Fecha = new System.Windows.Forms.Label();
            this.lblAgendarCita_Motivo = new System.Windows.Forms.Label();
            this.lblAgendarCita_Propietario = new System.Windows.Forms.Label();
            this.lblAgendarCita_Paciente = new System.Windows.Forms.Label();
            this.lblAgendarCita_Veterinario = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.pnlAgendarCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgendarCitas
            // 
            this.lblAgendarCitas.AutoSize = true;
            this.lblAgendarCitas.Location = new System.Drawing.Point(315, 29);
            this.lblAgendarCitas.Name = "lblAgendarCitas";
            this.lblAgendarCitas.Size = new System.Drawing.Size(95, 16);
            this.lblAgendarCitas.TabIndex = 0;
            this.lblAgendarCitas.Text = " Agendar Citas";
            this.lblAgendarCitas.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlAgendarCitas
            // 
            this.pnlAgendarCitas.Controls.Add(this.btnAgendarCita);
            this.pnlAgendarCitas.Controls.Add(this.txtAgendarCita_Motivo);
            this.pnlAgendarCitas.Controls.Add(this.txtAgendarCita_Hora);
            this.pnlAgendarCitas.Controls.Add(this.dtpAgendarCita_Fecha);
            this.pnlAgendarCitas.Controls.Add(this.txtAgendarCita_Veterinario);
            this.pnlAgendarCitas.Controls.Add(this.txtAgendarCita_Paciente);
            this.pnlAgendarCitas.Controls.Add(this.txtAgendarCita_Propietario);
            this.pnlAgendarCitas.Controls.Add(this.lblAgendarCita_Hora);
            this.pnlAgendarCitas.Controls.Add(this.lblAgendarCita_Fecha);
            this.pnlAgendarCitas.Controls.Add(this.lblAgendarCita_Motivo);
            this.pnlAgendarCitas.Controls.Add(this.lblAgendarCita_Propietario);
            this.pnlAgendarCitas.Controls.Add(this.lblAgendarCita_Paciente);
            this.pnlAgendarCitas.Controls.Add(this.lblAgendarCita_Veterinario);
            this.pnlAgendarCitas.Location = new System.Drawing.Point(155, 71);
            this.pnlAgendarCitas.Name = "pnlAgendarCitas";
            this.pnlAgendarCitas.Size = new System.Drawing.Size(382, 297);
            this.pnlAgendarCitas.TabIndex = 1;
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(105, 231);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(147, 44);
            this.btnAgendarCita.TabIndex = 25;
            this.btnAgendarCita.Text = "Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // txtAgendarCita_Motivo
            // 
            this.txtAgendarCita_Motivo.Location = new System.Drawing.Point(158, 163);
            this.txtAgendarCita_Motivo.Multiline = true;
            this.txtAgendarCita_Motivo.Name = "txtAgendarCita_Motivo";
            this.txtAgendarCita_Motivo.Size = new System.Drawing.Size(174, 22);
            this.txtAgendarCita_Motivo.TabIndex = 24;
            // 
            // txtAgendarCita_Hora
            // 
            this.txtAgendarCita_Hora.Location = new System.Drawing.Point(158, 134);
            this.txtAgendarCita_Hora.Name = "txtAgendarCita_Hora";
            this.txtAgendarCita_Hora.Size = new System.Drawing.Size(174, 22);
            this.txtAgendarCita_Hora.TabIndex = 23;
            // 
            // dtpAgendarCita_Fecha
            // 
            this.dtpAgendarCita_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAgendarCita_Fecha.Location = new System.Drawing.Point(158, 109);
            this.dtpAgendarCita_Fecha.Name = "dtpAgendarCita_Fecha";
            this.dtpAgendarCita_Fecha.Size = new System.Drawing.Size(200, 22);
            this.dtpAgendarCita_Fecha.TabIndex = 22;
            // 
            // txtAgendarCita_Veterinario
            // 
            this.txtAgendarCita_Veterinario.Location = new System.Drawing.Point(158, 80);
            this.txtAgendarCita_Veterinario.Name = "txtAgendarCita_Veterinario";
            this.txtAgendarCita_Veterinario.Size = new System.Drawing.Size(174, 22);
            this.txtAgendarCita_Veterinario.TabIndex = 21;
            // 
            // txtAgendarCita_Paciente
            // 
            this.txtAgendarCita_Paciente.Location = new System.Drawing.Point(158, 52);
            this.txtAgendarCita_Paciente.Name = "txtAgendarCita_Paciente";
            this.txtAgendarCita_Paciente.Size = new System.Drawing.Size(174, 22);
            this.txtAgendarCita_Paciente.TabIndex = 20;
            // 
            // txtAgendarCita_Propietario
            // 
            this.txtAgendarCita_Propietario.Location = new System.Drawing.Point(158, 23);
            this.txtAgendarCita_Propietario.Name = "txtAgendarCita_Propietario";
            this.txtAgendarCita_Propietario.Size = new System.Drawing.Size(174, 22);
            this.txtAgendarCita_Propietario.TabIndex = 19;
            // 
            // lblAgendarCita_Hora
            // 
            this.lblAgendarCita_Hora.AutoSize = true;
            this.lblAgendarCita_Hora.Location = new System.Drawing.Point(1, 134);
            this.lblAgendarCita_Hora.Name = "lblAgendarCita_Hora";
            this.lblAgendarCita_Hora.Size = new System.Drawing.Size(99, 16);
            this.lblAgendarCita_Hora.TabIndex = 18;
            this.lblAgendarCita_Hora.Text = "Hora de la Cita:";
            // 
            // lblAgendarCita_Fecha
            // 
            this.lblAgendarCita_Fecha.AutoSize = true;
            this.lblAgendarCita_Fecha.Location = new System.Drawing.Point(1, 108);
            this.lblAgendarCita_Fecha.Name = "lblAgendarCita_Fecha";
            this.lblAgendarCita_Fecha.Size = new System.Drawing.Size(107, 16);
            this.lblAgendarCita_Fecha.TabIndex = 17;
            this.lblAgendarCita_Fecha.Text = "Fecha de la Cita:";
            // 
            // lblAgendarCita_Motivo
            // 
            this.lblAgendarCita_Motivo.AutoSize = true;
            this.lblAgendarCita_Motivo.Location = new System.Drawing.Point(1, 163);
            this.lblAgendarCita_Motivo.Name = "lblAgendarCita_Motivo";
            this.lblAgendarCita_Motivo.Size = new System.Drawing.Size(47, 16);
            this.lblAgendarCita_Motivo.TabIndex = 16;
            this.lblAgendarCita_Motivo.Text = "Motivo";
            // 
            // lblAgendarCita_Propietario
            // 
            this.lblAgendarCita_Propietario.AutoSize = true;
            this.lblAgendarCita_Propietario.Location = new System.Drawing.Point(1, 23);
            this.lblAgendarCita_Propietario.Name = "lblAgendarCita_Propietario";
            this.lblAgendarCita_Propietario.Size = new System.Drawing.Size(150, 16);
            this.lblAgendarCita_Propietario.TabIndex = 15;
            this.lblAgendarCita_Propietario.Text = "Nombre del Propietario:";
            // 
            // lblAgendarCita_Paciente
            // 
            this.lblAgendarCita_Paciente.AutoSize = true;
            this.lblAgendarCita_Paciente.Location = new System.Drawing.Point(1, 52);
            this.lblAgendarCita_Paciente.Name = "lblAgendarCita_Paciente";
            this.lblAgendarCita_Paciente.Size = new System.Drawing.Size(137, 16);
            this.lblAgendarCita_Paciente.TabIndex = 14;
            this.lblAgendarCita_Paciente.Text = "Nombre del Paciente:";
            // 
            // lblAgendarCita_Veterinario
            // 
            this.lblAgendarCita_Veterinario.AutoSize = true;
            this.lblAgendarCita_Veterinario.Location = new System.Drawing.Point(1, 80);
            this.lblAgendarCita_Veterinario.Name = "lblAgendarCita_Veterinario";
            this.lblAgendarCita_Veterinario.Size = new System.Drawing.Size(146, 16);
            this.lblAgendarCita_Veterinario.TabIndex = 13;
            this.lblAgendarCita_Veterinario.Text = "Nombre del Veterinario";
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(132, 397);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.Size = new System.Drawing.Size(650, 203);
            this.dgvCitas.TabIndex = 2;
            // 
            // frmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 583);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.pnlAgendarCitas);
            this.Controls.Add(this.lblAgendarCitas);
            this.Name = "frmAgendarCita";
            this.Text = "frmAgendarCita";
            this.Load += new System.EventHandler(this.frmAgendarCita_Load);
            this.pnlAgendarCitas.ResumeLayout(false);
            this.pnlAgendarCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgendarCitas;
        private System.Windows.Forms.Panel pnlAgendarCitas;
        private System.Windows.Forms.TextBox txtAgendarCita_Motivo;
        private System.Windows.Forms.TextBox txtAgendarCita_Hora;
        private System.Windows.Forms.DateTimePicker dtpAgendarCita_Fecha;
        private System.Windows.Forms.TextBox txtAgendarCita_Veterinario;
        private System.Windows.Forms.TextBox txtAgendarCita_Paciente;
        private System.Windows.Forms.TextBox txtAgendarCita_Propietario;
        private System.Windows.Forms.Label lblAgendarCita_Hora;
        private System.Windows.Forms.Label lblAgendarCita_Fecha;
        private System.Windows.Forms.Label lblAgendarCita_Motivo;
        private System.Windows.Forms.Label lblAgendarCita_Propietario;
        private System.Windows.Forms.Label lblAgendarCita_Paciente;
        private System.Windows.Forms.Label lblAgendarCita_Veterinario;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.DataGridView dgvCitas;
    }
}
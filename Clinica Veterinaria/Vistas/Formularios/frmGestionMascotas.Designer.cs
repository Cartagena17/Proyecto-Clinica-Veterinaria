namespace Vistas.Formularios
{
    partial class frmGestionMascotas
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
            this.pnlGestionMascota = new System.Windows.Forms.Panel();
            this.btnVerMascotas = new System.Windows.Forms.Button();
            this.btnActualizarInfoMascota = new System.Windows.Forms.Button();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.txtGestionMascota_Color = new System.Windows.Forms.TextBox();
            this.txtGestionMascota_Sexo = new System.Windows.Forms.TextBox();
            this.txtGestionMascota_Peso = new System.Windows.Forms.TextBox();
            this.txtGestionMascota_Raza = new System.Windows.Forms.TextBox();
            this.txtGestionMascota_Especie = new System.Windows.Forms.TextBox();
            this.txtGestionMascota_Prop = new System.Windows.Forms.TextBox();
            this.txtGestionMascota_Nombre = new System.Windows.Forms.TextBox();
            this.dtpGestionMascota_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblGestionMascota_Color = new System.Windows.Forms.Label();
            this.lblGestionMascota_Sexo = new System.Windows.Forms.Label();
            this.lblGestionMascota_Peso = new System.Windows.Forms.Label();
            this.lblGestionMascota_Nacimiento = new System.Windows.Forms.Label();
            this.lblGestionMascota_Raza = new System.Windows.Forms.Label();
            this.lblGestionMascotas_Especie = new System.Windows.Forms.Label();
            this.lblGestionMascotas_NombreProp = new System.Windows.Forms.Label();
            this.lblGestionMascotas_Nombre = new System.Windows.Forms.Label();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.pnlGestionMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPropietarios
            // 
            this.lblGestionPropietarios.AutoSize = true;
            this.lblGestionPropietarios.Location = new System.Drawing.Point(310, 27);
            this.lblGestionPropietarios.Name = "lblGestionPropietarios";
            this.lblGestionPropietarios.Size = new System.Drawing.Size(127, 16);
            this.lblGestionPropietarios.TabIndex = 0;
            this.lblGestionPropietarios.Text = "Gestionar Mascotas";
            // 
            // pnlGestionMascota
            // 
            this.pnlGestionMascota.Controls.Add(this.btnVerMascotas);
            this.pnlGestionMascota.Controls.Add(this.btnActualizarInfoMascota);
            this.pnlGestionMascota.Controls.Add(this.btnEliminarMascota);
            this.pnlGestionMascota.Controls.Add(this.btnRegistrarMascota);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Color);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Sexo);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Peso);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Raza);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Especie);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Prop);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Nombre);
            this.pnlGestionMascota.Controls.Add(this.dtpGestionMascota_Nacimiento);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Color);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Sexo);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Peso);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Nacimiento);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Raza);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascotas_Especie);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascotas_NombreProp);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascotas_Nombre);
            this.pnlGestionMascota.Location = new System.Drawing.Point(43, 100);
            this.pnlGestionMascota.Name = "pnlGestionMascota";
            this.pnlGestionMascota.Size = new System.Drawing.Size(723, 316);
            this.pnlGestionMascota.TabIndex = 9;
            // 
            // btnVerMascotas
            // 
            this.btnVerMascotas.Location = new System.Drawing.Point(491, 267);
            this.btnVerMascotas.Name = "btnVerMascotas";
            this.btnVerMascotas.Size = new System.Drawing.Size(75, 23);
            this.btnVerMascotas.TabIndex = 19;
            this.btnVerMascotas.Text = "Ver Mascotas";
            this.btnVerMascotas.UseVisualStyleBackColor = true;
            // 
            // btnActualizarInfoMascota
            // 
            this.btnActualizarInfoMascota.Location = new System.Drawing.Point(340, 254);
            this.btnActualizarInfoMascota.Name = "btnActualizarInfoMascota";
            this.btnActualizarInfoMascota.Size = new System.Drawing.Size(96, 46);
            this.btnActualizarInfoMascota.TabIndex = 18;
            this.btnActualizarInfoMascota.Text = "Actualizar Informacion";
            this.btnActualizarInfoMascota.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.Location = new System.Drawing.Point(193, 254);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(91, 46);
            this.btnEliminarMascota.TabIndex = 17;
            this.btnEliminarMascota.Text = "Eliminar Mascota";
            this.btnEliminarMascota.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.Location = new System.Drawing.Point(35, 254);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(100, 46);
            this.btnRegistrarMascota.TabIndex = 16;
            this.btnRegistrarMascota.Text = "Registrar Mascota";
            this.btnRegistrarMascota.UseVisualStyleBackColor = true;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // txtGestionMascota_Color
            // 
            this.txtGestionMascota_Color.Location = new System.Drawing.Point(491, 187);
            this.txtGestionMascota_Color.Name = "txtGestionMascota_Color";
            this.txtGestionMascota_Color.Size = new System.Drawing.Size(163, 22);
            this.txtGestionMascota_Color.TabIndex = 15;
            // 
            // txtGestionMascota_Sexo
            // 
            this.txtGestionMascota_Sexo.Location = new System.Drawing.Point(491, 129);
            this.txtGestionMascota_Sexo.Name = "txtGestionMascota_Sexo";
            this.txtGestionMascota_Sexo.Size = new System.Drawing.Size(163, 22);
            this.txtGestionMascota_Sexo.TabIndex = 14;
            // 
            // txtGestionMascota_Peso
            // 
            this.txtGestionMascota_Peso.Location = new System.Drawing.Point(491, 71);
            this.txtGestionMascota_Peso.Name = "txtGestionMascota_Peso";
            this.txtGestionMascota_Peso.Size = new System.Drawing.Size(163, 22);
            this.txtGestionMascota_Peso.TabIndex = 13;
            // 
            // txtGestionMascota_Raza
            // 
            this.txtGestionMascota_Raza.Location = new System.Drawing.Point(138, 180);
            this.txtGestionMascota_Raza.Name = "txtGestionMascota_Raza";
            this.txtGestionMascota_Raza.Size = new System.Drawing.Size(175, 22);
            this.txtGestionMascota_Raza.TabIndex = 12;
            // 
            // txtGestionMascota_Especie
            // 
            this.txtGestionMascota_Especie.Location = new System.Drawing.Point(138, 122);
            this.txtGestionMascota_Especie.Name = "txtGestionMascota_Especie";
            this.txtGestionMascota_Especie.Size = new System.Drawing.Size(175, 22);
            this.txtGestionMascota_Especie.TabIndex = 11;
            // 
            // txtGestionMascota_Prop
            // 
            this.txtGestionMascota_Prop.Location = new System.Drawing.Point(138, 64);
            this.txtGestionMascota_Prop.Name = "txtGestionMascota_Prop";
            this.txtGestionMascota_Prop.Size = new System.Drawing.Size(175, 22);
            this.txtGestionMascota_Prop.TabIndex = 10;
            // 
            // txtGestionMascota_Nombre
            // 
            this.txtGestionMascota_Nombre.Location = new System.Drawing.Point(138, 19);
            this.txtGestionMascota_Nombre.Name = "txtGestionMascota_Nombre";
            this.txtGestionMascota_Nombre.Size = new System.Drawing.Size(175, 22);
            this.txtGestionMascota_Nombre.TabIndex = 9;
            // 
            // dtpGestionMascota_Nacimiento
            // 
            this.dtpGestionMascota_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGestionMascota_Nacimiento.Location = new System.Drawing.Point(491, 21);
            this.dtpGestionMascota_Nacimiento.Name = "dtpGestionMascota_Nacimiento";
            this.dtpGestionMascota_Nacimiento.Size = new System.Drawing.Size(110, 22);
            this.dtpGestionMascota_Nacimiento.TabIndex = 8;
            // 
            // lblGestionMascota_Color
            // 
            this.lblGestionMascota_Color.AutoSize = true;
            this.lblGestionMascota_Color.Location = new System.Drawing.Point(443, 190);
            this.lblGestionMascota_Color.Name = "lblGestionMascota_Color";
            this.lblGestionMascota_Color.Size = new System.Drawing.Size(42, 16);
            this.lblGestionMascota_Color.TabIndex = 7;
            this.lblGestionMascota_Color.Text = "Color:";
            // 
            // lblGestionMascota_Sexo
            // 
            this.lblGestionMascota_Sexo.AutoSize = true;
            this.lblGestionMascota_Sexo.Location = new System.Drawing.Point(443, 132);
            this.lblGestionMascota_Sexo.Name = "lblGestionMascota_Sexo";
            this.lblGestionMascota_Sexo.Size = new System.Drawing.Size(41, 16);
            this.lblGestionMascota_Sexo.TabIndex = 6;
            this.lblGestionMascota_Sexo.Text = "Sexo:";
            // 
            // lblGestionMascota_Peso
            // 
            this.lblGestionMascota_Peso.AutoSize = true;
            this.lblGestionMascota_Peso.Location = new System.Drawing.Point(443, 77);
            this.lblGestionMascota_Peso.Name = "lblGestionMascota_Peso";
            this.lblGestionMascota_Peso.Size = new System.Drawing.Size(42, 16);
            this.lblGestionMascota_Peso.TabIndex = 5;
            this.lblGestionMascota_Peso.Text = "Peso:";
            // 
            // lblGestionMascota_Nacimiento
            // 
            this.lblGestionMascota_Nacimiento.AutoSize = true;
            this.lblGestionMascota_Nacimiento.Location = new System.Drawing.Point(407, 25);
            this.lblGestionMascota_Nacimiento.Name = "lblGestionMascota_Nacimiento";
            this.lblGestionMascota_Nacimiento.Size = new System.Drawing.Size(78, 16);
            this.lblGestionMascota_Nacimiento.TabIndex = 4;
            this.lblGestionMascota_Nacimiento.Text = "Nacimiento:";
            // 
            // lblGestionMascota_Raza
            // 
            this.lblGestionMascota_Raza.AutoSize = true;
            this.lblGestionMascota_Raza.Location = new System.Drawing.Point(87, 187);
            this.lblGestionMascota_Raza.Name = "lblGestionMascota_Raza";
            this.lblGestionMascota_Raza.Size = new System.Drawing.Size(42, 16);
            this.lblGestionMascota_Raza.TabIndex = 3;
            this.lblGestionMascota_Raza.Text = "Raza:";
            // 
            // lblGestionMascotas_Especie
            // 
            this.lblGestionMascotas_Especie.AutoSize = true;
            this.lblGestionMascotas_Especie.Location = new System.Drawing.Point(71, 129);
            this.lblGestionMascotas_Especie.Name = "lblGestionMascotas_Especie";
            this.lblGestionMascotas_Especie.Size = new System.Drawing.Size(60, 16);
            this.lblGestionMascotas_Especie.TabIndex = 2;
            this.lblGestionMascotas_Especie.Text = "Especie:";
            // 
            // lblGestionMascotas_NombreProp
            // 
            this.lblGestionMascotas_NombreProp.AutoSize = true;
            this.lblGestionMascotas_NombreProp.Location = new System.Drawing.Point(7, 67);
            this.lblGestionMascotas_NombreProp.Name = "lblGestionMascotas_NombreProp";
            this.lblGestionMascotas_NombreProp.Size = new System.Drawing.Size(128, 16);
            this.lblGestionMascotas_NombreProp.TabIndex = 1;
            this.lblGestionMascotas_NombreProp.Text = "Nombre Propietario:";
            this.lblGestionMascotas_NombreProp.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGestionMascotas_Nombre
            // 
            this.lblGestionMascotas_Nombre.AutoSize = true;
            this.lblGestionMascotas_Nombre.Location = new System.Drawing.Point(18, 21);
            this.lblGestionMascotas_Nombre.Name = "lblGestionMascotas_Nombre";
            this.lblGestionMascotas_Nombre.Size = new System.Drawing.Size(114, 16);
            this.lblGestionMascotas_Nombre.TabIndex = 0;
            this.lblGestionMascotas_Nombre.Text = "Nombre Mascota:";
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(43, 423);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 24;
            this.dgvMascotas.Size = new System.Drawing.Size(987, 324);
            this.dgvMascotas.TabIndex = 10;
            // 
            // frmGestionMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 759);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.lblGestionPropietarios);
            this.Controls.Add(this.pnlGestionMascota);
            this.Name = "frmGestionMascotas";
            this.Text = "frmGestionMascotas";
            this.Load += new System.EventHandler(this.frmGestionMascotas_Load);
            this.pnlGestionMascota.ResumeLayout(false);
            this.pnlGestionMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPropietarios;
        private System.Windows.Forms.Panel pnlGestionMascota;
        private System.Windows.Forms.TextBox txtGestionMascota_Color;
        private System.Windows.Forms.TextBox txtGestionMascota_Sexo;
        private System.Windows.Forms.TextBox txtGestionMascota_Peso;
        private System.Windows.Forms.TextBox txtGestionMascota_Raza;
        private System.Windows.Forms.TextBox txtGestionMascota_Especie;
        private System.Windows.Forms.TextBox txtGestionMascota_Prop;
        private System.Windows.Forms.TextBox txtGestionMascota_Nombre;
        private System.Windows.Forms.DateTimePicker dtpGestionMascota_Nacimiento;
        private System.Windows.Forms.Label lblGestionMascota_Color;
        private System.Windows.Forms.Label lblGestionMascota_Sexo;
        private System.Windows.Forms.Label lblGestionMascota_Peso;
        private System.Windows.Forms.Label lblGestionMascota_Nacimiento;
        private System.Windows.Forms.Label lblGestionMascota_Raza;
        private System.Windows.Forms.Label lblGestionMascotas_Especie;
        private System.Windows.Forms.Label lblGestionMascotas_NombreProp;
        private System.Windows.Forms.Label lblGestionMascotas_Nombre;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.Button btnActualizarInfoMascota;
        private System.Windows.Forms.Button btnVerMascotas;
        private System.Windows.Forms.DataGridView dgvMascotas;
    }
}
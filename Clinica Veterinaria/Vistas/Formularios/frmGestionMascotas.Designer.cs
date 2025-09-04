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
            this.txtGestionMascota_Nombre = new System.Windows.Forms.TextBox();
            this.dtpGestionMascota_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblGestionMascota_Color = new System.Windows.Forms.Label();
            this.lblGestionMascota_Sexo = new System.Windows.Forms.Label();
            this.lblGestionMascota_Peso = new System.Windows.Forms.Label();
            this.lblGestionMascota_Nacimiento = new System.Windows.Forms.Label();
            this.lblGestionMascota_Raza = new System.Windows.Forms.Label();
            this.lblGestionMascotas_Especie = new System.Windows.Forms.Label();
            this.lblGestionMascotas_Nombre = new System.Windows.Forms.Label();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.pnlGestionMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPropietarios
            // 
            this.lblGestionPropietarios.AutoSize = true;
            this.lblGestionPropietarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.lblGestionPropietarios.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPropietarios.Location = new System.Drawing.Point(412, 55);
            this.lblGestionPropietarios.Name = "lblGestionPropietarios";
            this.lblGestionPropietarios.Size = new System.Drawing.Size(331, 44);
            this.lblGestionPropietarios.TabIndex = 0;
            this.lblGestionPropietarios.Text = "Gestionar Mascotas";
            // 
            // pnlGestionMascota
            // 
            this.pnlGestionMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.pnlGestionMascota.Controls.Add(this.btnVerMascotas);
            this.pnlGestionMascota.Controls.Add(this.btnActualizarInfoMascota);
            this.pnlGestionMascota.Controls.Add(this.btnEliminarMascota);
            this.pnlGestionMascota.Controls.Add(this.btnRegistrarMascota);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Color);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Sexo);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Peso);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Raza);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Especie);
            this.pnlGestionMascota.Controls.Add(this.txtGestionMascota_Nombre);
            this.pnlGestionMascota.Controls.Add(this.dtpGestionMascota_Nacimiento);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Color);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Sexo);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Peso);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Nacimiento);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascota_Raza);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascotas_Especie);
            this.pnlGestionMascota.Controls.Add(this.lblGestionMascotas_Nombre);
            this.pnlGestionMascota.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGestionMascota.Location = new System.Drawing.Point(55, 83);
            this.pnlGestionMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGestionMascota.Name = "pnlGestionMascota";
            this.pnlGestionMascota.Size = new System.Drawing.Size(976, 364);
            this.pnlGestionMascota.TabIndex = 9;
            // 
            // btnVerMascotas
            // 
            this.btnVerMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnVerMascotas.FlatAppearance.BorderSize = 0;
            this.btnVerMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMascotas.Location = new System.Drawing.Point(447, 266);
            this.btnVerMascotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerMascotas.Name = "btnVerMascotas";
            this.btnVerMascotas.Size = new System.Drawing.Size(103, 60);
            this.btnVerMascotas.TabIndex = 19;
            this.btnVerMascotas.Text = "Ver Mascotas";
            this.btnVerMascotas.UseVisualStyleBackColor = false;
            // 
            // btnActualizarInfoMascota
            // 
            this.btnActualizarInfoMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnActualizarInfoMascota.FlatAppearance.BorderSize = 0;
            this.btnActualizarInfoMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInfoMascota.Location = new System.Drawing.Point(327, 266);
            this.btnActualizarInfoMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizarInfoMascota.Name = "btnActualizarInfoMascota";
            this.btnActualizarInfoMascota.Size = new System.Drawing.Size(123, 60);
            this.btnActualizarInfoMascota.TabIndex = 18;
            this.btnActualizarInfoMascota.Text = "Actualizar Informacion";
            this.btnActualizarInfoMascota.UseVisualStyleBackColor = false;
            this.btnActualizarInfoMascota.Click += new System.EventHandler(this.btnActualizarInfoMascota_Click);
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnEliminarMascota.FlatAppearance.BorderSize = 0;
            this.btnEliminarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMascota.Location = new System.Drawing.Point(214, 266);
            this.btnEliminarMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(117, 60);
            this.btnEliminarMascota.TabIndex = 17;
            this.btnEliminarMascota.Text = "Eliminar Mascota";
            this.btnEliminarMascota.UseVisualStyleBackColor = false;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnRegistrarMascota.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMascota.Location = new System.Drawing.Point(88, 266);
            this.btnRegistrarMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(129, 60);
            this.btnRegistrarMascota.TabIndex = 16;
            this.btnRegistrarMascota.Text = "Registrar Mascota";
            this.btnRegistrarMascota.UseVisualStyleBackColor = false;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // txtGestionMascota_Color
            // 
            this.txtGestionMascota_Color.Location = new System.Drawing.Point(631, 204);
            this.txtGestionMascota_Color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGestionMascota_Color.Name = "txtGestionMascota_Color";
            this.txtGestionMascota_Color.Size = new System.Drawing.Size(209, 33);
            this.txtGestionMascota_Color.TabIndex = 15;
            // 
            // txtGestionMascota_Sexo
            // 
            this.txtGestionMascota_Sexo.Location = new System.Drawing.Point(631, 139);
            this.txtGestionMascota_Sexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGestionMascota_Sexo.Name = "txtGestionMascota_Sexo";
            this.txtGestionMascota_Sexo.Size = new System.Drawing.Size(209, 33);
            this.txtGestionMascota_Sexo.TabIndex = 14;
            // 
            // txtGestionMascota_Peso
            // 
            this.txtGestionMascota_Peso.Location = new System.Drawing.Point(631, 83);
            this.txtGestionMascota_Peso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGestionMascota_Peso.Name = "txtGestionMascota_Peso";
            this.txtGestionMascota_Peso.Size = new System.Drawing.Size(209, 33);
            this.txtGestionMascota_Peso.TabIndex = 13;
            // 
            // txtGestionMascota_Raza
            // 
            this.txtGestionMascota_Raza.Location = new System.Drawing.Point(177, 152);
            this.txtGestionMascota_Raza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGestionMascota_Raza.Name = "txtGestionMascota_Raza";
            this.txtGestionMascota_Raza.Size = new System.Drawing.Size(223, 33);
            this.txtGestionMascota_Raza.TabIndex = 12;
            // 
            // txtGestionMascota_Especie
            // 
            this.txtGestionMascota_Especie.Location = new System.Drawing.Point(177, 86);
            this.txtGestionMascota_Especie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGestionMascota_Especie.Name = "txtGestionMascota_Especie";
            this.txtGestionMascota_Especie.Size = new System.Drawing.Size(223, 33);
            this.txtGestionMascota_Especie.TabIndex = 11;
            // 
            // txtGestionMascota_Nombre
            // 
            this.txtGestionMascota_Nombre.Location = new System.Drawing.Point(177, 26);
            this.txtGestionMascota_Nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGestionMascota_Nombre.Name = "txtGestionMascota_Nombre";
            this.txtGestionMascota_Nombre.Size = new System.Drawing.Size(223, 33);
            this.txtGestionMascota_Nombre.TabIndex = 9;
            // 
            // dtpGestionMascota_Nacimiento
            // 
            this.dtpGestionMascota_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGestionMascota_Nacimiento.Location = new System.Drawing.Point(631, 27);
            this.dtpGestionMascota_Nacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpGestionMascota_Nacimiento.Name = "dtpGestionMascota_Nacimiento";
            this.dtpGestionMascota_Nacimiento.Size = new System.Drawing.Size(209, 33);
            this.dtpGestionMascota_Nacimiento.TabIndex = 8;
            // 
            // lblGestionMascota_Color
            // 
            this.lblGestionMascota_Color.AutoSize = true;
            this.lblGestionMascota_Color.Location = new System.Drawing.Point(562, 207);
            this.lblGestionMascota_Color.Name = "lblGestionMascota_Color";
            this.lblGestionMascota_Color.Size = new System.Drawing.Size(70, 25);
            this.lblGestionMascota_Color.TabIndex = 7;
            this.lblGestionMascota_Color.Text = "Color:";
            // 
            // lblGestionMascota_Sexo
            // 
            this.lblGestionMascota_Sexo.AutoSize = true;
            this.lblGestionMascota_Sexo.Location = new System.Drawing.Point(566, 142);
            this.lblGestionMascota_Sexo.Name = "lblGestionMascota_Sexo";
            this.lblGestionMascota_Sexo.Size = new System.Drawing.Size(64, 25);
            this.lblGestionMascota_Sexo.TabIndex = 6;
            this.lblGestionMascota_Sexo.Text = "Sexo:";
            // 
            // lblGestionMascota_Peso
            // 
            this.lblGestionMascota_Peso.AutoSize = true;
            this.lblGestionMascota_Peso.Location = new System.Drawing.Point(567, 86);
            this.lblGestionMascota_Peso.Name = "lblGestionMascota_Peso";
            this.lblGestionMascota_Peso.Size = new System.Drawing.Size(63, 25);
            this.lblGestionMascota_Peso.TabIndex = 5;
            this.lblGestionMascota_Peso.Text = "Peso:";
            // 
            // lblGestionMascota_Nacimiento
            // 
            this.lblGestionMascota_Nacimiento.AutoSize = true;
            this.lblGestionMascota_Nacimiento.Location = new System.Drawing.Point(523, 33);
            this.lblGestionMascota_Nacimiento.Name = "lblGestionMascota_Nacimiento";
            this.lblGestionMascota_Nacimiento.Size = new System.Drawing.Size(130, 25);
            this.lblGestionMascota_Nacimiento.TabIndex = 4;
            this.lblGestionMascota_Nacimiento.Text = "Nacimiento:";
            // 
            // lblGestionMascota_Raza
            // 
            this.lblGestionMascota_Raza.AutoSize = true;
            this.lblGestionMascota_Raza.Location = new System.Drawing.Point(101, 155);
            this.lblGestionMascota_Raza.Name = "lblGestionMascota_Raza";
            this.lblGestionMascota_Raza.Size = new System.Drawing.Size(62, 25);
            this.lblGestionMascota_Raza.TabIndex = 3;
            this.lblGestionMascota_Raza.Text = "Raza:";
            // 
            // lblGestionMascotas_Especie
            // 
            this.lblGestionMascotas_Especie.AutoSize = true;
            this.lblGestionMascotas_Especie.Location = new System.Drawing.Point(84, 89);
            this.lblGestionMascotas_Especie.Name = "lblGestionMascotas_Especie";
            this.lblGestionMascotas_Especie.Size = new System.Drawing.Size(88, 25);
            this.lblGestionMascotas_Especie.TabIndex = 2;
            this.lblGestionMascotas_Especie.Text = "Especie:";
            // 
            // lblGestionMascotas_Nombre
            // 
            this.lblGestionMascotas_Nombre.AutoSize = true;
            this.lblGestionMascotas_Nombre.Location = new System.Drawing.Point(23, 27);
            this.lblGestionMascotas_Nombre.Name = "lblGestionMascotas_Nombre";
            this.lblGestionMascotas_Nombre.Size = new System.Drawing.Size(184, 25);
            this.lblGestionMascotas_Nombre.TabIndex = 0;
            this.lblGestionMascotas_Nombre.Text = "Nombre Mascota:";
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(12, 470);
            this.dgvMascotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 24;
            this.dgvMascotas.Size = new System.Drawing.Size(1054, 213);
            this.dgvMascotas.TabIndex = 10;
            this.dgvMascotas.DoubleClick += new System.EventHandler(this.dgvMascotas_DoubleClick);
            // 
            // frmGestionMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 769);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.lblGestionPropietarios);
            this.Controls.Add(this.pnlGestionMascota);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txtGestionMascota_Nombre;
        private System.Windows.Forms.DateTimePicker dtpGestionMascota_Nacimiento;
        private System.Windows.Forms.Label lblGestionMascota_Color;
        private System.Windows.Forms.Label lblGestionMascota_Sexo;
        private System.Windows.Forms.Label lblGestionMascota_Peso;
        private System.Windows.Forms.Label lblGestionMascota_Nacimiento;
        private System.Windows.Forms.Label lblGestionMascota_Raza;
        private System.Windows.Forms.Label lblGestionMascotas_Especie;
        private System.Windows.Forms.Label lblGestionMascotas_Nombre;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.Button btnActualizarInfoMascota;
        private System.Windows.Forms.Button btnVerMascotas;
        private System.Windows.Forms.DataGridView dgvMascotas;
    }
}
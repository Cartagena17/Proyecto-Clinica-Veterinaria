namespace Vistas.Formularios
{
    partial class frmDashboardPrincipal
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolverDashboard = new System.Windows.Forms.Button();
            this.btnDashboard_GestionPersonal = new System.Windows.Forms.Button();
            this.btnDashboard_GestionMascotas = new System.Windows.Forms.Button();
            this.btnDashboard_GestionPropietarios = new System.Windows.Forms.Button();
            this.btnDashboard_GestionMedica = new System.Windows.Forms.Button();
            this.btnDashboard_GestionCitas = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.btnMostrarCitasPendientes = new System.Windows.Forms.Button();
            this.lblCitas = new System.Windows.Forms.Label();
            this.dgvCitasPendientes = new System.Windows.Forms.DataGridView();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenuPrincipal.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.pnlBarraTitulo.Controls.Add(this.pictureBox1);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1484, 100);
            this.pnlBarraTitulo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_09_03_173131;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.AutoScroll = true;
            this.pnlMenuPrincipal.AutoScrollMargin = new System.Drawing.Size(5, 2);
            this.pnlMenuPrincipal.AutoScrollMinSize = new System.Drawing.Size(50, 1200);
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.pnlMenuPrincipal.Controls.Add(this.btnSalir);
            this.pnlMenuPrincipal.Controls.Add(this.btnVolverDashboard);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionPersonal);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionMascotas);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionPropietarios);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionMedica);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionCitas);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 100);
            this.pnlMenuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(304, 734);
            this.pnlMenuPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(0, 366);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(283, 65);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolverDashboard
            // 
            this.btnVolverDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnVolverDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVolverDashboard.FlatAppearance.BorderSize = 0;
            this.btnVolverDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverDashboard.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverDashboard.Location = new System.Drawing.Point(0, 301);
            this.btnVolverDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverDashboard.Name = "btnVolverDashboard";
            this.btnVolverDashboard.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnVolverDashboard.Size = new System.Drawing.Size(283, 65);
            this.btnVolverDashboard.TabIndex = 0;
            this.btnVolverDashboard.Text = "Volver al Menu Principal";
            this.btnVolverDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverDashboard.UseVisualStyleBackColor = false;
            this.btnVolverDashboard.Click += new System.EventHandler(this.btnVolverDashboard_Click);
            // 
            // btnDashboard_GestionPersonal
            // 
            this.btnDashboard_GestionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnDashboard_GestionPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionPersonal.FlatAppearance.BorderSize = 0;
            this.btnDashboard_GestionPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard_GestionPersonal.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard_GestionPersonal.Location = new System.Drawing.Point(0, 238);
            this.btnDashboard_GestionPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard_GestionPersonal.Name = "btnDashboard_GestionPersonal";
            this.btnDashboard_GestionPersonal.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDashboard_GestionPersonal.Size = new System.Drawing.Size(283, 63);
            this.btnDashboard_GestionPersonal.TabIndex = 1;
            this.btnDashboard_GestionPersonal.Text = "Gestion de Personal";
            this.btnDashboard_GestionPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard_GestionPersonal.UseVisualStyleBackColor = false;
            this.btnDashboard_GestionPersonal.Click += new System.EventHandler(this.btnDashboard_GestionPersonal_Click);
            // 
            // btnDashboard_GestionMascotas
            // 
            this.btnDashboard_GestionMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnDashboard_GestionMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionMascotas.FlatAppearance.BorderSize = 0;
            this.btnDashboard_GestionMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard_GestionMascotas.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard_GestionMascotas.Location = new System.Drawing.Point(0, 180);
            this.btnDashboard_GestionMascotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard_GestionMascotas.Name = "btnDashboard_GestionMascotas";
            this.btnDashboard_GestionMascotas.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDashboard_GestionMascotas.Size = new System.Drawing.Size(283, 58);
            this.btnDashboard_GestionMascotas.TabIndex = 1;
            this.btnDashboard_GestionMascotas.Text = "Gestion de Mascotas";
            this.btnDashboard_GestionMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard_GestionMascotas.UseVisualStyleBackColor = false;
            this.btnDashboard_GestionMascotas.Click += new System.EventHandler(this.btnDashboard_GestionMascotas_Click);
            // 
            // btnDashboard_GestionPropietarios
            // 
            this.btnDashboard_GestionPropietarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnDashboard_GestionPropietarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionPropietarios.FlatAppearance.BorderSize = 0;
            this.btnDashboard_GestionPropietarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard_GestionPropietarios.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard_GestionPropietarios.Location = new System.Drawing.Point(0, 122);
            this.btnDashboard_GestionPropietarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard_GestionPropietarios.Name = "btnDashboard_GestionPropietarios";
            this.btnDashboard_GestionPropietarios.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDashboard_GestionPropietarios.Size = new System.Drawing.Size(283, 58);
            this.btnDashboard_GestionPropietarios.TabIndex = 2;
            this.btnDashboard_GestionPropietarios.Text = "Gestion de Propietarios";
            this.btnDashboard_GestionPropietarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard_GestionPropietarios.UseVisualStyleBackColor = false;
            this.btnDashboard_GestionPropietarios.Click += new System.EventHandler(this.btnDashboard_GestionPropietarios_Click);
            // 
            // btnDashboard_GestionMedica
            // 
            this.btnDashboard_GestionMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnDashboard_GestionMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionMedica.FlatAppearance.BorderSize = 0;
            this.btnDashboard_GestionMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard_GestionMedica.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard_GestionMedica.Location = new System.Drawing.Point(0, 65);
            this.btnDashboard_GestionMedica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard_GestionMedica.Name = "btnDashboard_GestionMedica";
            this.btnDashboard_GestionMedica.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDashboard_GestionMedica.Size = new System.Drawing.Size(283, 57);
            this.btnDashboard_GestionMedica.TabIndex = 1;
            this.btnDashboard_GestionMedica.Text = "Gestiones Medicas";
            this.btnDashboard_GestionMedica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard_GestionMedica.UseVisualStyleBackColor = false;
            this.btnDashboard_GestionMedica.Click += new System.EventHandler(this.btnDashboard_GestionMedica_Click);
            // 
            // btnDashboard_GestionCitas
            // 
            this.btnDashboard_GestionCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnDashboard_GestionCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionCitas.FlatAppearance.BorderSize = 0;
            this.btnDashboard_GestionCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard_GestionCitas.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard_GestionCitas.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard_GestionCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard_GestionCitas.Name = "btnDashboard_GestionCitas";
            this.btnDashboard_GestionCitas.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnDashboard_GestionCitas.Size = new System.Drawing.Size(283, 65);
            this.btnDashboard_GestionCitas.TabIndex = 1;
            this.btnDashboard_GestionCitas.Text = "Gestion de Citas";
            this.btnDashboard_GestionCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard_GestionCitas.UseVisualStyleBackColor = false;
            this.btnDashboard_GestionCitas.Click += new System.EventHandler(this.btnDashboard_GestionCitas_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.btnMostrarCitasPendientes);
            this.pnlCentral.Controls.Add(this.lblCitas);
            this.pnlCentral.Controls.Add(this.dgvCitasPendientes);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentral.Location = new System.Drawing.Point(304, 100);
            this.pnlCentral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1180, 734);
            this.pnlCentral.TabIndex = 1;
            this.pnlCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCentral_Paint);
            // 
            // btnMostrarCitasPendientes
            // 
            this.btnMostrarCitasPendientes.Location = new System.Drawing.Point(241, 36);
            this.btnMostrarCitasPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarCitasPendientes.Name = "btnMostrarCitasPendientes";
            this.btnMostrarCitasPendientes.Size = new System.Drawing.Size(199, 41);
            this.btnMostrarCitasPendientes.TabIndex = 2;
            this.btnMostrarCitasPendientes.Text = "Mostrar Citas Pendientes";
            this.btnMostrarCitasPendientes.UseVisualStyleBackColor = true;
            this.btnMostrarCitasPendientes.Click += new System.EventHandler(this.btnMostrarCitasPendientes_Click);
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(26, 36);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(209, 29);
            this.lblCitas.TabIndex = 1;
            this.lblCitas.Text = "Citas pendientes";
            // 
            // dgvCitasPendientes
            // 
            this.dgvCitasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasPendientes.Location = new System.Drawing.Point(31, 81);
            this.dgvCitasPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCitasPendientes.Name = "dgvCitasPendientes";
            this.dgvCitasPendientes.RowHeadersWidth = 51;
            this.dgvCitasPendientes.RowTemplate.Height = 24;
            this.dgvCitasPendientes.Size = new System.Drawing.Size(1061, 405);
            this.dgvCitasPendientes.TabIndex = 0;
            // 
            // frmDashboardPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1484, 834);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboardPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard_GestionMedica;
        private System.Windows.Forms.Button btnDashboard_GestionCitas;
        private System.Windows.Forms.Button btnDashboard_GestionMascotas;
        private System.Windows.Forms.Button btnDashboard_GestionPropietarios;
        private System.Windows.Forms.Button btnDashboard_GestionPersonal;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnVolverDashboard;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.DataGridView dgvCitasPendientes;
        private System.Windows.Forms.Button btnMostrarCitasPendientes;
        private System.Windows.Forms.Button btnSalir;
    }
}
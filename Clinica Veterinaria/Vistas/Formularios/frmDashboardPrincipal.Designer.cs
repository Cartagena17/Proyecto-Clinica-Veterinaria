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
            this.btnDashboard_Facturacion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnDashboard_GestionPersonal = new System.Windows.Forms.Button();
            this.btnDashboard_GestionMascotas = new System.Windows.Forms.Button();
            this.btnDashboard_GestionPropietarios = new System.Windows.Forms.Button();
            this.btnDashboard_GestionMedica = new System.Windows.Forms.Button();
            this.btnDashboard_GestionCitas = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.btnVolverDashboard = new System.Windows.Forms.Button();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBarraTitulo.Controls.Add(this.pictureBox1);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1208, 100);
            this.pnlBarraTitulo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Captura_de_pantalla_2025_07_22_225034;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.AutoScroll = true;
            this.pnlMenuPrincipal.AutoScrollMargin = new System.Drawing.Size(5, 2);
            this.pnlMenuPrincipal.AutoScrollMinSize = new System.Drawing.Size(50, 1200);
            this.pnlMenuPrincipal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlMenuPrincipal.Controls.Add(this.btnVolverDashboard);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_Facturacion);
            this.pnlMenuPrincipal.Controls.Add(this.btnInventario);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionPersonal);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionMascotas);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionPropietarios);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionMedica);
            this.pnlMenuPrincipal.Controls.Add(this.btnDashboard_GestionCitas);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 100);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(297, 585);
            this.pnlMenuPrincipal.TabIndex = 0;
            // 
            // btnDashboard_Facturacion
            // 
            this.btnDashboard_Facturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_Facturacion.Location = new System.Drawing.Point(0, 314);
            this.btnDashboard_Facturacion.Name = "btnDashboard_Facturacion";
            this.btnDashboard_Facturacion.Size = new System.Drawing.Size(276, 51);
            this.btnDashboard_Facturacion.TabIndex = 1;
            this.btnDashboard_Facturacion.Text = "Facturaciones";
            this.btnDashboard_Facturacion.UseVisualStyleBackColor = true;
            this.btnDashboard_Facturacion.Click += new System.EventHandler(this.btnDashboard_Facturacion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.Location = new System.Drawing.Point(0, 268);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(276, 46);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventarios";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnDashboard_GestionPersonal
            // 
            this.btnDashboard_GestionPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionPersonal.Location = new System.Drawing.Point(0, 219);
            this.btnDashboard_GestionPersonal.Name = "btnDashboard_GestionPersonal";
            this.btnDashboard_GestionPersonal.Size = new System.Drawing.Size(276, 49);
            this.btnDashboard_GestionPersonal.TabIndex = 1;
            this.btnDashboard_GestionPersonal.Text = "Gestion de Personal";
            this.btnDashboard_GestionPersonal.UseVisualStyleBackColor = true;
            this.btnDashboard_GestionPersonal.Click += new System.EventHandler(this.btnDashboard_GestionPersonal_Click);
            // 
            // btnDashboard_GestionMascotas
            // 
            this.btnDashboard_GestionMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionMascotas.Location = new System.Drawing.Point(0, 165);
            this.btnDashboard_GestionMascotas.Name = "btnDashboard_GestionMascotas";
            this.btnDashboard_GestionMascotas.Size = new System.Drawing.Size(276, 54);
            this.btnDashboard_GestionMascotas.TabIndex = 1;
            this.btnDashboard_GestionMascotas.Text = "Gestion de Mascotas";
            this.btnDashboard_GestionMascotas.UseVisualStyleBackColor = true;
            this.btnDashboard_GestionMascotas.Click += new System.EventHandler(this.btnDashboard_GestionMascotas_Click);
            // 
            // btnDashboard_GestionPropietarios
            // 
            this.btnDashboard_GestionPropietarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionPropietarios.Location = new System.Drawing.Point(0, 113);
            this.btnDashboard_GestionPropietarios.Name = "btnDashboard_GestionPropietarios";
            this.btnDashboard_GestionPropietarios.Size = new System.Drawing.Size(276, 52);
            this.btnDashboard_GestionPropietarios.TabIndex = 2;
            this.btnDashboard_GestionPropietarios.Text = "Gestion de Propietarios";
            this.btnDashboard_GestionPropietarios.UseVisualStyleBackColor = true;
            this.btnDashboard_GestionPropietarios.Click += new System.EventHandler(this.btnDashboard_GestionPropietarios_Click);
            // 
            // btnDashboard_GestionMedica
            // 
            this.btnDashboard_GestionMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionMedica.Location = new System.Drawing.Point(0, 57);
            this.btnDashboard_GestionMedica.Name = "btnDashboard_GestionMedica";
            this.btnDashboard_GestionMedica.Size = new System.Drawing.Size(276, 56);
            this.btnDashboard_GestionMedica.TabIndex = 1;
            this.btnDashboard_GestionMedica.Text = "Gestiones Medicas";
            this.btnDashboard_GestionMedica.UseVisualStyleBackColor = true;
            this.btnDashboard_GestionMedica.Click += new System.EventHandler(this.btnDashboard_GestionMedica_Click);
            // 
            // btnDashboard_GestionCitas
            // 
            this.btnDashboard_GestionCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard_GestionCitas.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard_GestionCitas.Name = "btnDashboard_GestionCitas";
            this.btnDashboard_GestionCitas.Size = new System.Drawing.Size(276, 57);
            this.btnDashboard_GestionCitas.TabIndex = 1;
            this.btnDashboard_GestionCitas.Text = "Gestion de Citas";
            this.btnDashboard_GestionCitas.UseVisualStyleBackColor = true;
            this.btnDashboard_GestionCitas.Click += new System.EventHandler(this.btnDashboard_GestionCitas_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(297, 100);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(911, 585);
            this.pnlCentral.TabIndex = 1;
            // 
            // btnVolverDashboard
            // 
            this.btnVolverDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVolverDashboard.Location = new System.Drawing.Point(0, 365);
            this.btnVolverDashboard.Name = "btnVolverDashboard";
            this.btnVolverDashboard.Size = new System.Drawing.Size(276, 46);
            this.btnVolverDashboard.TabIndex = 0;
            this.btnVolverDashboard.Text = "Volver al Menu Principal";
            this.btnVolverDashboard.UseVisualStyleBackColor = true;
            this.btnVolverDashboard.Click += new System.EventHandler(this.btnVolverDashboard_Click);
            // 
            // frmDashboardPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1208, 685);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Name = "frmDashboardPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardPrincipal";
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenuPrincipal.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnDashboard_Facturacion;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnVolverDashboard;
    }
}
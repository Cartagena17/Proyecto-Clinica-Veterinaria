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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardPrincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ibtnGestionPersonal = new FontAwesome.Sharp.IconButton();
            this.ibtnGestionMascotas = new FontAwesome.Sharp.IconButton();
            this.ibtnGestionPropietarios = new FontAwesome.Sharp.IconButton();
            this.ibtnGestionMedica = new FontAwesome.Sharp.IconButton();
            this.ibtnGestionCitas = new FontAwesome.Sharp.IconButton();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenuPrincipal.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.AutoScroll = true;
            this.pnlMenuPrincipal.AutoScrollMargin = new System.Drawing.Size(5, 2);
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.pnlMenuPrincipal.Controls.Add(this.btnSalir);
            this.pnlMenuPrincipal.Controls.Add(this.ibtnGestionPersonal);
            this.pnlMenuPrincipal.Controls.Add(this.ibtnGestionMascotas);
            this.pnlMenuPrincipal.Controls.Add(this.ibtnGestionPropietarios);
            this.pnlMenuPrincipal.Controls.Add(this.ibtnGestionMedica);
            this.pnlMenuPrincipal.Controls.Add(this.ibtnGestionCitas);
            this.pnlMenuPrincipal.Controls.Add(this.pictureBox2);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuPrincipal.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 100);
            this.pnlMenuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(357, 627);
            this.pnlMenuPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(0, 592);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(336, 68);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ibtnGestionPersonal
            // 
            this.ibtnGestionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.ibtnGestionPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnGestionPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGestionPersonal.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtnGestionPersonal.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.ibtnGestionPersonal.IconColor = System.Drawing.Color.Black;
            this.ibtnGestionPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGestionPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGestionPersonal.Location = new System.Drawing.Point(0, 492);
            this.ibtnGestionPersonal.Name = "ibtnGestionPersonal";
            this.ibtnGestionPersonal.Size = new System.Drawing.Size(336, 98);
            this.ibtnGestionPersonal.TabIndex = 7;
            this.ibtnGestionPersonal.Text = "Gestion de personal";
            this.ibtnGestionPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGestionPersonal.UseVisualStyleBackColor = false;
            this.ibtnGestionPersonal.Click += new System.EventHandler(this.ibtnGestionPersonal_Click);
            // 
            // ibtnGestionMascotas
            // 
            this.ibtnGestionMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.ibtnGestionMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnGestionMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGestionMascotas.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtnGestionMascotas.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.ibtnGestionMascotas.IconColor = System.Drawing.Color.Black;
            this.ibtnGestionMascotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGestionMascotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGestionMascotas.Location = new System.Drawing.Point(0, 395);
            this.ibtnGestionMascotas.Name = "ibtnGestionMascotas";
            this.ibtnGestionMascotas.Size = new System.Drawing.Size(336, 97);
            this.ibtnGestionMascotas.TabIndex = 6;
            this.ibtnGestionMascotas.Text = "Gestion de Mascotas";
            this.ibtnGestionMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGestionMascotas.UseVisualStyleBackColor = false;
            this.ibtnGestionMascotas.Click += new System.EventHandler(this.ibtnGestionMascotas_Click);
            // 
            // ibtnGestionPropietarios
            // 
            this.ibtnGestionPropietarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.ibtnGestionPropietarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnGestionPropietarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGestionPropietarios.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtnGestionPropietarios.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.ibtnGestionPropietarios.IconColor = System.Drawing.Color.Black;
            this.ibtnGestionPropietarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGestionPropietarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGestionPropietarios.Location = new System.Drawing.Point(0, 296);
            this.ibtnGestionPropietarios.Name = "ibtnGestionPropietarios";
            this.ibtnGestionPropietarios.Size = new System.Drawing.Size(336, 99);
            this.ibtnGestionPropietarios.TabIndex = 5;
            this.ibtnGestionPropietarios.Text = "Gestion de Propietarios";
            this.ibtnGestionPropietarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGestionPropietarios.UseVisualStyleBackColor = false;
            this.ibtnGestionPropietarios.Click += new System.EventHandler(this.ibtnGestionPropietarios_Click);
            // 
            // ibtnGestionMedica
            // 
            this.ibtnGestionMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.ibtnGestionMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnGestionMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGestionMedica.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtnGestionMedica.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.ibtnGestionMedica.IconColor = System.Drawing.Color.Black;
            this.ibtnGestionMedica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGestionMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGestionMedica.Location = new System.Drawing.Point(0, 197);
            this.ibtnGestionMedica.Name = "ibtnGestionMedica";
            this.ibtnGestionMedica.Size = new System.Drawing.Size(336, 99);
            this.ibtnGestionMedica.TabIndex = 4;
            this.ibtnGestionMedica.Text = "Gestiones Medicas";
            this.ibtnGestionMedica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGestionMedica.UseVisualStyleBackColor = false;
            this.ibtnGestionMedica.Click += new System.EventHandler(this.ibtnGestionMedica_Click);
            // 
            // ibtnGestionCitas
            // 
            this.ibtnGestionCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.ibtnGestionCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnGestionCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGestionCitas.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtnGestionCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.ibtnGestionCitas.IconColor = System.Drawing.Color.Black;
            this.ibtnGestionCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGestionCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnGestionCitas.Location = new System.Drawing.Point(0, 98);
            this.ibtnGestionCitas.Name = "ibtnGestionCitas";
            this.ibtnGestionCitas.Size = new System.Drawing.Size(336, 99);
            this.ibtnGestionCitas.TabIndex = 3;
            this.ibtnGestionCitas.Text = "Gestion de Citas";
            this.ibtnGestionCitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGestionCitas.UseVisualStyleBackColor = false;
            this.ibtnGestionCitas.Click += new System.EventHandler(this.ibtnGestionCitas_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCentral.BackgroundImage")));
            this.pnlCentral.Controls.Add(this.panel1);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentral.Location = new System.Drawing.Point(357, 100);
            this.pnlCentral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1127, 627);
            this.pnlCentral.TabIndex = 1;
            this.pnlCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCentral_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(164)))), ((int)(((byte)(186)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 627);
            this.panel1.TabIndex = 0;
            // 
            // frmDashboardPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1484, 727);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboardPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboardPrincipal_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnSalir;
        private FontAwesome.Sharp.IconButton ibtnGestionCitas;
        private FontAwesome.Sharp.IconButton ibtnGestionPersonal;
        private FontAwesome.Sharp.IconButton ibtnGestionMascotas;
        private FontAwesome.Sharp.IconButton ibtnGestionPropietarios;
        private FontAwesome.Sharp.IconButton ibtnGestionMedica;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
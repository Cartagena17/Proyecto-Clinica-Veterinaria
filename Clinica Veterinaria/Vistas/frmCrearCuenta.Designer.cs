namespace Vistas
{
    partial class frmCrearCuenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpleadosSinCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtUsuarioGenerado = new System.Windows.Forms.TextBox();
            this.txtContraseñaGenerada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Cuenta";
            // 
            // cbEmpleadosSinCuenta
            // 
            this.cbEmpleadosSinCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleadosSinCuenta.FormattingEnabled = true;
            this.cbEmpleadosSinCuenta.Location = new System.Drawing.Point(73, 124);
            this.cbEmpleadosSinCuenta.Name = "cbEmpleadosSinCuenta";
            this.cbEmpleadosSinCuenta.Size = new System.Drawing.Size(225, 25);
            this.cbEmpleadosSinCuenta.TabIndex = 1;
            this.cbEmpleadosSinCuenta.SelectedIndexChanged += new System.EventHandler(this.cbEmpleadosSinCuenta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleados sin cuenta:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(164, 219);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(156, 47);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar Contraseña/Username";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtUsuarioGenerado
            // 
            this.txtUsuarioGenerado.Location = new System.Drawing.Point(73, 301);
            this.txtUsuarioGenerado.Name = "txtUsuarioGenerado";
            this.txtUsuarioGenerado.Size = new System.Drawing.Size(225, 25);
            this.txtUsuarioGenerado.TabIndex = 6;
            // 
            // txtContraseñaGenerada
            // 
            this.txtContraseñaGenerada.Location = new System.Drawing.Point(73, 361);
            this.txtContraseñaGenerada.Name = "txtContraseñaGenerada";
            this.txtContraseñaGenerada.Size = new System.Drawing.Size(225, 25);
            this.txtContraseñaGenerada.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña:";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(73, 403);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(124, 36);
            this.btnCrearCuenta.TabIndex = 10;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(227, 405);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(182, 34);
            this.btnEnviarEmail.TabIndex = 11;
            this.btnEnviarEmail.Text = "Enviar correo informativo";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 478);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseñaGenerada);
            this.Controls.Add(this.txtUsuarioGenerado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpleadosSinCuenta);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearCuenta";
            this.Load += new System.EventHandler(this.frmCrearCuenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpleadosSinCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtUsuarioGenerado;
        private System.Windows.Forms.TextBox txtContraseñaGenerada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Button btnEnviarEmail;
    }
}
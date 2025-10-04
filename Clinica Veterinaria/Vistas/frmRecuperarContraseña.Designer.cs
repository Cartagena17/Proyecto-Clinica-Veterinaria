namespace Vistas
{
    partial class frmRecuperarContraseña
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
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblRecuperarContra = new System.Windows.Forms.Label();
            this.pnlToken = new System.Windows.Forms.Panel();
            this.pnlNuevaContraseña = new System.Windows.Forms.Panel();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContra = new System.Windows.Forms.Label();
            this.btnVolverToken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.btnVolverEmail = new System.Windows.Forms.Button();
            this.lblRecuperarContra2 = new System.Windows.Forms.Label();
            this.btnVerificarToken = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnEnviarToken = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlEmail.SuspendLayout();
            this.pnlToken.SuspendLayout();
            this.pnlNuevaContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.pnlEmail.Controls.Add(this.lblRecuperarContra);
            this.pnlEmail.Controls.Add(this.btnEnviarToken);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.pnlEmail.Location = new System.Drawing.Point(72, 12);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(356, 435);
            this.pnlEmail.TabIndex = 8;
            // 
            // lblRecuperarContra
            // 
            this.lblRecuperarContra.AutoSize = true;
            this.lblRecuperarContra.Location = new System.Drawing.Point(58, 72);
            this.lblRecuperarContra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecuperarContra.Name = "lblRecuperarContra";
            this.lblRecuperarContra.Size = new System.Drawing.Size(240, 24);
            this.lblRecuperarContra.TabIndex = 0;
            this.lblRecuperarContra.Text = "Recuperar Contraseña";
            // 
            // pnlToken
            // 
            this.pnlToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.pnlToken.Controls.Add(this.btnVolverEmail);
            this.pnlToken.Controls.Add(this.lblRecuperarContra2);
            this.pnlToken.Controls.Add(this.btnVerificarToken);
            this.pnlToken.Controls.Add(this.lblCodigo);
            this.pnlToken.Controls.Add(this.txtToken);
            this.pnlToken.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.pnlToken.Location = new System.Drawing.Point(72, 9);
            this.pnlToken.Name = "pnlToken";
            this.pnlToken.Size = new System.Drawing.Size(356, 435);
            this.pnlToken.TabIndex = 9;
            this.pnlToken.Visible = false;
            // 
            // pnlNuevaContraseña
            // 
            this.pnlNuevaContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(183)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.pnlNuevaContraseña.Controls.Add(this.txtConfirmarContraseña);
            this.pnlNuevaContraseña.Controls.Add(this.lblConfirmarContra);
            this.pnlNuevaContraseña.Controls.Add(this.btnVolverToken);
            this.pnlNuevaContraseña.Controls.Add(this.label1);
            this.pnlNuevaContraseña.Controls.Add(this.btnCambiarContraseña);
            this.pnlNuevaContraseña.Controls.Add(this.lblNuevaContraseña);
            this.pnlNuevaContraseña.Controls.Add(this.txtNuevaContraseña);
            this.pnlNuevaContraseña.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.pnlNuevaContraseña.Location = new System.Drawing.Point(72, 6);
            this.pnlNuevaContraseña.Name = "pnlNuevaContraseña";
            this.pnlNuevaContraseña.Size = new System.Drawing.Size(356, 435);
            this.pnlNuevaContraseña.TabIndex = 10;
            this.pnlNuevaContraseña.Visible = false;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(47, 252);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(251, 31);
            this.txtConfirmarContraseña.TabIndex = 8;
            // 
            // lblConfirmarContra
            // 
            this.lblConfirmarContra.AutoSize = true;
            this.lblConfirmarContra.Location = new System.Drawing.Point(117, 223);
            this.lblConfirmarContra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConfirmarContra.Name = "lblConfirmarContra";
            this.lblConfirmarContra.Size = new System.Drawing.Size(116, 24);
            this.lblConfirmarContra.TabIndex = 7;
            this.lblConfirmarContra.Text = "Confirmar";
            // 
            // btnVolverToken
            // 
            this.btnVolverToken.Location = new System.Drawing.Point(14, 397);
            this.btnVolverToken.Name = "btnVolverToken";
            this.btnVolverToken.Size = new System.Drawing.Size(87, 27);
            this.btnVolverToken.TabIndex = 6;
            this.btnVolverToken.Text = "Volver";
            this.btnVolverToken.UseVisualStyleBackColor = true;
            this.btnVolverToken.Click += new System.EventHandler(this.btnVolverToken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar Contraseña";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.Location = new System.Drawing.Point(62, 328);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(236, 35);
            this.btnCambiarContraseña.TabIndex = 5;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(76, 158);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(198, 24);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Nueva Contraseña";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(47, 187);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(251, 31);
            this.txtNuevaContraseña.TabIndex = 3;
            // 
            // btnVolverEmail
            // 
            this.btnVolverEmail.Location = new System.Drawing.Point(14, 397);
            this.btnVolverEmail.Name = "btnVolverEmail";
            this.btnVolverEmail.Size = new System.Drawing.Size(87, 27);
            this.btnVolverEmail.TabIndex = 6;
            this.btnVolverEmail.Text = "Volver";
            this.btnVolverEmail.UseVisualStyleBackColor = true;
            this.btnVolverEmail.Click += new System.EventHandler(this.btnVolverEmail_Click);
            // 
            // lblRecuperarContra2
            // 
            this.lblRecuperarContra2.AutoSize = true;
            this.lblRecuperarContra2.Location = new System.Drawing.Point(58, 72);
            this.lblRecuperarContra2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecuperarContra2.Name = "lblRecuperarContra2";
            this.lblRecuperarContra2.Size = new System.Drawing.Size(240, 24);
            this.lblRecuperarContra2.TabIndex = 0;
            this.lblRecuperarContra2.Text = "Recuperar Contraseña";
            // 
            // btnVerificarToken
            // 
            this.btnVerificarToken.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarToken.Location = new System.Drawing.Point(62, 228);
            this.btnVerificarToken.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerificarToken.Name = "btnVerificarToken";
            this.btnVerificarToken.Size = new System.Drawing.Size(212, 35);
            this.btnVerificarToken.TabIndex = 5;
            this.btnVerificarToken.Text = "Verificar Código";
            this.btnVerificarToken.UseVisualStyleBackColor = true;
            this.btnVerificarToken.Click += new System.EventHandler(this.btnVerificarToken_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(136, 158);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 24);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(47, 187);
            this.txtToken.Margin = new System.Windows.Forms.Padding(5);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(251, 31);
            this.txtToken.TabIndex = 3;
            // 
            // btnEnviarToken
            // 
            this.btnEnviarToken.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarToken.Location = new System.Drawing.Point(86, 228);
            this.btnEnviarToken.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnviarToken.Name = "btnEnviarToken";
            this.btnEnviarToken.Size = new System.Drawing.Size(183, 35);
            this.btnEnviarToken.TabIndex = 5;
            this.btnEnviarToken.Text = "Enviar Código";
            this.btnEnviarToken.UseVisualStyleBackColor = true;
            this.btnEnviarToken.Click += new System.EventHandler(this.btnEnviarToken_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(136, 158);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 24);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 187);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondoLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 529);
            this.Controls.Add(this.pnlNuevaContraseña);
            this.Controls.Add(this.pnlToken);
            this.Controls.Add(this.pnlEmail);
            this.Name = "frmRecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperarContraseña";
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlToken.ResumeLayout(false);
            this.pnlToken.PerformLayout();
            this.pnlNuevaContraseña.ResumeLayout(false);
            this.pnlNuevaContraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblRecuperarContra;
        private System.Windows.Forms.Button btnEnviarToken;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlToken;
        private System.Windows.Forms.Label lblRecuperarContra2;
        private System.Windows.Forms.Button btnVerificarToken;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnVolverEmail;
        private System.Windows.Forms.Panel pnlNuevaContraseña;
        private System.Windows.Forms.Button btnVolverToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label lblConfirmarContra;
    }
}
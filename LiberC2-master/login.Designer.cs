namespace LiberMiCuenta
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.linkLabelRecuperarContrasenya = new System.Windows.Forms.LinkLabel();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.AutoSize = true;
            this.groupBoxLogin.Controls.Add(this.pictureBoxLogo);
            this.groupBoxLogin.Controls.Add(this.linkLabelRecuperarContrasenya);
            this.groupBoxLogin.Controls.Add(this.buttonEntrar);
            this.groupBoxLogin.Controls.Add(this.textBoxContraseña);
            this.groupBoxLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxLogin.Location = new System.Drawing.Point(24, 36);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLogin.Size = new System.Drawing.Size(760, 378);
            this.groupBoxLogin.TabIndex = 2;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "LOGIN";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(315, 35);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(133, 130);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // linkLabelRecuperarContrasenya
            // 
            this.linkLabelRecuperarContrasenya.AutoSize = true;
            this.linkLabelRecuperarContrasenya.Location = new System.Drawing.Point(329, 343);
            this.linkLabelRecuperarContrasenya.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelRecuperarContrasenya.Name = "linkLabelRecuperarContrasenya";
            this.linkLabelRecuperarContrasenya.Size = new System.Drawing.Size(113, 13);
            this.linkLabelRecuperarContrasenya.TabIndex = 3;
            this.linkLabelRecuperarContrasenya.TabStop = true;
            this.linkLabelRecuperarContrasenya.Text = "Recuperar contraseña";
            this.linkLabelRecuperarContrasenya.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecuperarContrasenya_LinkClicked);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(487, 276);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(109, 24);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            this.buttonEntrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonEntrar_KeyPress);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxContraseña.Location = new System.Drawing.Point(167, 238);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(429, 20);
            this.textBoxContraseña.TabIndex = 1;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(167, 203);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(429, 20);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.Text = "Nombre";
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(812, 448);
            this.Controls.Add(this.groupBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Text = "login";
            this.Activated += new System.EventHandler(this.login_Activated);
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkLabelRecuperarContrasenya;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
    }
}
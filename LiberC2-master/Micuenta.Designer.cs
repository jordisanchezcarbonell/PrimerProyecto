namespace LiberMiCuenta
{
    partial class Micuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Micuenta));
            this.ToolStripBarra = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGestionAdministradores = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLibrerias = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActividades = new System.Windows.Forms.ToolStripButton();
            this.labelMiCuenta = new System.Windows.Forms.Label();
            this.groupBoxCuentaadmin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxCorreoelectronico = new System.Windows.Forms.TextBox();
            this.textBoxnombreyappelido = new System.Windows.Forms.TextBox();
            this.textBoxCuentaAdmin = new System.Windows.Forms.TextBox();
            this.labelAdmincorreo = new System.Windows.Forms.Label();
            this.labelNombreAdmin = new System.Windows.Forms.Label();
            this.labelGAdmin = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxCAdmin = new System.Windows.Forms.TextBox();
            this.textBoxCEAdmin = new System.Windows.Forms.TextBox();
            this.textBoxNAdmin = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.ToolStripBarra.SuspendLayout();
            this.groupBoxCuentaadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripBarra
            // 
            this.ToolStripBarra.BackColor = System.Drawing.Color.White;
            this.ToolStripBarra.GripMargin = new System.Windows.Forms.Padding(500, 2, 2, 500);
            this.ToolStripBarra.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ToolStripBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGestionAdministradores,
            this.toolStripButtonLibrerias,
            this.toolStripButtonActividades});
            this.ToolStripBarra.Location = new System.Drawing.Point(0, 0);
            this.ToolStripBarra.Name = "ToolStripBarra";
            this.ToolStripBarra.Size = new System.Drawing.Size(924, 37);
            this.ToolStripBarra.TabIndex = 3;
            this.ToolStripBarra.Text = "toolStrip1";
            // 
            // toolStripButtonGestionAdministradores
            // 
            this.toolStripButtonGestionAdministradores.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonGestionAdministradores.AutoSize = false;
            this.toolStripButtonGestionAdministradores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGestionAdministradores.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGestionAdministradores.Image")));
            this.toolStripButtonGestionAdministradores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGestionAdministradores.Name = "toolStripButtonGestionAdministradores";
            this.toolStripButtonGestionAdministradores.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonGestionAdministradores.Text = "Gestion de Administradores";
            this.toolStripButtonGestionAdministradores.Click += new System.EventHandler(this.toolStripButtonGestionAdministradores_Click);
            // 
            // toolStripButtonLibrerias
            // 
            this.toolStripButtonLibrerias.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonLibrerias.AutoSize = false;
            this.toolStripButtonLibrerias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLibrerias.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLibrerias.Image")));
            this.toolStripButtonLibrerias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLibrerias.Name = "toolStripButtonLibrerias";
            this.toolStripButtonLibrerias.Size = new System.Drawing.Size(30, 30);
            this.toolStripButtonLibrerias.Text = "Lista de Librerías";
            this.toolStripButtonLibrerias.Click += new System.EventHandler(this.toolStripButtonLibrerias_Click);
            // 
            // toolStripButtonActividades
            // 
            this.toolStripButtonActividades.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonActividades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonActividades.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonActividades.Image")));
            this.toolStripButtonActividades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActividades.Name = "toolStripButtonActividades";
            this.toolStripButtonActividades.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonActividades.Text = "Lista de Actividades";
            this.toolStripButtonActividades.Click += new System.EventHandler(this.toolStripButtonActividades_Click);
            // 
            // labelMiCuenta
            // 
            this.labelMiCuenta.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelMiCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiCuenta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMiCuenta.Location = new System.Drawing.Point(-6, 0);
            this.labelMiCuenta.Name = "labelMiCuenta";
            this.labelMiCuenta.Padding = new System.Windows.Forms.Padding(260, 2, 0, 0);
            this.labelMiCuenta.Size = new System.Drawing.Size(794, 37);
            this.labelMiCuenta.TabIndex = 4;
            this.labelMiCuenta.Text = "    Mi cuenta";
            this.labelMiCuenta.Click += new System.EventHandler(this.labelMiCuenta_Click);
            // 
            // groupBoxCuentaadmin
            // 
            this.groupBoxCuentaadmin.Controls.Add(this.pictureBox1);
            this.groupBoxCuentaadmin.Controls.Add(this.buttonGuardar);
            this.groupBoxCuentaadmin.Controls.Add(this.textBoxCorreoelectronico);
            this.groupBoxCuentaadmin.Controls.Add(this.textBoxnombreyappelido);
            this.groupBoxCuentaadmin.Controls.Add(this.textBoxCuentaAdmin);
            this.groupBoxCuentaadmin.Controls.Add(this.labelAdmincorreo);
            this.groupBoxCuentaadmin.Controls.Add(this.labelNombreAdmin);
            this.groupBoxCuentaadmin.Controls.Add(this.labelGAdmin);
            this.groupBoxCuentaadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxCuentaadmin.Location = new System.Drawing.Point(111, 73);
            this.groupBoxCuentaadmin.Name = "groupBoxCuentaadmin";
            this.groupBoxCuentaadmin.Size = new System.Drawing.Size(703, 325);
            this.groupBoxCuentaadmin.TabIndex = 29;
            this.groupBoxCuentaadmin.TabStop = false;
            this.groupBoxCuentaadmin.Text = "Cuenta";
            this.groupBoxCuentaadmin.Enter += new System.EventHandler(this.groupBoxCuentaadmin_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonGuardar.Location = new System.Drawing.Point(487, 31);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(122, 30);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Editar perfil";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxCorreoelectronico
            // 
            this.textBoxCorreoelectronico.Location = new System.Drawing.Point(379, 211);
            this.textBoxCorreoelectronico.Name = "textBoxCorreoelectronico";
            this.textBoxCorreoelectronico.ReadOnly = true;
            this.textBoxCorreoelectronico.Size = new System.Drawing.Size(230, 23);
            this.textBoxCorreoelectronico.TabIndex = 5;
            // 
            // textBoxnombreyappelido
            // 
            this.textBoxnombreyappelido.Location = new System.Drawing.Point(379, 165);
            this.textBoxnombreyappelido.Name = "textBoxnombreyappelido";
            this.textBoxnombreyappelido.ReadOnly = true;
            this.textBoxnombreyappelido.Size = new System.Drawing.Size(230, 23);
            this.textBoxnombreyappelido.TabIndex = 4;
            // 
            // textBoxCuentaAdmin
            // 
            this.textBoxCuentaAdmin.Location = new System.Drawing.Point(379, 122);
            this.textBoxCuentaAdmin.Name = "textBoxCuentaAdmin";
            this.textBoxCuentaAdmin.ReadOnly = true;
            this.textBoxCuentaAdmin.Size = new System.Drawing.Size(230, 23);
            this.textBoxCuentaAdmin.TabIndex = 3;
            this.textBoxCuentaAdmin.TextChanged += new System.EventHandler(this.textBoxCuentaAdmin_TextChanged);
            // 
            // labelAdmincorreo
            // 
            this.labelAdmincorreo.AutoSize = true;
            this.labelAdmincorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelAdmincorreo.Location = new System.Drawing.Point(224, 211);
            this.labelAdmincorreo.Name = "labelAdmincorreo";
            this.labelAdmincorreo.Size = new System.Drawing.Size(124, 17);
            this.labelAdmincorreo.TabIndex = 2;
            this.labelAdmincorreo.Text = "Correo electronico";
            // 
            // labelNombreAdmin
            // 
            this.labelNombreAdmin.AutoSize = true;
            this.labelNombreAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelNombreAdmin.Location = new System.Drawing.Point(224, 165);
            this.labelNombreAdmin.Name = "labelNombreAdmin";
            this.labelNombreAdmin.Size = new System.Drawing.Size(129, 17);
            this.labelNombreAdmin.TabIndex = 1;
            this.labelNombreAdmin.Text = "Nombre y apellidos";
            // 
            // labelGAdmin
            // 
            this.labelGAdmin.AutoSize = true;
            this.labelGAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelGAdmin.Location = new System.Drawing.Point(224, 122);
            this.labelGAdmin.Name = "labelGAdmin";
            this.labelGAdmin.Size = new System.Drawing.Size(101, 17);
            this.labelGAdmin.TabIndex = 0;
            this.labelGAdmin.Text = "Nombre Admin";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAgregar.Location = new System.Drawing.Point(446, 284);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(122, 30);
            this.buttonAgregar.TabIndex = 28;
            this.buttonAgregar.Text = "Agregar Admin";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // textBoxCAdmin
            // 
            this.textBoxCAdmin.Location = new System.Drawing.Point(338, 203);
            this.textBoxCAdmin.Name = "textBoxCAdmin";
            this.textBoxCAdmin.Size = new System.Drawing.Size(230, 20);
            this.textBoxCAdmin.TabIndex = 27;
            // 
            // textBoxCEAdmin
            // 
            this.textBoxCEAdmin.Location = new System.Drawing.Point(338, 157);
            this.textBoxCEAdmin.Name = "textBoxCEAdmin";
            this.textBoxCEAdmin.Size = new System.Drawing.Size(230, 20);
            this.textBoxCEAdmin.TabIndex = 26;
            // 
            // textBoxNAdmin
            // 
            this.textBoxNAdmin.Location = new System.Drawing.Point(338, 114);
            this.textBoxNAdmin.Name = "textBoxNAdmin";
            this.textBoxNAdmin.Size = new System.Drawing.Size(230, 20);
            this.textBoxNAdmin.TabIndex = 25;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelContraseña.Location = new System.Drawing.Point(183, 203);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(81, 17);
            this.labelContraseña.TabIndex = 24;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelemail.Location = new System.Drawing.Point(183, 157);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(124, 17);
            this.labelemail.TabIndex = 23;
            this.labelemail.Text = "Correo electronico";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelnombre.Location = new System.Drawing.Point(183, 114);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(92, 17);
            this.labelnombre.TabIndex = 22;
            this.labelnombre.Text = "Nuevo Admin";
            // 
            // Micuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 471);
            this.Controls.Add(this.groupBoxCuentaadmin);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxCAdmin);
            this.Controls.Add(this.textBoxCEAdmin);
            this.Controls.Add(this.textBoxNAdmin);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelMiCuenta);
            this.Controls.Add(this.ToolStripBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Micuenta";
            this.Text = "Micuenta";
            this.Activated += new System.EventHandler(this.Micuenta_Activated);
            this.Load += new System.EventHandler(this.Micuenta_Load);
            this.ToolStripBarra.ResumeLayout(false);
            this.ToolStripBarra.PerformLayout();
            this.groupBoxCuentaadmin.ResumeLayout(false);
            this.groupBoxCuentaadmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripBarra;
        private System.Windows.Forms.ToolStripButton toolStripButtonGestionAdministradores;
        private System.Windows.Forms.ToolStripButton toolStripButtonLibrerias;
        private System.Windows.Forms.ToolStripButton toolStripButtonActividades;
        private System.Windows.Forms.Label labelMiCuenta;
        private System.Windows.Forms.GroupBox groupBoxCuentaadmin;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxCorreoelectronico;
        private System.Windows.Forms.TextBox textBoxnombreyappelido;
        private System.Windows.Forms.TextBox textBoxCuentaAdmin;
        private System.Windows.Forms.Label labelAdmincorreo;
        private System.Windows.Forms.Label labelNombreAdmin;
        private System.Windows.Forms.Label labelGAdmin;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxCAdmin;
        private System.Windows.Forms.TextBox textBoxCEAdmin;
        private System.Windows.Forms.TextBox textBoxNAdmin;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
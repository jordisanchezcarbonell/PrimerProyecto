namespace LiberMiCuenta
{
    partial class listadeadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listadeadmin));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelMiCuenta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxcontraseña2 = new System.Windows.Forms.TextBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.labelcontraseña2 = new System.Windows.Forms.Label();
            this.textBoxCAdmin = new System.Windows.Forms.TextBox();
            this.textBoxCEAdmin = new System.Windows.Forms.TextBox();
            this.textBoxNAdmin = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.groupBoxLAdmin = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxLAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMiCuenta
            // 
            this.labelMiCuenta.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelMiCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiCuenta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMiCuenta.Location = new System.Drawing.Point(-6, 0);
            this.labelMiCuenta.Name = "labelMiCuenta";
            this.labelMiCuenta.Padding = new System.Windows.Forms.Padding(260, 2, 0, 0);
            this.labelMiCuenta.Size = new System.Drawing.Size(1104, 37);
            this.labelMiCuenta.TabIndex = 19;
            this.labelMiCuenta.Text = "Lista de  Administradores";
            this.labelMiCuenta.Click += new System.EventHandler(this.labelMiCuenta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(591, 161);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(116, 23);
            this.buttonEliminar.TabIndex = 31;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxcontraseña2
            // 
            this.textBoxcontraseña2.Location = new System.Drawing.Point(246, 185);
            this.textBoxcontraseña2.Name = "textBoxcontraseña2";
            this.textBoxcontraseña2.Size = new System.Drawing.Size(230, 20);
            this.textBoxcontraseña2.TabIndex = 40;
            this.textBoxcontraseña2.UseSystemPasswordChar = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(591, 111);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(116, 23);
            this.buttonModificar.TabIndex = 30;
            this.buttonModificar.Text = "Guardar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click_1);
            // 
            // labelcontraseña2
            // 
            this.labelcontraseña2.AutoSize = true;
            this.labelcontraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelcontraseña2.Location = new System.Drawing.Point(91, 185);
            this.labelcontraseña2.Name = "labelcontraseña2";
            this.labelcontraseña2.Size = new System.Drawing.Size(81, 17);
            this.labelcontraseña2.TabIndex = 39;
            this.labelcontraseña2.Text = "Contraseña";
            this.labelcontraseña2.Click += new System.EventHandler(this.labelcontraseña2_Click);
            // 
            // textBoxCAdmin
            // 
            this.textBoxCAdmin.Location = new System.Drawing.Point(246, 145);
            this.textBoxCAdmin.Name = "textBoxCAdmin";
            this.textBoxCAdmin.Size = new System.Drawing.Size(230, 20);
            this.textBoxCAdmin.TabIndex = 38;
            this.textBoxCAdmin.UseSystemPasswordChar = true;
            // 
            // textBoxCEAdmin
            // 
            this.textBoxCEAdmin.Location = new System.Drawing.Point(246, 99);
            this.textBoxCEAdmin.Name = "textBoxCEAdmin";
            this.textBoxCEAdmin.Size = new System.Drawing.Size(230, 20);
            this.textBoxCEAdmin.TabIndex = 37;
            // 
            // textBoxNAdmin
            // 
            this.textBoxNAdmin.Location = new System.Drawing.Point(246, 56);
            this.textBoxNAdmin.Name = "textBoxNAdmin";
            this.textBoxNAdmin.Size = new System.Drawing.Size(230, 20);
            this.textBoxNAdmin.TabIndex = 36;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelContraseña.Location = new System.Drawing.Point(91, 145);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(81, 17);
            this.labelContraseña.TabIndex = 35;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelemail.Location = new System.Drawing.Point(91, 99);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(124, 17);
            this.labelemail.TabIndex = 34;
            this.labelemail.Text = "Correo electronico";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelnombre.Location = new System.Drawing.Point(91, 56);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(92, 17);
            this.labelnombre.TabIndex = 33;
            this.labelnombre.Text = "Nuevo Admin";
            // 
            // groupBoxLAdmin
            // 
            this.groupBoxLAdmin.Controls.Add(this.dataGridView1);
            this.groupBoxLAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxLAdmin.Location = new System.Drawing.Point(94, 232);
            this.groupBoxLAdmin.Name = "groupBoxLAdmin";
            this.groupBoxLAdmin.Size = new System.Drawing.Size(912, 325);
            this.groupBoxLAdmin.TabIndex = 29;
            this.groupBoxLAdmin.TabStop = false;
            this.groupBoxLAdmin.Text = "Lista de Admin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.nombre});
            this.dataGridView1.Location = new System.Drawing.Point(15, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 241);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // listadeadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxcontraseña2);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.labelcontraseña2);
            this.Controls.Add(this.textBoxCAdmin);
            this.Controls.Add(this.textBoxCEAdmin);
            this.Controls.Add(this.textBoxNAdmin);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.groupBoxLAdmin);
            this.Controls.Add(this.labelMiCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "listadeadmin";
            this.Text = "listadeadmin";
            this.Activated += new System.EventHandler(this.listadeadmin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.listadeadmin_FormClosing);
            this.Load += new System.EventHandler(this.listadeadmin_Load);
            this.groupBoxLAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelMiCuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxcontraseña2;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelcontraseña2;
        private System.Windows.Forms.TextBox textBoxCAdmin;
        private System.Windows.Forms.TextBox textBoxCEAdmin;
        private System.Windows.Forms.TextBox textBoxNAdmin;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.GroupBox groupBoxLAdmin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}
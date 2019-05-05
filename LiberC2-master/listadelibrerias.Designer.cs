namespace LiberMiCuenta
{
    partial class listadelibrerias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listadelibrerias));
            this.ToolStripBarra = new System.Windows.Forms.ToolStrip();
            this.labelMiCuenta = new System.Windows.Forms.Label();
            this.groupBoxLAdmin = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxLAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripBarra
            // 
            this.ToolStripBarra.BackColor = System.Drawing.Color.White;
            this.ToolStripBarra.GripMargin = new System.Windows.Forms.Padding(500, 2, 2, 500);
            this.ToolStripBarra.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ToolStripBarra.Location = new System.Drawing.Point(0, 0);
            this.ToolStripBarra.Name = "ToolStripBarra";
            this.ToolStripBarra.Size = new System.Drawing.Size(924, 25);
            this.ToolStripBarra.TabIndex = 20;
            this.ToolStripBarra.Text = "toolStrip1";
            // 
            // labelMiCuenta
            // 
            this.labelMiCuenta.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelMiCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiCuenta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMiCuenta.Location = new System.Drawing.Point(-6, 0);
            this.labelMiCuenta.Name = "labelMiCuenta";
            this.labelMiCuenta.Padding = new System.Windows.Forms.Padding(260, 2, 0, 0);
            this.labelMiCuenta.Size = new System.Drawing.Size(930, 37);
            this.labelMiCuenta.TabIndex = 22;
            this.labelMiCuenta.Text = "Lista de Librerias";
            // 
            // groupBoxLAdmin
            // 
            this.groupBoxLAdmin.Controls.Add(this.dataGridView1);
            this.groupBoxLAdmin.Controls.Add(this.button1);
            this.groupBoxLAdmin.Controls.Add(this.buttonEliminar);
            this.groupBoxLAdmin.Controls.Add(this.buttonGuardar);
            this.groupBoxLAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxLAdmin.Location = new System.Drawing.Point(87, 69);
            this.groupBoxLAdmin.Name = "groupBoxLAdmin";
            this.groupBoxLAdmin.Size = new System.Drawing.Size(703, 325);
            this.groupBoxLAdmin.TabIndex = 24;
            this.groupBoxLAdmin.TabStop = false;
            this.groupBoxLAdmin.Text = "Lista de Librerias";
            this.groupBoxLAdmin.Enter += new System.EventHandler(this.groupBoxLAdmin_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Direccion,
            this.descripcion,
            this.Contacto,
            this.horario,
            this.horarioesp});
            this.dataGridView1.Location = new System.Drawing.Point(19, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 250);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 81;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // Contacto
            // 
            this.Contacto.DataPropertyName = "Contacto";
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            // 
            // horario
            // 
            this.horario.DataPropertyName = "Horario";
            this.horario.HeaderText = "horario";
            this.horario.Name = "horario";
            // 
            // horarioesp
            // 
            this.horarioesp.DataPropertyName = "Horarioesp";
            this.horarioesp.HeaderText = "horarioesp";
            this.horarioesp.Name = "horarioesp";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(253, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonEliminar.Location = new System.Drawing.Point(570, 279);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(116, 25);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonGuardar.Location = new System.Drawing.Point(409, 279);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(116, 25);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // listadelibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 471);
            this.Controls.Add(this.groupBoxLAdmin);
            this.Controls.Add(this.labelMiCuenta);
            this.Controls.Add(this.ToolStripBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "listadelibrerias";
            this.Text = "Lista de librerias";
            this.Activated += new System.EventHandler(this.listadelibrerias_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.listadelibrerias_FormClosing);
            this.Load += new System.EventHandler(this.listadelibrerias_Load);
            this.groupBoxLAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripBarra;
        private System.Windows.Forms.Label labelMiCuenta;
        private System.Windows.Forms.GroupBox groupBoxLAdmin;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioesp;
    }
}
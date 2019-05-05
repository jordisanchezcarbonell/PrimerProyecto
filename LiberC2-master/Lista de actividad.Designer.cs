namespace LiberMiCuenta
{
    partial class Lista_de_actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_actividad));
            this.ToolStripBarra = new System.Windows.Forms.ToolStrip();
            this.labelMiCuenta = new System.Windows.Forms.Label();
            this.groupBoxLAdmin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recompensas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Librerias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.groupBoxLAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
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
            this.ToolStripBarra.TabIndex = 19;
            this.ToolStripBarra.Text = "toolStrip1";
            // 
            // labelMiCuenta
            // 
            this.labelMiCuenta.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelMiCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiCuenta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMiCuenta.Location = new System.Drawing.Point(-6, 0);
            this.labelMiCuenta.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.labelMiCuenta.Name = "labelMiCuenta";
            this.labelMiCuenta.Padding = new System.Windows.Forms.Padding(260, 2, 0, 0);
            this.labelMiCuenta.Size = new System.Drawing.Size(930, 37);
            this.labelMiCuenta.TabIndex = 21;
            this.labelMiCuenta.Text = "         Lista de Actividades";
            // 
            // groupBoxLAdmin
            // 
            this.groupBoxLAdmin.Controls.Add(this.button1);
            this.groupBoxLAdmin.Controls.Add(this.dataGridViewActividades);
            this.groupBoxLAdmin.Controls.Add(this.buttonEliminar);
            this.groupBoxLAdmin.Controls.Add(this.buttonModificar);
            this.groupBoxLAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxLAdmin.Location = new System.Drawing.Point(111, 73);
            this.groupBoxLAdmin.Name = "groupBoxLAdmin";
            this.groupBoxLAdmin.Size = new System.Drawing.Size(703, 325);
            this.groupBoxLAdmin.TabIndex = 23;
            this.groupBoxLAdmin.TabStop = false;
            this.groupBoxLAdmin.Text = "Lista de Actividades";
            this.groupBoxLAdmin.Enter += new System.EventHandler(this.groupBoxLAdmin_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(257, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Descripcion,
            this.Recompensas,
            this.Hora,
            this.Contacto,
            this.Ubicacion,
            this.Librerias});
            this.dataGridViewActividades.Location = new System.Drawing.Point(15, 32);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.Size = new System.Drawing.Size(671, 241);
            this.dataGridViewActividades.TabIndex = 3;
            this.dataGridViewActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActividades_CellContentClick);
            // 
            // Actividad
            // 
            this.Actividad.DataPropertyName = "Nombre";
            this.Actividad.HeaderText = "Nombre Actividad";
            this.Actividad.Name = "Actividad";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion Actividad";
            this.Descripcion.Name = "Descripcion";
            // 
            // Recompensas
            // 
            this.Recompensas.DataPropertyName = "recompensaPTS";
            this.Recompensas.HeaderText = "Recompensas";
            this.Recompensas.Name = "Recompensas";
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "horario";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Contacto
            // 
            this.Contacto.DataPropertyName = "contacto";
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            // 
            // Librerias
            // 
            this.Librerias.DataPropertyName = "Librerias";
            this.Librerias.HeaderText = "Nombre Libreria";
            this.Librerias.Name = "Librerias";
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
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonModificar.Location = new System.Drawing.Point(409, 279);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(116, 25);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Guardar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // Lista_de_actividad
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
            this.Name = "Lista_de_actividad";
            this.Text = "Lista_de_actividad";
            this.Activated += new System.EventHandler(this.Lista_de_actividad_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lista_de_actividad_FormClosing);
            this.Load += new System.EventHandler(this.Lista_de_actividad_Load);
            this.groupBoxLAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripBarra;
        private System.Windows.Forms.Label labelMiCuenta;
        private System.Windows.Forms.GroupBox groupBoxLAdmin;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recompensas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Librerias;
    }
}
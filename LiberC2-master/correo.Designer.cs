namespace LiberMiCuenta
{
    partial class correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(correo));
            this.labelCorreorecu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCorreorecu
            // 
            this.labelCorreorecu.AutoSize = true;
            this.labelCorreorecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreorecu.Location = new System.Drawing.Point(48, 98);
            this.labelCorreorecu.Name = "labelCorreorecu";
            this.labelCorreorecu.Size = new System.Drawing.Size(70, 25);
            this.labelCorreorecu.TabIndex = 0;
            this.labelCorreorecu.Text = "label1";
            this.labelCorreorecu.Click += new System.EventHandler(this.labelCorreorecu_Click);
            // 
            // correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 233);
            this.Controls.Add(this.labelCorreorecu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "correo";
            this.Text = "correo";
            this.Load += new System.EventHandler(this.correo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCorreorecu;
    }
}
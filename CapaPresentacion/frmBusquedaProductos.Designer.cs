namespace CapaPresentacion
{
    partial class frmBusquedaProductos
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
            this.btnPasar = new System.Windows.Forms.Button();
            this.txtPasar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPasar
            // 
            this.btnPasar.Location = new System.Drawing.Point(453, 81);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(75, 23);
            this.btnPasar.TabIndex = 0;
            this.btnPasar.Text = "Pasar";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPasar
            // 
            this.txtPasar.Location = new System.Drawing.Point(202, 81);
            this.txtPasar.Name = "txtPasar";
            this.txtPasar.Size = new System.Drawing.Size(245, 22);
            this.txtPasar.TabIndex = 1;
            // 
            // frmBusquedaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPasar);
            this.Controls.Add(this.btnPasar);
            this.Name = "frmBusquedaProductos";
            this.Text = "frmBusquedaProductos";
            this.Load += new System.EventHandler(this.frmBusquedaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasar;
        private System.Windows.Forms.TextBox txtPasar;
    }
}
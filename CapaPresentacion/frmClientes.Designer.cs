namespace CapaPresentacion
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pcbClose = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaSocio = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblFechaSocio = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.txtApell2 = new System.Windows.Forms.TextBox();
            this.lblApell2 = new System.Windows.Forms.Label();
            this.txtApell1 = new System.Windows.Forms.TextBox();
            this.lblApell1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbTipoId = new System.Windows.Forms.ComboBox();
            this.lblTipoId = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlTitulo.Controls.Add(this.pnlOpciones);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(505, 53);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.pcbClose);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpciones.Location = new System.Drawing.Point(363, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(142, 53);
            this.pnlOpciones.TabIndex = 2;
            // 
            // pcbClose
            // 
            this.pcbClose.Image = ((System.Drawing.Image)(resources.GetObject("pcbClose.Image")));
            this.pcbClose.Location = new System.Drawing.Point(92, 3);
            this.pcbClose.Name = "pcbClose";
            this.pcbClose.Size = new System.Drawing.Size(38, 38);
            this.pcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbClose.TabIndex = 1;
            this.pcbClose.TabStop = false;
            this.pcbClose.Click += new System.EventHandler(this.pcbClose_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(139, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(268, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 42);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(397, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 42);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaSocio);
            this.groupBox1.Controls.Add(this.cmbTipoCliente);
            this.groupBox1.Controls.Add(this.lblFechaSocio);
            this.groupBox1.Controls.Add(this.lblTipoCliente);
            this.groupBox1.Controls.Add(this.txtApell2);
            this.groupBox1.Controls.Add(this.lblApell2);
            this.groupBox1.Controls.Add(this.txtApell1);
            this.groupBox1.Controls.Add(this.lblApell1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.cmbTipoId);
            this.groupBox1.Controls.Add(this.lblTipoId);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.lblIdentificacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 251);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Clientes";
            // 
            // dtpFechaSocio
            // 
            this.dtpFechaSocio.Location = new System.Drawing.Point(160, 207);
            this.dtpFechaSocio.Name = "dtpFechaSocio";
            this.dtpFechaSocio.Size = new System.Drawing.Size(300, 22);
            this.dtpFechaSocio.TabIndex = 13;
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(160, 177);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(300, 24);
            this.cmbTipoCliente.TabIndex = 12;
            // 
            // lblFechaSocio
            // 
            this.lblFechaSocio.AutoSize = true;
            this.lblFechaSocio.Location = new System.Drawing.Point(20, 212);
            this.lblFechaSocio.Name = "lblFechaSocio";
            this.lblFechaSocio.Size = new System.Drawing.Size(134, 16);
            this.lblFechaSocio.TabIndex = 11;
            this.lblFechaSocio.Text = "Fecha de Inscripción:";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(53, 185);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(101, 16);
            this.lblTipoCliente.TabIndex = 10;
            this.lblTipoCliente.Text = "Tipo de Cliente:";
            // 
            // txtApell2
            // 
            this.txtApell2.Location = new System.Drawing.Point(160, 149);
            this.txtApell2.Name = "txtApell2";
            this.txtApell2.Size = new System.Drawing.Size(300, 22);
            this.txtApell2.TabIndex = 9;
            // 
            // lblApell2
            // 
            this.lblApell2.AutoSize = true;
            this.lblApell2.Location = new System.Drawing.Point(36, 155);
            this.lblApell2.Name = "lblApell2";
            this.lblApell2.Size = new System.Drawing.Size(118, 16);
            this.lblApell2.TabIndex = 8;
            this.lblApell2.Text = "Segundo Apellido:";
            // 
            // txtApell1
            // 
            this.txtApell1.Location = new System.Drawing.Point(160, 121);
            this.txtApell1.Name = "txtApell1";
            this.txtApell1.Size = new System.Drawing.Size(300, 22);
            this.txtApell1.TabIndex = 7;
            // 
            // lblApell1
            // 
            this.lblApell1.AutoSize = true;
            this.lblApell1.Location = new System.Drawing.Point(52, 124);
            this.lblApell1.Name = "lblApell1";
            this.lblApell1.Size = new System.Drawing.Size(102, 16);
            this.lblApell1.TabIndex = 6;
            this.lblApell1.Text = "Primer Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(95, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbTipoId
            // 
            this.cmbTipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoId.FormattingEnabled = true;
            this.cmbTipoId.Location = new System.Drawing.Point(160, 63);
            this.cmbTipoId.Name = "cmbTipoId";
            this.cmbTipoId.Size = new System.Drawing.Size(300, 24);
            this.cmbTipoId.TabIndex = 3;
            this.cmbTipoId.SelectedIndexChanged += new System.EventHandler(this.cmbTipoId_SelectedIndexChanged);
            // 
            // lblTipoId
            // 
            this.lblTipoId.AutoSize = true;
            this.lblTipoId.Location = new System.Drawing.Point(35, 66);
            this.lblTipoId.Name = "lblTipoId";
            this.lblTipoId.Size = new System.Drawing.Size(119, 16);
            this.lblTipoId.TabIndex = 2;
            this.lblTipoId.Text = "Tipo Identificación:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(160, 35);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(300, 22);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(66, 38);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(88, 16);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pcbClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoId;
        private System.Windows.Forms.Label lblTipoId;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtApell2;
        private System.Windows.Forms.Label lblApell2;
        private System.Windows.Forms.TextBox txtApell1;
        private System.Windows.Forms.Label lblApell1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaSocio;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label lblFechaSocio;
        private System.Windows.Forms.Label lblTipoCliente;
    }
}
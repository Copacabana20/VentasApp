namespace VentasApp.Forms.ControlesDeUsuario
{
    partial class HeaderUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblLocalidad = new System.Windows.Forms.Label();
            this.LblCuit = new System.Windows.Forms.Label();
            this.LblIngBrutos = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::VentasApp.Properties.Resources.logoBrantyVentas;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(220, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(805, 65);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "label1";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDireccion
            // 
            this.LblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.LblDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDireccion.ForeColor = System.Drawing.Color.White;
            this.LblDireccion.Location = new System.Drawing.Point(3, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(259, 60);
            this.LblDireccion.TabIndex = 2;
            this.LblDireccion.Text = "Direccion";
            this.LblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLocalidad
            // 
            this.LblLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.LblLocalidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblLocalidad.ForeColor = System.Drawing.Color.White;
            this.LblLocalidad.Location = new System.Drawing.Point(3, 60);
            this.LblLocalidad.Name = "LblLocalidad";
            this.LblLocalidad.Size = new System.Drawing.Size(259, 78);
            this.LblLocalidad.TabIndex = 3;
            this.LblLocalidad.Text = "Localidad";
            this.LblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCuit
            // 
            this.LblCuit.BackColor = System.Drawing.Color.Transparent;
            this.LblCuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblCuit.ForeColor = System.Drawing.Color.White;
            this.LblCuit.Location = new System.Drawing.Point(268, 60);
            this.LblCuit.Name = "LblCuit";
            this.LblCuit.Size = new System.Drawing.Size(267, 78);
            this.LblCuit.TabIndex = 4;
            this.LblCuit.Text = "Cuit";
            this.LblCuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblIngBrutos
            // 
            this.LblIngBrutos.BackColor = System.Drawing.Color.Transparent;
            this.LblIngBrutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblIngBrutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblIngBrutos.ForeColor = System.Drawing.Color.White;
            this.LblIngBrutos.Location = new System.Drawing.Point(268, 0);
            this.LblIngBrutos.Name = "LblIngBrutos";
            this.LblIngBrutos.Size = new System.Drawing.Size(267, 60);
            this.LblIngBrutos.TabIndex = 5;
            this.LblIngBrutos.Text = "IngresosBrutos";
            this.LblIngBrutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(541, 60);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(261, 78);
            this.LblFecha.TabIndex = 7;
            this.LblFecha.Text = "Fecha";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTelefono
            // 
            this.LblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LblTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblTelefono.ForeColor = System.Drawing.Color.White;
            this.LblTelefono.Location = new System.Drawing.Point(541, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(261, 60);
            this.LblTelefono.TabIndex = 6;
            this.LblTelefono.Text = "Telefono";
            this.LblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.LblLocalidad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTelefono, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblFecha, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDireccion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblIngBrutos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblCuit, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(220, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 138);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // HeaderUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HeaderUc";
            this.Size = new System.Drawing.Size(1025, 203);
            this.Load += new System.EventHandler(this.HeaderUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblLocalidad;
        private System.Windows.Forms.Label LblCuit;
        private System.Windows.Forms.Label LblIngBrutos;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

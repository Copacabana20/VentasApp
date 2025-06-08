namespace VentasApp.Forms
{
    partial class VentasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //private System.Windows.Forms.Label lblNombreNegocio;
        //private System.Windows.Forms.Button btnAbrirCaja;
        //private System.Windows.Forms.Button btnCerrarCaja;
        //private System.Windows.Forms.Button btnProductos;
        //private System.Windows.Forms.Button btnReportes;
        //private System.Windows.Forms.DataGridView dgvVenta;
        //private System.Windows.Forms.TextBox txtCodigo;
        //private System.Windows.Forms.Label lblTotal;
        //private System.Windows.Forms.Button btnFinalizarVenta;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 615);
            this.Name = "VentasForm";
            this.Text = "VentasForm";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            this.ResumeLayout(false);

        }

        

        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    lblNombreNegocio = new System.Windows.Forms.Label();
        //    this.btnAbrirCaja = new System.Windows.Forms.Button();
        //    this.btnCerrarCaja = new System.Windows.Forms.Button();
        //    this.btnProductos = new System.Windows.Forms.Button();
        //    this.btnReportes = new System.Windows.Forms.Button();
        //    this.dgvVenta = new System.Windows.Forms.DataGridView();
        //    this.txtCodigo = new System.Windows.Forms.TextBox();
        //    this.lblTotal = new System.Windows.Forms.Label();
        //    this.btnFinalizarVenta = new System.Windows.Forms.Button();

        //    ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
        //    this.SuspendLayout();

        //    // lblNombreNegocio
        //    this.lblNombreNegocio.AutoSize = true;
        //    this.lblNombreNegocio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        //    this.lblNombreNegocio.Location = new System.Drawing.Point(20, 10);
        //    this.lblNombreNegocio.Name = "lblNombreNegocio";
        //    this.lblNombreNegocio.Size = new System.Drawing.Size(180, 30);
        //    this.lblNombreNegocio.Text = "Branty Ventas";

        //    // btnAbrirCaja
        //    this.btnAbrirCaja.Location = new System.Drawing.Point(600, 10);
        //    this.btnAbrirCaja.Name = "btnAbrirCaja";
        //    this.btnAbrirCaja.Size = new System.Drawing.Size(80, 30);
        //    this.btnAbrirCaja.Text = "Abrir Caja";
        //    this.btnAbrirCaja.UseVisualStyleBackColor = true;

        //    // btnCerrarCaja
        //    this.btnCerrarCaja.Location = new System.Drawing.Point(690, 10);
        //    this.btnCerrarCaja.Name = "btnCerrarCaja";
        //    this.btnCerrarCaja.Size = new System.Drawing.Size(80, 30);
        //    this.btnCerrarCaja.Text = "Cerrar Caja";
        //    this.btnCerrarCaja.UseVisualStyleBackColor = true;

        //    // btnProductos
        //    this.btnProductos.Location = new System.Drawing.Point(20, 50);
        //    this.btnProductos.Name = "btnProductos";
        //    this.btnProductos.Size = new System.Drawing.Size(90, 30);
        //    this.btnProductos.Text = "Productos";
        //    this.btnProductos.UseVisualStyleBackColor = true;

        //    // btnReportes
        //    this.btnReportes.Location = new System.Drawing.Point(120, 50);
        //    this.btnReportes.Name = "btnReportes";
        //    this.btnReportes.Size = new System.Drawing.Size(90, 30);
        //    this.btnReportes.Text = "Reportes";
        //    this.btnReportes.UseVisualStyleBackColor = true;

        //    // txtCodigo
        //    this.txtCodigo.Location = new System.Drawing.Point(20, 100);
        //    this.txtCodigo.Name = "txtCodigo";
        //    this.txtCodigo.PlaceholderText = "Escanear o ingresar código";
        //    this.txtCodigo.Size = new System.Drawing.Size(300, 23);

        //    // dgvVenta
        //    this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    this.dgvVenta.Location = new System.Drawing.Point(20, 140);
        //    this.dgvVenta.Name = "dgvVenta";
        //    this.dgvVenta.Size = new System.Drawing.Size(740, 300);
        //    this.dgvVenta.AllowUserToAddRows = false;
        //    this.dgvVenta.ReadOnly = true;

        //    // dgvVenta columns
        //    this.dgvVenta.Columns.Add("Producto", "Producto");
        //    this.dgvVenta.Columns.Add("Cantidad", "Cantidad");
        //    this.dgvVenta.Columns.Add("Precio", "Precio");
        //    this.dgvVenta.Columns.Add("Subtotal", "Subtotal");

        //    // lblTotal
        //    this.lblTotal.AutoSize = true;
        //    this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        //    this.lblTotal.Location = new System.Drawing.Point(600, 450);
        //    this.lblTotal.Name = "lblTotal";
        //    this.lblTotal.Size = new System.Drawing.Size(90, 25);
        //    this.lblTotal.Text = "Total: $0.00";

        //    // btnFinalizarVenta
        //    this.btnFinalizarVenta.BackColor = System.Drawing.Color.Green;
        //    this.btnFinalizarVenta.ForeColor = System.Drawing.Color.White;
        //    this.btnFinalizarVenta.Location = new System.Drawing.Point(600, 500);
        //    this.btnFinalizarVenta.Name = "btnFinalizarVenta";
        //    this.btnFinalizarVenta.Size = new System.Drawing.Size(160, 40);
        //    this.btnFinalizarVenta.Text = "Finalizar Venta";
        //    this.btnFinalizarVenta.UseVisualStyleBackColor = false;

        //    // MainForm
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        //    this.ClientSize = new System.Drawing.Size(800, 560);
        //    this.Controls.Add(lblNombreNegocio);
        //    this.Controls.Add(this.btnAbrirCaja);
        //    this.Controls.Add(this.btnCerrarCaja);
        //    this.Controls.Add(this.btnProductos);
        //    this.Controls.Add(this.btnReportes);
        //    this.Controls.Add(this.txtCodigo);
        //    this.Controls.Add(this.dgvVenta);
        //    this.Controls.Add(this.lblTotal);
        //    this.Controls.Add(this.btnFinalizarVenta);
        //    this.Name = "MainForm";
        //    this.Text = "Branty Ventas";

        //    ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();
        //}

    }
}

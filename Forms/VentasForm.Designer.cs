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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblHeaderArticulos = new System.Windows.Forms.Label();
            this.LblHeaderSubTotal = new System.Windows.Forms.Label();
            this.LblArticulos = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.PnlHeaderVentas = new System.Windows.Forms.Panel();
            this.iconBtnAbrirCerrarCaja = new FontAwesome.Sharp.IconButton();
            this.LblFechaApertura = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.PnlHeaderVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DgvVentas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PnlHeaderVentas, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgvVentas
            // 
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvVentas.Location = new System.Drawing.Point(3, 39);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.RowHeadersWidth = 51;
            this.DgvVentas.RowTemplate.Height = 24;
            this.DgvVentas.Size = new System.Drawing.Size(1014, 578);
            this.DgvVentas.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.LblCodigo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblHeaderArticulos, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblHeaderSubTotal, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblArticulos, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblSubTotal, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtCodigo, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 623);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1014, 104);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LblCodigo
            // 
            this.LblCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCodigo.Location = new System.Drawing.Point(6, 3);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(294, 23);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "CODIGO";
            this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHeaderArticulos
            // 
            this.LblHeaderArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblHeaderArticulos.Location = new System.Drawing.Point(309, 3);
            this.LblHeaderArticulos.Name = "LblHeaderArticulos";
            this.LblHeaderArticulos.Size = new System.Drawing.Size(394, 23);
            this.LblHeaderArticulos.TabIndex = 1;
            this.LblHeaderArticulos.Text = "ARTICULOS";
            this.LblHeaderArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHeaderSubTotal
            // 
            this.LblHeaderSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblHeaderSubTotal.Location = new System.Drawing.Point(712, 3);
            this.LblHeaderSubTotal.Name = "LblHeaderSubTotal";
            this.LblHeaderSubTotal.Size = new System.Drawing.Size(296, 23);
            this.LblHeaderSubTotal.TabIndex = 2;
            this.LblHeaderSubTotal.Text = "TOTAL";
            this.LblHeaderSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblArticulos
            // 
            this.LblArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblArticulos.Location = new System.Drawing.Point(309, 29);
            this.LblArticulos.Name = "LblArticulos";
            this.LblArticulos.Size = new System.Drawing.Size(394, 72);
            this.LblArticulos.TabIndex = 3;
            this.LblArticulos.Text = "0";
            this.LblArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSubTotal.Location = new System.Drawing.Point(712, 29);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(296, 72);
            this.LblSubTotal.TabIndex = 4;
            this.LblSubTotal.Text = "$0.00";
            this.LblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(6, 33);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(294, 64);
            this.TxtCodigo.TabIndex = 5;
            this.TxtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyUp);
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // PnlHeaderVentas
            // 
            this.PnlHeaderVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PnlHeaderVentas.Controls.Add(this.LblFechaApertura);
            this.PnlHeaderVentas.Controls.Add(this.iconBtnAbrirCerrarCaja);
            this.PnlHeaderVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHeaderVentas.Location = new System.Drawing.Point(3, 3);
            this.PnlHeaderVentas.Name = "PnlHeaderVentas";
            this.PnlHeaderVentas.Size = new System.Drawing.Size(1014, 30);
            this.PnlHeaderVentas.TabIndex = 2;
            // 
            // iconBtnAbrirCerrarCaja
            // 
            this.iconBtnAbrirCerrarCaja.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnAbrirCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconBtnAbrirCerrarCaja.IconColor = System.Drawing.Color.Black;
            this.iconBtnAbrirCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAbrirCerrarCaja.IconSize = 25;
            this.iconBtnAbrirCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnAbrirCerrarCaja.Location = new System.Drawing.Point(777, 0);
            this.iconBtnAbrirCerrarCaja.Name = "iconBtnAbrirCerrarCaja";
            this.iconBtnAbrirCerrarCaja.Size = new System.Drawing.Size(237, 30);
            this.iconBtnAbrirCerrarCaja.TabIndex = 0;
            this.iconBtnAbrirCerrarCaja.Text = "Abrir caja";
            this.iconBtnAbrirCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAbrirCerrarCaja.UseVisualStyleBackColor = true;
            this.iconBtnAbrirCerrarCaja.Click += new System.EventHandler(this.iconBtnAbrirCerrarCaja_Click);
            // 
            // LblFechaApertura
            // 
            this.LblFechaApertura.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblFechaApertura.ForeColor = System.Drawing.Color.White;
            this.LblFechaApertura.Location = new System.Drawing.Point(0, 0);
            this.LblFechaApertura.Name = "LblFechaApertura";
            this.LblFechaApertura.Size = new System.Drawing.Size(703, 30);
            this.LblFechaApertura.TabIndex = 1;
            this.LblFechaApertura.Text = "label1";
            this.LblFechaApertura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VentasForm";
            this.Text = "VentasForm";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.PnlHeaderVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblHeaderArticulos;
        private System.Windows.Forms.Label LblHeaderSubTotal;
        private System.Windows.Forms.Label LblArticulos;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Panel PnlHeaderVentas;
        private FontAwesome.Sharp.IconButton iconBtnAbrirCerrarCaja;
        private System.Windows.Forms.Label LblFechaApertura;
    }
}

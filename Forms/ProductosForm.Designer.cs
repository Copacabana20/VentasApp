using System.Windows.Forms;

namespace VentasApp.Forms
{
    partial class ProductosForm
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.iconBtnGuardar = new FontAwesome.Sharp.IconButton();
            this.iconBtnEditProd = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconBtnEditCod = new FontAwesome.Sharp.IconButton();
            this.LblUltActualizacion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlCargaProductos = new System.Windows.Forms.Panel();
            this.PnlGridProductos = new System.Windows.Forms.Panel();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlCargaProductos.SuspendLayout();
            this.PnlGridProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(16, 17);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(75, 25);
            this.LblCodigo.TabIndex = 4;
            this.LblCodigo.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TxtCodigo.Location = new System.Drawing.Point(19, 48);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(393, 55);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyUp);
            // 
            // TxtProducto
            // 
            this.TxtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TxtProducto.Location = new System.Drawing.Point(19, 216);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(393, 55);
            this.TxtProducto.TabIndex = 2;
            this.TxtProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtProducto_KeyUp);
            // 
            // LblProducto
            // 
            this.LblProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(14, 183);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(193, 25);
            this.LblProducto.TabIndex = 5;
            this.LblProducto.Text = "Nombre del producto";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TxtPrecio.Location = new System.Drawing.Point(75, 350);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(337, 55);
            this.TxtPrecio.TabIndex = 3;
            this.TxtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPrecio_KeyDown);
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            this.TxtPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrecio_KeyUp);
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(16, 319);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(67, 25);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio";
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBusqueda.Location = new System.Drawing.Point(0, 0);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(1021, 51);
            this.LblBusqueda.TabIndex = 8;
            this.LblBusqueda.Text = "Buscar productos";
            this.LblBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // iconBtnGuardar
            // 
            this.iconBtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnGuardar.BackColor = System.Drawing.Color.Green;
            this.iconBtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconBtnGuardar.FlatAppearance.BorderSize = 2;
            this.iconBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.iconBtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iconBtnGuardar.IconColor = System.Drawing.Color.White;
            this.iconBtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnGuardar.IconSize = 40;
            this.iconBtnGuardar.Location = new System.Drawing.Point(19, 428);
            this.iconBtnGuardar.Name = "iconBtnGuardar";
            this.iconBtnGuardar.Padding = new System.Windows.Forms.Padding(10);
            this.iconBtnGuardar.Size = new System.Drawing.Size(393, 70);
            this.iconBtnGuardar.TabIndex = 7;
            this.iconBtnGuardar.Text = "GUARDAR";
            this.iconBtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnGuardar.UseVisualStyleBackColor = false;
            this.iconBtnGuardar.Click += new System.EventHandler(this.iconBtnGuardar_Click);
            // 
            // iconBtnEditProd
            // 
            this.iconBtnEditProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnEditProd.BackColor = System.Drawing.Color.White;
            this.iconBtnEditProd.FlatAppearance.BorderSize = 0;
            this.iconBtnEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEditProd.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.iconBtnEditProd.IconColor = System.Drawing.Color.Black;
            this.iconBtnEditProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnEditProd.IconSize = 40;
            this.iconBtnEditProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnEditProd.Location = new System.Drawing.Point(360, 218);
            this.iconBtnEditProd.Name = "iconBtnEditProd";
            this.iconBtnEditProd.Size = new System.Drawing.Size(50, 50);
            this.iconBtnEditProd.TabIndex = 9;
            this.iconBtnEditProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnEditProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconBtnEditProd.UseVisualStyleBackColor = false;
            this.iconBtnEditProd.Visible = false;
            this.iconBtnEditProd.Click += new System.EventHandler(this.iconBtnEditProd_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.ImageLocation = "";
            this.iconPictureBox1.Location = new System.Drawing.Point(19, 350);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(56, 55);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconBtnEditCod
            // 
            this.iconBtnEditCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnEditCod.BackColor = System.Drawing.Color.White;
            this.iconBtnEditCod.FlatAppearance.BorderSize = 0;
            this.iconBtnEditCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEditCod.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.iconBtnEditCod.IconColor = System.Drawing.Color.Black;
            this.iconBtnEditCod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnEditCod.IconSize = 40;
            this.iconBtnEditCod.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnEditCod.Location = new System.Drawing.Point(360, 50);
            this.iconBtnEditCod.Name = "iconBtnEditCod";
            this.iconBtnEditCod.Size = new System.Drawing.Size(50, 50);
            this.iconBtnEditCod.TabIndex = 11;
            this.iconBtnEditCod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnEditCod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconBtnEditCod.UseVisualStyleBackColor = false;
            this.iconBtnEditCod.Visible = false;
            this.iconBtnEditCod.Click += new System.EventHandler(this.iconBtnEditCod_Click);
            // 
            // LblUltActualizacion
            // 
            this.LblUltActualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUltActualizacion.AutoSize = true;
            this.LblUltActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUltActualizacion.ForeColor = System.Drawing.Color.Green;
            this.LblUltActualizacion.Location = new System.Drawing.Point(16, 106);
            this.LblUltActualizacion.Name = "LblUltActualizacion";
            this.LblUltActualizacion.Size = new System.Drawing.Size(165, 20);
            this.LblUltActualizacion.TabIndex = 12;
            this.LblUltActualizacion.Text = "Nombre del producto";
            this.LblUltActualizacion.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.PnlCargaProductos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlGridProductos, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1467, 693);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // PnlCargaProductos
            // 
            this.PnlCargaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCargaProductos.BackColor = System.Drawing.SystemColors.Control;
            this.PnlCargaProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlCargaProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCargaProductos.Controls.Add(this.LblCodigo);
            this.PnlCargaProductos.Controls.Add(this.iconBtnEditCod);
            this.PnlCargaProductos.Controls.Add(this.iconBtnGuardar);
            this.PnlCargaProductos.Controls.Add(this.iconPictureBox1);
            this.PnlCargaProductos.Controls.Add(this.LblUltActualizacion);
            this.PnlCargaProductos.Controls.Add(this.LblPrecio);
            this.PnlCargaProductos.Controls.Add(this.iconBtnEditProd);
            this.PnlCargaProductos.Controls.Add(this.TxtPrecio);
            this.PnlCargaProductos.Controls.Add(this.TxtCodigo);
            this.PnlCargaProductos.Controls.Add(this.TxtProducto);
            this.PnlCargaProductos.Controls.Add(this.LblProducto);
            this.PnlCargaProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PnlCargaProductos.Location = new System.Drawing.Point(3, 86);
            this.PnlCargaProductos.Name = "PnlCargaProductos";
            this.PnlCargaProductos.Size = new System.Drawing.Size(434, 521);
            this.PnlCargaProductos.TabIndex = 14;
            // 
            // PnlGridProductos
            // 
            this.PnlGridProductos.Controls.Add(this.DgvProductos);
            this.PnlGridProductos.Controls.Add(this.TxtBusqueda);
            this.PnlGridProductos.Controls.Add(this.LblBusqueda);
            this.PnlGridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGridProductos.Location = new System.Drawing.Point(443, 3);
            this.PnlGridProductos.Name = "PnlGridProductos";
            this.PnlGridProductos.Size = new System.Drawing.Size(1021, 687);
            this.PnlGridProductos.TabIndex = 14;
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProductos.Location = new System.Drawing.Point(0, 125);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(1021, 562);
            this.DgvProductos.TabIndex = 14;
            this.DgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellDoubleClick);
            this.DgvProductos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProductos_ColumnHeaderMouseClick);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(0, 51);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(1021, 74);
            this.TxtBusqueda.TabIndex = 15;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlCargaProductos.ResumeLayout(false);
            this.PnlCargaProductos.PerformLayout();
            this.PnlGridProductos.ResumeLayout(false);
            this.PnlGridProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private FontAwesome.Sharp.IconButton iconBtnGuardar;
        private System.Windows.Forms.Label LblBusqueda;
        private FontAwesome.Sharp.IconButton iconBtnEditProd;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconBtnEditCod;
        private System.Windows.Forms.Label LblUltActualizacion;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel PnlGridProductos;
        private TextBox TxtBusqueda;
        private DataGridView DgvProductos;
        private Panel PnlCargaProductos;
    }
}
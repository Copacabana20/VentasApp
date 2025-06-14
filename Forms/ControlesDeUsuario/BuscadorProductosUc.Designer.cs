﻿namespace VentasApp.Forms.ControlesDeUsuario
{
    partial class BuscadorProductosUc
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
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlHeaderFind = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlHeaderFind.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.AutoSize = true;
            this.LblBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBusqueda.Location = new System.Drawing.Point(0, 0);
            this.LblBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(210, 29);
            this.LblBusqueda.TabIndex = 9;
            this.LblBusqueda.Text = "Buscar productos";
            this.LblBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(10, 10);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(10);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(589, 64);
            this.TxtBusqueda.TabIndex = 16;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 54;
            this.iconPictureBox1.Location = new System.Drawing.Point(616, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(54, 54);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProductos.Location = new System.Drawing.Point(3, 124);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(677, 550);
            this.DgvProductos.TabIndex = 18;
            this.DgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellDoubleClick);
            this.DgvProductos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProductos_ColumnHeaderMouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PnlHeaderFind, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvProductos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 677);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // PnlHeaderFind
            // 
            this.PnlHeaderFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlHeaderFind.Controls.Add(this.tableLayoutPanel2);
            this.PnlHeaderFind.Controls.Add(this.LblBusqueda);
            this.PnlHeaderFind.Location = new System.Drawing.Point(3, 3);
            this.PnlHeaderFind.Name = "PnlHeaderFind";
            this.PnlHeaderFind.Size = new System.Drawing.Size(677, 115);
            this.PnlHeaderFind.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.iconPictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtBusqueda, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(677, 86);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // BuscadorProductosUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BuscadorProductosUc";
            this.Size = new System.Drawing.Size(683, 677);
            this.Load += new System.EventHandler(this.BuscadorProductosUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PnlHeaderFind.ResumeLayout(false);
            this.PnlHeaderFind.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblBusqueda;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlHeaderFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

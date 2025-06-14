namespace VentasApp.Forms
{
    partial class ImprimirPreciosForm
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
            this.PbVistaPrevia = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buscadorProductosUc1 = new VentasApp.Forms.ControlesDeUsuario.BuscadorProductosUc();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtnFastPrint = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PbVistaPrevia)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbVistaPrevia
            // 
            this.PbVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbVistaPrevia.Location = new System.Drawing.Point(3, 52);
            this.PbVistaPrevia.Name = "PbVistaPrevia";
            this.PbVistaPrevia.Size = new System.Drawing.Size(157, 135);
            this.PbVistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbVistaPrevia.TabIndex = 0;
            this.PbVistaPrevia.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.buscadorProductosUc1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 534);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buscadorProductosUc1
            // 
            this.buscadorProductosUc1.BackColor = System.Drawing.SystemColors.Control;
            this.buscadorProductosUc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscadorProductosUc1.Location = new System.Drawing.Point(178, 3);
            this.buscadorProductosUc1.Name = "buscadorProductosUc1";
            this.buscadorProductosUc1.Size = new System.Drawing.Size(697, 528);
            this.buscadorProductosUc1.TabIndex = 0;
            this.buscadorProductosUc1.ProductoSeleccionadoEvento += new System.EventHandler<VentasApp.Modelos.Producto>(this.buscadorProductosUc1_ProductoSeleciconado);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconBtnFastPrint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.PbVistaPrevia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 528);
            this.panel1.TabIndex = 1;
            // 
            // iconBtnFastPrint
            // 
            this.iconBtnFastPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnFastPrint.BackColor = System.Drawing.Color.Red;
            this.iconBtnFastPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnFastPrint.ForeColor = System.Drawing.Color.White;
            this.iconBtnFastPrint.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconBtnFastPrint.IconColor = System.Drawing.Color.White;
            this.iconBtnFastPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnFastPrint.IconSize = 30;
            this.iconBtnFastPrint.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconBtnFastPrint.Location = new System.Drawing.Point(3, 272);
            this.iconBtnFastPrint.Name = "iconBtnFastPrint";
            this.iconBtnFastPrint.Size = new System.Drawing.Size(157, 37);
            this.iconBtnFastPrint.TabIndex = 3;
            this.iconBtnFastPrint.Text = "IMPRIMIR DIRECTAMENTE";
            this.iconBtnFastPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnFastPrint.UseVisualStyleBackColor = false;
            this.iconBtnFastPrint.Click += new System.EventHandler(this.iconBtnFastPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vista previa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Green;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(3, 202);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(157, 64);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "IMPRIMIR";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ImprimirPreciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImprimirPreciosForm";
            this.Text = "ImprimirPreciosForm";
            this.Load += new System.EventHandler(this.ImprimirPreciosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbVistaPrevia)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbVistaPrevia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ControlesDeUsuario.BuscadorProductosUc buscadorProductosUc1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconBtnFastPrint;
    }
}
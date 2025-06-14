namespace VentasApp.Forms.ControlesDeUsuario
{
    partial class ConfirmarVentaUc
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
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtPago = new System.Windows.Forms.TextBox();
            this.GbVuelto = new System.Windows.Forms.GroupBox();
            this.LblVuelto = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.LblPago = new System.Windows.Forms.Label();
            this.GbVuelto.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTotal
            // 
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LblTotal.Location = new System.Drawing.Point(0, 0);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(480, 64);
            this.LblTotal.TabIndex = 34;
            this.LblTotal.Text = "TOTAL: $ 10000.00";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPago
            // 
            this.TxtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TxtPago.Location = new System.Drawing.Point(201, 81);
            this.TxtPago.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPago.Name = "TxtPago";
            this.TxtPago.Size = new System.Drawing.Size(269, 64);
            this.TxtPago.TabIndex = 31;
            this.TxtPago.Text = "10000.00";
            this.TxtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPago.TextChanged += new System.EventHandler(this.TxtPago_TextChanged);
            this.TxtPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPago_KeyUp);
            // 
            // GbVuelto
            // 
            this.GbVuelto.Controls.Add(this.LblVuelto);
            this.GbVuelto.Controls.Add(this.Lbl);
            this.GbVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.GbVuelto.Location = new System.Drawing.Point(13, 143);
            this.GbVuelto.Margin = new System.Windows.Forms.Padding(4);
            this.GbVuelto.Name = "GbVuelto";
            this.GbVuelto.Padding = new System.Windows.Forms.Padding(4);
            this.GbVuelto.Size = new System.Drawing.Size(459, 199);
            this.GbVuelto.TabIndex = 32;
            this.GbVuelto.TabStop = false;
            // 
            // LblVuelto
            // 
            this.LblVuelto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.LblVuelto.Location = new System.Drawing.Point(4, 89);
            this.LblVuelto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVuelto.Name = "LblVuelto";
            this.LblVuelto.Size = new System.Drawing.Size(451, 106);
            this.LblVuelto.TabIndex = 1;
            this.LblVuelto.Text = "$ 50000.00";
            this.LblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl
            // 
            this.Lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl.Location = new System.Drawing.Point(4, 43);
            this.Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(451, 48);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "Su vuelto";
            this.Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblPago
            // 
            this.LblPago.AutoSize = true;
            this.LblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LblPago.Location = new System.Drawing.Point(4, 92);
            this.LblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPago.Name = "LblPago";
            this.LblPago.Size = new System.Drawing.Size(182, 48);
            this.LblPago.TabIndex = 30;
            this.LblPago.Text = "Monto: $";
            // 
            // ConfirmarVentaUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtPago);
            this.Controls.Add(this.GbVuelto);
            this.Controls.Add(this.LblPago);
            this.Name = "ConfirmarVentaUc";
            this.Size = new System.Drawing.Size(480, 350);
            this.Load += new System.EventHandler(this.ConfirmarVentaUc_Load);
            this.GbVuelto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtPago;
        private System.Windows.Forms.GroupBox GbVuelto;
        private System.Windows.Forms.Label LblVuelto;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label LblPago;
    }
}

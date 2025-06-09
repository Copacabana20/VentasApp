namespace VentasApp.Forms
{
    partial class OkDialogForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconBtnOk = new FontAwesome.Sharp.IconButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.iconBtnNo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LblMessage);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 216);
            this.panel1.TabIndex = 0;
            // 
            // LblMessage
            // 
            this.LblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.White;
            this.LblMessage.Location = new System.Drawing.Point(64, 80);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(445, 76);
            this.LblMessage.TabIndex = 10;
            this.LblMessage.Text = "label1";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleExclamation;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 64;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 80);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(64, 76);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.iconBtnOk, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 156);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 56);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // iconBtnOk
            // 
            this.iconBtnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBtnOk.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.iconBtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnOk.ForeColor = System.Drawing.Color.White;
            this.iconBtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconBtnOk.IconColor = System.Drawing.Color.White;
            this.iconBtnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnOk.IconSize = 20;
            this.iconBtnOk.Location = new System.Drawing.Point(204, 10);
            this.iconBtnOk.Name = "iconBtnOk";
            this.iconBtnOk.Size = new System.Drawing.Size(100, 35);
            this.iconBtnOk.TabIndex = 2;
            this.iconBtnOk.Text = "OK";
            this.iconBtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnOk.Click += new System.EventHandler(this.iconBtnOk_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(509, 80);
            this.LblTitulo.TabIndex = 7;
            this.LblTitulo.Text = "Branty Ventas";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconBtnNo
            // 
            this.iconBtnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.iconBtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnNo.ForeColor = System.Drawing.Color.White;
            this.iconBtnNo.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconBtnNo.IconColor = System.Drawing.Color.White;
            this.iconBtnNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnNo.IconSize = 20;
            this.iconBtnNo.Location = new System.Drawing.Point(258, 10);
            this.iconBtnNo.Name = "iconBtnNo";
            this.iconBtnNo.Size = new System.Drawing.Size(100, 35);
            this.iconBtnNo.TabIndex = 3;
            this.iconBtnNo.Text = "NO";
            this.iconBtnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // OkDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(513, 216);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OkDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRMAR";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblMessage;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconBtnNo;
        private FontAwesome.Sharp.IconButton iconBtnOk;
        private System.Windows.Forms.Label LblTitulo;
    }
}
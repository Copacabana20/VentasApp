namespace VentasApp.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.headerUc1 = new VentasApp.Forms.ControlesDeUsuario.HeaderUc();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.PnlChildrenForms = new System.Windows.Forms.Panel();
            this.MenuUc = new ControlesDeUsuario.MenuUc(PnlChildrenForms);
            this.PnlHeader.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.headerUc1);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1382, 190);
            this.PnlHeader.TabIndex = 0;
            // 
            // headerUc1
            // 
            this.headerUc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.headerUc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerUc1.Location = new System.Drawing.Point(0, 0);
            this.headerUc1.Name = "headerUc1";
            this.headerUc1.Size = new System.Drawing.Size(1382, 190);
            this.headerUc1.TabIndex = 0;
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PnlMenu.Controls.Add(this.MenuUc);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 190);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(327, 663);
            this.PnlMenu.TabIndex = 1;
            // 
            // PnlChildrenForms
            // 
            this.PnlChildrenForms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlChildrenForms.BackgroundImage")));
            this.PnlChildrenForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlChildrenForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChildrenForms.Location = new System.Drawing.Point(327, 190);
            this.PnlChildrenForms.Name = "PnlChildrenForms";
            this.PnlChildrenForms.Size = new System.Drawing.Size(1055, 663);
            this.PnlChildrenForms.TabIndex = 2;
            // 
            // MenuUc
            // 
            this.MenuUc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MenuUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuUc.Location = new System.Drawing.Point(0, 0);
            this.MenuUc.Name = "MenuUc";
            this.MenuUc.Size = new System.Drawing.Size(327, 663);
            this.MenuUc.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.PnlChildrenForms);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlHeader);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlHeader.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlMenu;
        private VentasApp.Forms.ControlesDeUsuario.MenuUc MenuUc;
        private ControlesDeUsuario.HeaderUc headerUc1;
        private System.Windows.Forms.Panel PnlChildrenForms;
    }
}
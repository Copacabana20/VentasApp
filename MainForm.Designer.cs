namespace VentasApp
{
    partial class MainForm
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PbCarga = new System.Windows.Forms.ProgressBar();
            this.LblCarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PbCarga
            // 
            this.PbCarga.BackColor = System.Drawing.Color.Red;
            this.PbCarga.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PbCarga.Location = new System.Drawing.Point(66, 334);
            this.PbCarga.Margin = new System.Windows.Forms.Padding(4);
            this.PbCarga.MarqueeAnimationSpeed = 5;
            this.PbCarga.Name = "PbCarga";
            this.PbCarga.Size = new System.Drawing.Size(444, 18);
            this.PbCarga.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PbCarga.TabIndex = 1;
            // 
            // LblCarga
            // 
            this.LblCarga.AutoSize = true;
            this.LblCarga.BackColor = System.Drawing.Color.Transparent;
            this.LblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic);
            this.LblCarga.ForeColor = System.Drawing.Color.White;
            this.LblCarga.Location = new System.Drawing.Point(61, 303);
            this.LblCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCarga.Name = "LblCarga";
            this.LblCarga.Size = new System.Drawing.Size(286, 29);
            this.LblCarga.TabIndex = 2;
            this.LblCarga.Text = "Cargando Configuracion";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 415);
            this.ControlBox = false;
            this.Controls.Add(this.LblCarga);
            this.Controls.Add(this.PbCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar PbCarga;
        private System.Windows.Forms.Label LblCarga;
    }
}
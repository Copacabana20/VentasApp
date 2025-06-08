using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;
using VentasApp.Enum;

namespace VentasApp.Forms
{
    public partial class ToastForm : Form
    {
        private Timer closeTimer;

        public ToastForm(string message, ToastType type = ToastType.Success, int durationMs = 3000)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(31, 30, 68);
            this.ForeColor = Color.White;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.panel1.Padding = new Padding(10);
            
            //this.Opacity = 05;

            IconChar iconChar;
            Color iconColor;

            switch (type)
            {
                case ToastType.Success:
                    iconChar = IconChar.CheckCircle;
                    iconColor = Color.LimeGreen;
                    break;
                case ToastType.Error:
                    iconChar = IconChar.TimesCircle;
                    iconColor = Color.Red;
                    break;
                case ToastType.Warning:
                    iconChar = IconChar.ExclamationTriangle;
                    iconColor = Color.Orange;
                    break;
                default:
                    iconChar = IconChar.InfoCircle;
                    iconColor = Color.DodgerBlue;
                    break;
            }

            var iconBox = new IconPictureBox
            {
                IconChar = iconChar,
                IconColor = iconColor,
                Size = new Size(32, 32),
                Location = new Point(10, 10),
                BackColor = Color.Transparent
            };

            var lblMessage = new Label
            {
                Text = message,
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(iconBox.Right + 10, iconBox.Top + 7),
                ForeColor = Color.White
            };

            this.panel1.Controls.Add(iconBox);
            this.panel1.Controls.Add(lblMessage);
            this.Size = new Size(lblMessage.Right + 20, lblMessage.Bottom + 20);

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20;
            this.Location = new Point(x, y);

            var closeTimer = new Timer();
            closeTimer.Interval = durationMs;
            closeTimer.Tick += (s, e) => { closeTimer.Stop(); this.Close(); };
            closeTimer.Start();
        }
    }
}

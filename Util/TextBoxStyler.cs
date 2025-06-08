using System;
using System.Drawing;
using System.Windows.Forms;

namespace VentasApp.Util
{
    public static class TextBoxStyler
    {
        public static void ApplyMaterialStyle(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
            textBox.Font = new Font("Segoe UI", 11);
            textBox.TextAlign = HorizontalAlignment.Left;

            textBox.Margin = new Padding(0);
            textBox.Padding = new Padding(5, 8, 5, 5);

            // Podés agregar una línea inferior tipo Material Design usando un Panel
            Panel underline = new Panel
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = Color.DodgerBlue
            };
            textBox.Parent.Controls.Add(underline);
            underline.BringToFront();
        }
        public static Panel CreateDarkSearchBox(out TextBox txtSearch)
        {
            var panel = new Panel
            {
                BackColor = Color.FromArgb(30, 30, 30),
                Height = 35,
                Width = 300,
                Padding = new Padding(10, 5, 10, 5)
            };

            var icon = new FontAwesome.Sharp.IconPictureBox
            {
                IconChar = FontAwesome.Sharp.IconChar.Search,
                IconColor = Color.Gray,
                IconFont = FontAwesome.Sharp.IconFont.Auto,
                Size = new Size(20, 20),
                Dock = DockStyle.Left,
                BackColor = Color.Transparent
            };

            txtSearch = new TextBox
            {
                BorderStyle = BorderStyle.None,
                ForeColor = Color.White,
                BackColor = panel.BackColor,
                Font = new Font("Segoe UI", 10),
                Dock = DockStyle.Fill
            };

            panel.Controls.Add(txtSearch);
            panel.Controls.Add(icon);
            panel.BringToFront();

            return panel;
        }
        //public class RoundedTextBox : UserControl
        //{
        //    public TextBox TextBox { get; private set; }
        //    public string PlaceholderText { get; set; } = "Buscar...";

        //    public RoundedTextBox()
        //    {
        //        this.BackColor = Color.White;
        //        this.Padding = new Padding(10);
        //        this.Size = new Size(250, 35);

        //        TextBox = new TextBox
        //        {
        //            BorderStyle = BorderStyle.None,
        //            Dock = DockStyle.Fill,
        //            Font = new Font("Segoe UI", 10),
        //            ForeColor = Color.Gray,
        //            Text = PlaceholderText
        //        };
        //        TextBox.GotFocus += RemovePlaceholder;
        //        TextBox.LostFocus += SetPlaceholder;

        //        this.Controls.Add(TextBox);
        //        this.Paint += RoundedTextBox_Paint;
        //    }

        //    private void RoundedTextBox_Paint(object sender, PaintEventArgs e)
        //    {
        //        using (var pen = new Pen(Color.LightGray, 2))
        //        {
        //            var rect = this.ClientRectangle;
        //            rect.Width -= 1;
        //            rect.Height -= 1;
        //            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //            e.Graphics.DrawArc(pen, rect, 0, 360);
        //        }
        //    }

        //    private void RemovePlaceholder(object sender, EventArgs e)
        //    {
        //        if (TextBox.Text == PlaceholderText)
        //        {
        //            TextBox.Text = "";
        //            TextBox.ForeColor = Color.Black;
        //        }
        //    }

        //    private void SetPlaceholder(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrWhiteSpace(TextBox.Text))
        //        {
        //            TextBox.Text = PlaceholderText;
        //            TextBox.ForeColor = Color.Gray;
        //        }
        //    }
        //}

    }
}

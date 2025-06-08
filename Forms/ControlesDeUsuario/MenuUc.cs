using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace VentasApp.Forms.ControlesDeUsuario
{
    public partial class MenuUc : UserControl
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Panel PnlFormChild;
        private Form currentChildForm;

        public MenuUc(Panel PanelForm)
        {
            PnlFormChild = PanelForm;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.Controls.Add(leftBorderBtn);
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(58, 34, 224);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                iconBtnAbrirCerrarCaja.Visible = currentBtn.Name == "IconBtnVentas";
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlFormChild.Controls.Add(childForm);
            PnlFormChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void IconBtnVentas_Click(object sender, EventArgs e)
        {
            if (currentBtn?.Name == ((IconButton)sender).Name)
            {
                return;
            }
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new VentasForm());
        }

        private void IconBtnProductos_Click(object sender, EventArgs e)
        {
            if (currentBtn?.Name == ((IconButton)sender).Name)
            {
                return;
            }
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new ProductosForm());
        }

        private void IconBtn_Click(object sender, EventArgs e)
        {
            if (currentBtn?.Name == ((IconButton)sender).Name)
            {
                return;
            }
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ReimprimirTicketForm());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (currentBtn?.Name == ((IconButton)sender).Name)
            {
                return;
            }
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new ImprimirPreciosForm());
        }

        private void IconBtnNegocio_Click(object sender, EventArgs e)
        {
            if (currentBtn?.Name == ((IconButton)sender).Name)
            {
                return;
            }
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new DatosNegocioForm());
        }
        private void iconBtnAjustes_Click(object sender, EventArgs e)
        {
            if (currentBtn?.Name == ((IconButton)sender).Name)
            {
                return;
            }
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new AjustesForm());
        }

        private void iconBtnReportes_Click(object sender, EventArgs e)
        {
            if (currentBtn?.Name == ((IconButton)sender).Name)
            {
                return;
            }
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new ReportesForm());
        }

        private void MenuUc_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            LblVersionApp.Text = $"Branty Ventas - Versión {version}";
        }
    }
}

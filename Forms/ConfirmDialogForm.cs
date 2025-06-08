using System.Drawing;
using System.Windows.Forms;

namespace VentasApp.Forms
{
    public partial class ConfirmDialogForm : Form
    {
        public bool Confirmed { get; private set; }

        public ConfirmDialogForm(string message, string title = "Confirmar")
        {
            InitializeComponent();
            this.LblTitulo.Text = title;
            LblMessage.Text = message;
            this.Confirmed = false;
        }

        private void iconBtnSi_Click(object sender, System.EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }

        private void iconBtnNo_Click(object sender, System.EventArgs e)
        {
            Confirmed = false;
            this.Close();
        }
    }
}

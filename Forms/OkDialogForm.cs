using System.Drawing;
using System.Windows.Forms;

namespace VentasApp.Forms
{
    public partial class OkDialogForm : Form
    {

        public OkDialogForm(string message)
        {
            InitializeComponent();
            LblMessage.Text = message;
        }

        private void iconBtnOk_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

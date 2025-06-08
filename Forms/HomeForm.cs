using System.Windows.Forms;

namespace VentasApp.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            var splashForm = new MainForm();
            splashForm.ShowDialog();
            InitializeComponent();
        }
    }
}

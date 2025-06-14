using System.Windows.Forms;
using VentasApp.Util;

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

        public void ActualizarHeader()
        {
            headerUc1.CargarDatos();
            Toast.Success("Los datos del negocio se actualizaron correctamente");
        }
    }
}

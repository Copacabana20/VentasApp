using VentasApp.Forms;

namespace VentasApp.Util
{
    public static class Dialog
    {
        public static bool Confirm(string message, string title = "Confirmación")
        {
            using (var dialog = new ConfirmDialogForm(message, title))
            {
                var result = dialog.ShowDialog();
                return dialog.Confirmed;
            }
        }
    }
}

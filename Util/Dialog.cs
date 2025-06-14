using System.Windows.Forms;
using VentasApp.Forms;
using System.Drawing;

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

        public static void Ok(string message)
        {
            using (var dialog = new OkDialogForm(message))
            {
                var result = dialog.ShowDialog();
            }
        }

        public static DialogResult ShowUserControlAsDialog(UserControl control, string title = "Branty Ventas", int width = 600, int height = 800)
        {
            using (var form = new Form())
            {
                form.Name = "UserControlAsDialogForm";
                form.Text = title;
                form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ClientSize = new Size(width, height);
                form.Controls.Add(control);
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.ShowIcon = false;
                form.ShowInTaskbar = false;

                control.Dock = DockStyle.Fill;

                return form.ShowDialog();
            }
        }
    }
}

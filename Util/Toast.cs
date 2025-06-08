using VentasApp.Forms;

namespace VentasApp.Util
{
    public static class Toast
    {
        public static void Success(string message,int duration = 3000)
        {
            new ToastForm(message, Enum.ToastType.Success,duration).Show();
        }

        public static void Error(string message, int duration = 3000)
        {
            new ToastForm(message, Enum.ToastType.Error, duration).Show();
        }

        public static void Warning(string message, int duration = 3000)
        {
            new ToastForm(message, Enum.ToastType.Warning, duration).Show();
        }

        public static void Info(string message, int duration = 3000)
        {
            new ToastForm(message, Enum.ToastType.Info, duration).Show();
        }
    }
}

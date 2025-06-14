using System.Drawing;
using System;
using System.IO;
using System.Windows.Media;

namespace VentasApp.Util
{
    public static class ImageHelper
    {
        public static string ConvertirImagenABase64(Image image)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                var array = (byte[])converter.ConvertTo(image, typeof(byte[]));
                return Convert.ToBase64String(array);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Image ConvertirBase64AImagen(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}

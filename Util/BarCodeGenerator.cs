using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace VentasApp.Util
{
    public static class BarCodeGenerator
    {
        public static Image GenerateBarCode(
            string data,
            int width = 300,
            int height = 100,
            bool mostrarTexto = false)
        {
            if (string.IsNullOrWhiteSpace(data))
                throw new ArgumentException("El contenido del código no puede estar vacío.");

            var formato = DetectarFormato(data);

            var opciones = new EncodingOptions
            {
                Width = width,
                Height = height,
                Margin = 2,
                PureBarcode = !mostrarTexto,  
            };

            var writer = new BarcodeWriter
            {
                Format = formato,
                Options = opciones,
                Renderer = new BitmapRenderer() // System.Drawing-based renderer
            };

            var imagen = writer.Write(data);

            return imagen;
        }

        private static BarcodeFormat DetectarFormato(string data)
        {
            if (data.All(char.IsDigit))
            {
                if (data.Length == 13)
                    return BarcodeFormat.EAN_13;
                if (data.Length == 8)
                    return BarcodeFormat.EAN_8;
                if (data.Length == 12)
                    return BarcodeFormat.UPC_A;
                if (data.Length == 6 || data.Length == 7)
                    return BarcodeFormat.UPC_E;
                if (data.Length % 2 == 0 && data.Length >= 6 && data.Length <= 14)
                    return BarcodeFormat.ITF;
            }

            if (data.All(c => char.IsLetterOrDigit(c)))
                return BarcodeFormat.CODE_128;

            if (data.All(c => "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%".Contains(char.ToUpper(c))))
                return BarcodeFormat.CODE_39;

            return BarcodeFormat.QR_CODE;
        }

        public static Image GenerarEtiqueta(string nombreProducto, string precio, string codigoBarras)
        {
            nombreProducto = nombreProducto.Length > 35 ? $"{nombreProducto.Substring(0,35)}..." : nombreProducto;
            int sizeNombreProducto = nombreProducto.Length < 20 ? 18 : 15;

            int width = 320;
            int height = 175;
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                var Moneda = "ARS";
                g.Clear(Color.White);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

                Font fontProducto = new Font("Arial", sizeNombreProducto, FontStyle.Regular);
                Font fontPrecio = new Font("Arial", 36, FontStyle.Bold);
                Font fontDecimales = new Font("Arial", 18, FontStyle.Bold);
                Font fontMoneda = new Font("Arial", 12);

                int margen = 10;

                // Producto
                var layoutRect = new RectangleF(margen, 5, width - 2 * margen, 60);
                var formato = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Near,
                    Trimming = StringTrimming.Word  // Corta por palabras si se excede el alto
                };
                g.DrawString(nombreProducto, fontProducto, Brushes.Black, layoutRect, formato);

                // Precio grande (parte entera y decimal separado)
                var partesPrecio = precio.Split(',');
                string parteEntera = partesPrecio[0];
                string parteDecimal = partesPrecio.Length > 1 ? "," + partesPrecio[1] : "";

                var medidaPrecio = g.MeasureString(parteEntera, fontPrecio);
                g.DrawString(parteEntera, fontPrecio, Brushes.Black, new PointF(margen, 55));
                g.DrawString(parteDecimal, fontDecimales, Brushes.Black, new PointF(margen + medidaPrecio.Width - 5, 65));
                g.DrawString(Moneda, fontMoneda, Brushes.Black, new PointF(margen, 120));

                // Código de barras generado con ZXing
                Image barcode = GenerateBarCode(codigoBarras, height: 50, width: 200, mostrarTexto: true);
                var medidaMoneda = g.MeasureString(Moneda, fontMoneda);
                g.DrawImage(barcode, new PointF(margen + medidaMoneda.Width, 125));
            }

            return bmp;
        }

        public static Image GenerarEtiqueta_bkp(string nombreProducto, string precio, string precioPorKilo, string codigoBarras)
        {
            int width = 400;
            int height = 150;
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

                Font fontProducto = new Font("Arial", 12, FontStyle.Regular);
                Font fontPrecio = new Font("Arial", 36, FontStyle.Bold);
                Font fontDecimales = new Font("Arial", 18, FontStyle.Bold);
                Font fontKilo = new Font("Arial", 10);
                Font fontEuros = new Font("Arial", 12);

                int margen = 10;

                // Producto
                g.DrawString(nombreProducto, fontProducto, Brushes.Black, new PointF(margen, 5));

                // Precio grande (parte entera y decimal separado)
                var partesPrecio = precio.Split(',');
                string parteEntera = partesPrecio[0];
                string parteDecimal = partesPrecio.Length > 1 ? "," + partesPrecio[1] : "";

                var medidaPrecio = g.MeasureString(parteEntera, fontPrecio);
                g.DrawString(parteEntera, fontPrecio, Brushes.Black, new PointF(margen, 30));
                g.DrawString(parteDecimal, fontDecimales, Brushes.Black, new PointF(margen + medidaPrecio.Width - 5, 40));
                g.DrawString("EUROS", fontEuros, Brushes.Black, new PointF(margen, 85));

                // Precio por kilo
                g.DrawString(precioPorKilo, fontKilo, Brushes.Black, new PointF(width - 170, 40));

                // Código de barras generado con ZXing
                var writer = new ZXing.BarcodeWriter
                {
                    Format = ZXing.BarcodeFormat.EAN_13,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Height = 40,
                        Width = 150,
                        Margin = 0
                    }
                };
                Image barcode = writer.Write(codigoBarras);
                g.DrawImage(barcode, new Point(width - 160, 70));
            }

            return bmp;
        }

    }
}
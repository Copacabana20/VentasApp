using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Servicios;
using VentasApp.Util;
using ZXing;

namespace VentasApp.Forms
{
    public partial class ImprimirPreciosForm : Form
    {
        public ImprimirPreciosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string barcode = textBox1.Text;
                Producto prod = ProductoService.BuscarPorCodigo(barcode);


                Image Imagen = BarCodeGenerator.GenerateBarCode(data: barcode,400,120, mostrarTexto: true);
                Image img2 = BarCodeGenerator.GenerarEtiqueta(
                    nombreProducto: prod.Nombre,
                    precio: prod.Precio.ToString("c"),
                    codigoBarras: prod.Codigo
                );
                //etiqueta.Save("etiqueta.png", ImageFormat.Png);

                pictureBox1.Image = img2;

            }
            catch (Exception ex)
            {
                Toast.Error(ex.Message);
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Reports.UserControls;
using VentasApp.Util;

namespace VentasApp.Forms
{
    public partial class ImprimirPreciosForm : Form
    {
        private static bool _imprimirDirectamente = false;

        public ImprimirPreciosForm()
        {
            InitializeComponent();
        }
        private void ImprimirPreciosForm_Load(object sender, EventArgs e)
        {
            buscadorProductosUc1.ActualizarGridProductos();
            ActualizarVistaPrevia();
        }

        private void buscadorProductosUc1_ProductoSeleciconado(object sender, Producto e)
        {
            Producto prod = e;
            try
            {
                Image imgVistaPrevia = BarCodeGenerator.GenerarEtiqueta(
                    nombreProducto: prod.Nombre,
                    precio: prod.Precio.ToString("c"),
                    codigoBarras: prod.Codigo
                );

                if (_imprimirDirectamente)
                {
                    ImprimirEtiqueta(imgVistaPrevia);
                }
                else
                {
                    PbVistaPrevia.Image = imgVistaPrevia;
                }
            }
            catch (Exception ex)
            {
                Toast.Error(ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ImprimirEtiqueta(PbVistaPrevia.Image);
        }

        private void ActualizarVistaPrevia()
        {
            if (_imprimirDirectamente)
            {
                iconBtnFastPrint.BackColor = Color.Green;
                iconBtnFastPrint.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
                iconBtnFastPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconBtnFastPrint.ImageAlign = ContentAlignment.TopLeft;
                PbVistaPrevia.Image = null;
            }
            else
            {
                iconBtnFastPrint.BackColor = Color.Red;
                iconBtnFastPrint.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
                iconBtnFastPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconBtnFastPrint.ImageAlign = ContentAlignment.TopRight;
            }
        }

        private void ImprimirEtiqueta(Image img)
        {
            try
            {
                if (img == null)
                {
                    Toast.Warning("Primero seleccione un producto para imprimir la etiqueta");
                    return;
                }

                EtiquetaProductoForm form = new EtiquetaProductoForm(img);
                ReportesHelper.ImprimirReporte(form, ImpresionDirectamente: true);
            }
            catch (Exception)
            {
                Toast.Error("Ocurrio un error al imprimir la etiqueta");
            }
        }

        private void iconBtnFastPrint_Click(object sender, EventArgs e)
        {
            _imprimirDirectamente = !_imprimirDirectamente;
            ActualizarVistaPrevia();
        }
    }
}

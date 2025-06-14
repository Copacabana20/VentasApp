using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Util;

namespace VentasApp.Reports.UserControls
{
    public partial class EtiquetaProductoForm : Form
    {
        public EtiquetaProductoForm(Image img)
        {
            InitializeComponent();
            string imgBase64 = ImageHelper.ConvertirImagenABase64(img);

            ReportParameter rpImage = new ReportParameter("EtiquetaImageParameter", imgBase64);
            this.reportViewer1.LocalReport.SetParameters(rpImage);
            this.reportViewer1.RefreshReport();
        }

        private void EtiquetaProductoForm_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}

using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace VentasApp.Util
{
    public static class ReportesHelper
    {
        private static bool _ImprimirTicket = true;
        private static string _ImpresoraName = "EPSON89E8F8 (L3250 Series)";

        public static void ImsssprimirReporte(ReportViewer reportViewer, short nCopias=1)
        {
            if (reportViewer == null || reportViewer.LocalReport == null)
                throw new Exception("No se encontró el visor de reportes o el reporte está vacío.");

            try
            {
                bool ImprimirTicket= false;
                string ImpresoraName = "EPSON89E8F8 (L3250 Series)";

                if (!ImprimirTicket)
                {
                    // Mostrar el formulario que contiene el ReportViewer
                    Form previewForm = new Form
                    {
                        Text = "Vista previa del ticket",
                        Width = 400,
                        Height = 600
                    };
                    reportViewer.Dock = DockStyle.Fill;
                    previewForm.Controls.Add(reportViewer);
                    reportViewer.RefreshReport();
                    previewForm.ShowDialog();
                }
                else
                {
                    ImpresionReporteHelper impresora = new ImpresionReporteHelper(reportViewer.LocalReport);
                    impresora.PrinterSettings.Copies = nCopias;
                    impresora.PrinterSettings.PrinterName = ImpresoraName;
                    impresora.Print();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo imprimir el ticket. Detalle: " + ex.Message);
            }
        }

        public static void ImprimirReporte(Form ReporteForm, short nCopias)
        {
            try
            {
                var oReporte = ReporteForm;

                ReportViewer oViewer = null;

                


                //var oProp = oReporte.GetType().GetProperty("Content");
                //var oContenido = oProp.GetValue(oReporte, null);

                //oProp = oContenido.GetType().GetProperty("Children");
                //var oControles = oProp.GetValue(oContenido, null);

                foreach (var oControl in oReporte.Controls)
                {
                    //var oProp2 = oControl.GetType().GetProperty("Child");
                    //var oControlHijo = oProp2.GetValue(oControl, null);

                    //if (oControlHijo is ReportViewer)
                    //{
                    //    oViewer = (ReportViewer)oControlHijo;
                    //}

                    if (oControl is ReportViewer)
                    {
                        oViewer = (ReportViewer)oControl;
                    }
                }

                //  Si no se encontro el reporte, está mal implementado y no se va a poder imprimir
                if (oViewer == null)
                {
                    throw new Exception(string.Format("Error de implementación del ticket: Método[{0}]",
                        MethodBase.GetCurrentMethod().Name));
                }

                if (!_ImprimirTicket)
                {
                    oReporte.ShowDialog();
                }
                else
                {
                    ImpresionReporteHelper impresionReporteHelper = new ImpresionReporteHelper(oViewer.LocalReport);

                    impresionReporteHelper.PrinterSettings.Copies = nCopias;
                    impresionReporteHelper.PrinterSettings.PrinterName = _ImpresoraName;

                    try
                    {
                        impresionReporteHelper.Print();
                    }
                    catch
                    {
                        oReporte.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("El ticket no puede ser impreso. Comuníquese con Soporte Técnico.");
            }

        }

    }
}

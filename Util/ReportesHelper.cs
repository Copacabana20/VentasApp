using Microsoft.Reporting.WinForms;
using System;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using VentasApp.Properties;

namespace VentasApp.Util
{
    public static class ReportesHelper
    {
        private static bool _ImprimirTicket = Settings.Default.ImprimirTicket;
        private static string _ImpresoraName = Settings.Default.ImpresoraName;

        public static void ImprimirReporte(Form ReporteForm, short nCopias=1, bool ImpresionDirectamente = false)
        {
            try
            {
                var oReporte = ReporteForm;
                
                ReportViewer oViewer = null;

                foreach (var oControl in oReporte.Controls)
                {
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

                if (_ImprimirTicket || ImpresionDirectamente)
                {
                    bool impresoraExiste = PrinterSettings.InstalledPrinters.Cast<string>().Any(p=> p.Equals(_ImpresoraName, StringComparison.OrdinalIgnoreCase));
                    ImpresionReporteHelper impresionReporteHelper = new ImpresionReporteHelper(oViewer.LocalReport);

                    impresionReporteHelper.PrinterSettings.Copies = nCopias;
                    
                    string printerName = impresoraExiste ? _ImpresoraName : new PrinterSettings().PrinterName; // predeterminada del sistema
                    impresionReporteHelper.PrinterSettings.PrinterName = printerName;

                    try
                    {
                        impresionReporteHelper.Print();
                    }
                    catch
                    {
                        oReporte.ShowDialog();
                    }
                }
                else
                {
                    oReporte.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw new Exception("El ticket no puede ser impreso. Comuníquese con Soporte Técnico.");
            }

        }

    }
}

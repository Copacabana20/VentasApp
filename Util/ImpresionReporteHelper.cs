using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.Reporting.WinForms;

namespace VentasApp.Util
{
    class ImpresionReporteHelper : PrintDocument
    {
        private readonly PageSettings _pageSettings;
        private int _currentPage;
        private readonly List<Stream> _pages = new List<Stream>();

        #region Constructores

        public ImpresionReporteHelper(LocalReport localReport)
            : this((Report)localReport)
        {
            RenderAllLocalReportPages(localReport);
        }

        private ImpresionReporteHelper(Report report)
        {
            // Set the page settings to the default defined in the report
            ReportPageSettings reportPageSettings = report.GetDefaultPageSettings();

            // The page settings object will use the default printer unless
            // PageSettings.PrinterSettings is changed.  This assumes there
            // is a default printer.
            _pageSettings = new PageSettings
            {
                PaperSize = reportPageSettings.PaperSize,
                Margins = reportPageSettings.Margins,
                Landscape = reportPageSettings.IsLandscape
            };
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                foreach (Stream s in _pages)
                {
                    s.Dispose();
                }

                _pages.Clear();
            }
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);

            _currentPage = 0;
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            Stream pageToPrint = _pages[_currentPage];
            pageToPrint.Position = 0;

            // Load each page into a Metafile to draw it.
            using (Metafile pageMetaFile = new Metafile(pageToPrint))
            {
                Rectangle adjustedRect = new Rectangle(
                        e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                        e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                        e.PageBounds.Width,
                        e.PageBounds.Height);

                // Draw a white background for the report
                e.Graphics.FillRectangle(Brushes.White, adjustedRect);

                // Draw the report content
                e.Graphics.DrawImage(pageMetaFile, adjustedRect);

                // Prepare for next page.  Make sure we haven't hit the end.
                _currentPage++;
                e.HasMorePages = _currentPage < _pages.Count;
            }
        }

        protected override void OnQueryPageSettings(QueryPageSettingsEventArgs e)
        {
            e.PageSettings = (PageSettings)_pageSettings.Clone();
        }


        private void RenderAllLocalReportPages(LocalReport localReport)
        {
            string deviceInfo = CreateEmfDeviceInfo();

            Warning[] warnings;
            localReport.Render("IMAGE", deviceInfo, LocalReportCreateStreamCallback, out warnings);
        }

        private Stream LocalReportCreateStreamCallback(string name, string extension, Encoding encoding, string mimeType, bool willSeek)
        {
            MemoryStream stream = new MemoryStream();
            _pages.Add(stream);

            return stream;
        }

        private string CreateEmfDeviceInfo()
        {
            PaperSize paperSize = _pageSettings.PaperSize;
            Margins margins = _pageSettings.Margins;

            if (_pageSettings.Landscape)
            {
                return string.Format(
               CultureInfo.InvariantCulture,
               "<DeviceInfo><OutputFormat>emf</OutputFormat><StartPage>0</StartPage><EndPage>0</EndPage><MarginTop>{0}</MarginTop><MarginLeft>{1}</MarginLeft><MarginRight>{2}</MarginRight><MarginBottom>{3}</MarginBottom><PageHeight>{4}</PageHeight><PageWidth>{5}</PageWidth></DeviceInfo>",
               ToInches(margins.Top),
                ToInches(margins.Left),
                ToInches(margins.Right),
                ToInches(margins.Bottom),
                ToInches(paperSize.Width),
                ToInches(paperSize.Height));
            }
            else
            {
                return string.Format(
                CultureInfo.InvariantCulture,
                "<DeviceInfo><OutputFormat>emf</OutputFormat><StartPage>0</StartPage><EndPage>0</EndPage><MarginTop>{0}</MarginTop><MarginLeft>{1}</MarginLeft><MarginRight>{2}</MarginRight><MarginBottom>{3}</MarginBottom><PageHeight>{4}</PageHeight><PageWidth>{5}</PageWidth></DeviceInfo>",
                ToInches(margins.Top),
                ToInches(margins.Left),
                ToInches(margins.Right),
                ToInches(margins.Bottom),
                ToInches(paperSize.Height),
                ToInches(paperSize.Width));
            }

        }

        private static string ToInches(int hundrethsOfInch)
        {
            double inches = hundrethsOfInch / 100.0;
            return inches.ToString(CultureInfo.InvariantCulture) + "in";
        }
    }
}

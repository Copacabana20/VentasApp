using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Servicios;

namespace VentasApp.Reports.UserControls
{
    public partial class TicketForm : Form
    {
        private static ReportDataSource _dsDatosNegocio = null;
        private static ReportDataSource _DetalleVentas = null;
        private static Venta _venta = null;

        public TicketForm(Venta venta)
        {
            InitializeComponent();
            _venta = venta;

            var datosNegocio = new List<DatosNegocio>
            {
                DatosNegocioService.ObtenerDatos()
            };


            ReportDataSource dsDetalle = new ReportDataSource("DsDetalleVenta", _venta.Detalle);
            ReportDataSource dsDatosNegocio = new ReportDataSource("DsDatosNegocio", datosNegocio);
            ReportParameter rpFecha = new ReportParameter("FechaVentaParameter", _venta.Fecha.ToString());
            ReportParameter rpIdVenta = new ReportParameter("IdVentaParameter", _venta.Id.ToString());
            this.reportViewer1.LocalReport.SetParameters(rpFecha);
            this.reportViewer1.LocalReport.SetParameters(rpIdVenta);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dsDetalle);
            this.reportViewer1.LocalReport.DataSources.Add(dsDatosNegocio);

            this.reportViewer1.RefreshReport();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

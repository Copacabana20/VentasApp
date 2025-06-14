using System;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Servicios;
using VentasApp.Reports.UserControls;
using VentasApp.Util;


namespace VentasApp.Forms.ControlesDeUsuario
{
    public partial class ConfirmarVentaUc : UserControl
    {
        private static Venta _venta = new Venta();

        public ConfirmarVentaUc( Venta venta)
        {
            InitializeComponent();
            _venta = venta;
        }

        private void ConfirmarVentaUc_Load(object sender, EventArgs e)
        {
            MostrarTotalaPagar();
        }

        private void MostrarTotalaPagar()
        {
            decimal TotalAPagar = _venta.Total;
            LblTotal.Text = string.Format(new System.Globalization.CultureInfo("en-US"), "TOTAL: {0:c}", TotalAPagar);

            TxtPago.Text = TotalAPagar.ToString("N");
            TxtPago.Focus();
        }

        private void TxtPago_TextChanged(object sender, EventArgs e)
        {
            decimal Vuelto, Pago;
            decimal.TryParse(TxtPago.Text, out Pago);
            Vuelto = Pago > _venta.Total ? Pago - _venta.Total : 0;

            LblVuelto.Text = string.Format(new System.Globalization.CultureInfo("en-US"), "{0:c}", Vuelto);
        }

        private void TxtPago_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.FindForm().DialogResult = DialogResult.Cancel;
                    this.FindForm().Close();
                    break;
                case Keys.Enter:
                    TerminarVenta();
                    break;
            }
        }

        private void TerminarVenta()
        {
            VentaService.RegistrarVenta(_venta);
            bool printTicket = true;
            if (printTicket)
            {
                ImprimirTicket();
            }

            this.FindForm().DialogResult = DialogResult.OK;
            this.FindForm().Close();
        }

        private void ImprimirTicket()
        {
            TicketForm from = new TicketForm(_venta);
            ReportesHelper.ImprimirReporte(from, 1);
        }
    }
}

using System;
using System.Windows.Forms;
using VentasApp.Servicios;


namespace VentasApp.Forms.ControlesDeUsuario
{
    public partial class HeaderUc : UserControl
    {
        public HeaderUc()
        {
            InitializeComponent();
        }

        private void HeaderUc_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var datos = DatosNegocioService.ObtenerDatos();
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            LblTitulo.Text = datos.Nombre;
            LblDireccion.Text = $"Direccion: {datos.Direccion}";
            LblLocalidad.Text = $"Localidad: {datos.Localidad} ({datos.CodigoPostal})";
            LblCuit.Text = $"Cuit: { datos.Cuit}";
            LblIngBrutos.Text = $"Ing. Brutos: {datos.IngresosBrutos}";
            LblTelefono.Text = $"Telefono: {datos.Telefono}";
            LblFecha.Text = $"Fecha: {date}";
        }
    }
}

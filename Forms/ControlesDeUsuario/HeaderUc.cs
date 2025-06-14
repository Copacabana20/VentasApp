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

        public void CargarDatos()
        {
            var datos = DatosNegocioService.ObtenerDatos();
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            LblTitulo.Text = datos.NombreNegocio;
            LblDireccion.Text = $"Direccion: {datos.Calle} {datos.Altura}";
            LblLocalidad.Text = $"Localidad: {datos.Localidad} ({datos.CodigoPostal})";
            LblCuit.Text = $"Cuit: { datos.Cuit}";
            LblIngBrutos.Text = $"Ing. Brutos: {datos.IngresosBrutos}";
            LblTelefono.Text = $"Telefono: {datos.Propietario.Telefono}";
            LblFecha.Text = $"Fecha: {date}";
        }
    }
}

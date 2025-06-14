using System;
using System.Windows.Forms;
using VentasApp.Modelos;
using VentasApp.Servicios;
using VentasApp.Util;

namespace VentasApp.Forms
{
    public partial class DatosNegocioForm : Form
    {
        public DatosNegocioForm()
        {
            InitializeComponent();
        }

        private void DatosNegocioForm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void IconBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dialog.Confirm("¿Esta seguro de actualizar los datos del negocio?"))
                {
                    GuardarDatos();
                    this.Close();
                }
            }
            catch (Exception)
            {
                Toast.Error("Ocurrio un error al actualizar los datos del negocio");
            }
        }

        private void CargarDatos()
        {
            var datos = DatosNegocioService.ObtenerDatos();

            TxtNombre.Text = datos.Propietario.Nombre;
            TxtApellido.Text = datos.Propietario.Apellido;
            TxtDni.Text = datos.Propietario.Dni;
            TxtTelefono.Text = datos.Propietario.Telefono;
            TxtRazonSocial.Text = datos.NombreNegocio;
            TxtCuit.Text = datos.Cuit;
            TxtIngBrutos.Text = datos.IngresosBrutos;
            TxtInicioActividades.Text = datos.InicioDeActividades;
            TxtSitioWeb.Text = datos.SitioWeb;
            TxtCalle.Text = datos.Calle;
            TxtNumero.Text = datos.Altura;
            TxtLocalidad.Text = datos.Localidad;
            TxtCodPostal.Text = datos.CodigoPostal;
        }

        private void GuardarDatos()
        {
            var datosNegocio = new DatosNegocio()
            {
                Propietario = new Owner()
                {
                    Dni = TxtDni.Text,
                    Nombre = TxtNombre.Text,
                    Apellido = TxtApellido.Text,
                    Telefono = TxtTelefono.Text,
                },
                NombreNegocio = TxtRazonSocial.Text,
                Calle = TxtCalle.Text,
                Altura = TxtNumero.Text,
                Localidad = TxtLocalidad.Text,
                CodigoPostal = TxtCodPostal.Text,
                Cuit = TxtCuit.Text,
                IngresosBrutos = TxtIngBrutos.Text,
                InicioDeActividades = TxtInicioActividades.Text,
                SitioWeb = TxtSitioWeb.Text
            };

            DatosNegocioService.GuardarDatos(datosNegocio);
        }
    }
}

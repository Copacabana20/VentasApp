using System.Text.Json.Serialization;

namespace VentasApp.Modelos
{
    public class DatosNegocio
    {
        public string DNI { get; set; } // DNI del dueño
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Cuit { get; set; }
        public string IngresosBrutos { get; set; }
        public string InicioDeActividades { get; set; }
        public string Leyenda { get; set; }
    }
}


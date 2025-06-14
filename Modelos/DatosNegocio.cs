using System.Text.Json.Serialization;

namespace VentasApp.Modelos
{
    public class DatosNegocio
    {
        public Owner Propietario { get; set; }
        public string NombreNegocio { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Cuit { get; set; }
        public string IngresosBrutos { get; set; }
        public string InicioDeActividades { get; set; }
        public string SitioWeb { get; set; }

        public DatosNegocio() { 
            Propietario = new Owner();
        }

    }

    public class Owner
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
    }
}


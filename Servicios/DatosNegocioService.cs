using System;
using System.IO;
using System.Text.Json;
using VentasApp.Modelos;

namespace VentasApp.Servicios
{
    public static class DatosNegocioService
    {
        private static readonly string archivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConfigData", "DatosNegocio.json");

        public static DatosNegocio ObtenerDatos()
        {
            if (!File.Exists(archivo))
                throw new Exception("No se encuentra el archivo de configuracion. ¡contacte con el administrador!");

            string data = File.ReadAllText(archivo);
            return JsonSerializer.Deserialize<DatosNegocio>(data);
        }

        public static void CrearArchivoJson()
        {
            if (File.Exists(archivo))
                return;

            Directory.CreateDirectory(Path.GetDirectoryName(archivo));

            // Crear instancia por defecto
            var datosPorDefecto = new DatosNegocio()
            {
                Propietario = new Owner()
                {
                    Dni = "12345678",
                    Nombre = "Branty",
                    Apellido = "Ventas",
                    Telefono = "123456789"
                },
                NombreNegocio = "Branty ventas",
                Calle = "Calle Falsa",
                Altura = "123",
                Localidad = "Quilmes",
                CodigoPostal = "1000",
                Cuit = "30-12345678-9",
                IngresosBrutos = "123456789",
                InicioDeActividades = "01/01/2020",
                SitioWeb = "https://google.com"
            };
            GuardarDatos(datosPorDefecto);
        }

        public static void GuardarDatos(DatosNegocio datos)
        {
            string json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivo, json);
        }
    }
}

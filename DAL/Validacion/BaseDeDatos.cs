using System.Configuration;
using System.Data.SQLite;
using System.IO;

namespace VentasApp.DAL.Validacion
{    
    public static class BaseDeDatos
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["VentasDB"].ConnectionString;
        
        private static string ObtenerRutaArchivoDesdeConnectionString()
        {
            var builder = new SQLiteConnectionStringBuilder(connectionString);
            return builder.DataSource;
        }

        public static void ValidarExistenciaBaseDeDatos()
        {
            string rutaDB = ObtenerRutaArchivoDesdeConnectionString();
            if (!File.Exists(rutaDB))
            {
                SQLiteConnection.CreateFile(rutaDB);
            }

            InicializarBaseDatos();
        }

        private static void InicializarBaseDatos()
        {
            var sql = @"
                CREATE TABLE IF NOT EXISTS Cajas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FechaApertura TEXT NOT NULL,
                    FechaCierre TEXT,
                    MontoApertura REAL NOT NULL,
                    MontoCierre REAL,
                    TotalVendido REAL NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Productos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Codigo TEXT NOT NULL UNIQUE,
                    Nombre TEXT NOT NULL,
                    Precio REAL NOT NULL,
                    UltimaActualizacion TEXT NOT NULL
                 );

                CREATE TABLE IF NOT EXISTS Ventas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fecha TEXT NOT NULL,
                    Total REAL NOT NULL,
                    CajaId INTEGER NOT NULL,
                    FOREIGN KEY (CajaId) REFERENCES Cajas(Id)
                );

                CREATE TABLE IF NOT EXISTS DetalleVenta (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    VentaId INTEGER NOT NULL,
                    ProductoId INTEGER,
                    NombreProducto TEXT NOT NULL,
                    Cantidad INTEGER NOT NULL,
                    PrecioUnitario REAL NOT NULL,
                    FOREIGN KEY (VentaId) REFERENCES Ventas(Id),
                    FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
                );
            ";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

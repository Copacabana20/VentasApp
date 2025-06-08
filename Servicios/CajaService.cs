using System;
using System.Data;
using System.Data.SQLite;
using VentasApp.DAL;
using VentasApp.Modelos;

namespace VentasApp.Servicios
{
    public static class CajaService
    {
        private static Caja CargarEntidad(DataRow fila)
        {
            Caja data = new Caja()
            {
                Id = Convert.ToInt32(fila["Id"]),
                FechaApertura = DateTime.Parse(fila["FechaApertura"].ToString()),
                MontoApertura = Convert.ToDecimal(fila["MontoApertura"])
            };

            return data;
        }

        public static void AbrirCaja(decimal montoApertura)
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = "INSERT INTO Cajas (FechaApertura, MontoApertura) VALUES (@Fecha, @Monto); SELECT last_insert_rowid();";

            var parameters = new SQLiteParameter[] {
                con.CrearParametro("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                con.CrearParametro("@Monto", montoApertura)
            };
            
            con.Ejecutar(query,parameters);
        }

        public static void CerrarCaja(int cajaId, decimal montoCierre, decimal totalVendido)
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = @"UPDATE Cajas 
                             SET FechaCierre = @FechaCierre, 
                                 MontoCierre = @MontoCierre, 
                                 TotalVendido = @TotalVendido 
                             WHERE Id = @Id";
            var parametros = new SQLiteParameter[]
            {
                con.CrearParametro("@FechaCierre", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                con.CrearParametro("@MontoCierre", montoCierre),
                con.CrearParametro("@TotalVendido", totalVendido ),
                con.CrearParametro("@Id", cajaId )
            };

            con.Ejecutar(query, parametros);
        }

        public static Caja ObtenerUltimaCajaAbierta()
        {
            string query = "SELECT * FROM Cajas WHERE FechaCierre IS NULL ORDER BY Id DESC LIMIT 1";


            SqliteConexionDAL con = new SqliteConexionDAL();
            var tabla = con.TraerDataTable(query);
            if (tabla.Rows.Count == 0) return null;

            return CargarEntidad(tabla.Rows[0]);
        }
    }
}

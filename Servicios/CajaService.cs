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
                FechaCierre = fila.Field<Nullable<DateTime>>("FechaCierre")
            };

            return data;
        }

        public static void AbrirCaja()
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = "INSERT INTO Cajas (FechaApertura) VALUES (@Fecha); SELECT last_insert_rowid();";

            var parameters = new SQLiteParameter[] {
                con.CrearParametro("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            };
            
            con.Ejecutar(query,parameters);
        }

        public static void CerrarCaja(int cajaId)
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = @"UPDATE Cajas 
                             SET FechaCierre = @FechaCierre
                             WHERE Id = @Id";
            var parametros = new SQLiteParameter[]
            {
                con.CrearParametro("@FechaCierre", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
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

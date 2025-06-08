using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using VentasApp.DAL;
using VentasApp.Modelos;

namespace VentasApp.Servicios
{
    public static class VentaService
    {
        private static Venta CargarEntidad(DataRow dataRow)
        {
            Venta data = new Venta()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Fecha = DateTime.Parse(dataRow["Fecha"].ToString()),
                Total = Convert.ToDecimal(dataRow["Total"]),
                CajaId = Convert.ToInt32(dataRow["CajaId"])
            };

            return data;
        }

        public static void RegistrarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            try
            {
                con.BeginTransaction();
                    // Insertar venta
                string insertVenta = @"INSERT INTO Ventas (Fecha, Total, CajaId) 
                                        VALUES (@Fecha, @Total, @CajaId); 
                                       SELECT last_insert_rowid();";

                var VentaParameters = new SQLiteParameter[]
                {
                    con.CrearParametro("@Fecha", venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss")),
                    con.CrearParametro("@Total", venta.Total),
                    con.CrearParametro("@CajaId", venta.CajaId),
                };
                
                venta.Id = con.TraerUnValor(insertVenta, VentaParameters);

                // Insertar detalles de venta
                foreach (var detalle in detalles)
                {
                    string insertDetalle = @"INSERT INTO DetalleVentas 
                        (VentaId, ProductoId, NombreProducto, Cantidad, PrecioUnitario, Subtotal) 
                        VALUES (@VentaId, @ProductoId, @NombreProducto, @Cantidad, @PrecioUnitario, @Subtotal)";

                    var DetalleParameters = new SQLiteParameter[]
                    {
                        con.CrearParametro("@VentaId", venta.Id),
                        con.CrearParametro("@ProductoId", detalle.ProductoId.HasValue ? (object)detalle.ProductoId : DBNull.Value),
                        con.CrearParametro("@NombreProducto", detalle.NombreProducto),
                        con.CrearParametro("@Cantidad", detalle.Cantidad),
                        con.CrearParametro("@PrecioUnitario", detalle.PrecioUnitario),
                        con.CrearParametro("@Subtotal", detalle.Subtotal)                        
                    };

                    con.Ejecutar(insertDetalle, DetalleParameters);
                }

                con.CommitTransaction();
            }
            catch (Exception ex)
            {
                con.RollBackTransaction();
                throw new Exception("Error al registrar la venta: " + ex.Message, ex);
            }
        }

        public static List<Venta> ObtenerVentasPorCaja(int cajaId) 
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = "SELECT * FROM Ventas WHERE CajaId = @CajaId ORDER BY Fecha DESC";
            var parametros = new SQLiteParameter[]
            {
                con.CrearParametro("@CajaId", cajaId)
            };

            var tabla = con.TraerDataTable(query, parametros);
            var ventas = new List<Venta>();

            foreach (DataRow fila in tabla.Rows)
            {
                ventas.Add(CargarEntidad(fila));
            }

            return ventas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using VentasApp.DAL;
using VentasApp.Modelos;

namespace VentasApp.Servicios
{
    public static class ProductoService
    {
        private static Producto CargarEntidad(DataRow dataRow)
        {
            Producto producto = new Producto()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Codigo = dataRow["Codigo"].ToString(),
                Nombre = dataRow["Nombre"].ToString(),
                Precio = Convert.ToDecimal(dataRow["Precio"]),
                UltimaActualizacion = DateTime.Parse(dataRow["UltimaActualizacion"].ToString())
            };

            return producto;
        }

        public static void AgregarProducto(Producto producto)
        {
            ValidarCodigoDuplicado(producto.Codigo);
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = "INSERT INTO Productos (Codigo, Nombre, Precio, UltimaActualizacion) VALUES (@Codigo, @Nombre, @Precio, @UltimaActualizacion)";
            var parametros = new SQLiteParameter[]
            {
                con.CrearParametro("@Codigo", producto.Codigo),
                con.CrearParametro("@Nombre", producto.Nombre),
                con.CrearParametro("@Precio", producto.Precio),
                con.CrearParametro("@UltimaActualizacion", producto.UltimaActualizacion.ToString("yyyy-MM-dd HH:mm:ss"))
            };

            con.Ejecutar(query, parametros);
        }

        public static void ActualizarProducto(Producto producto)
        {
            ValidarCodigoDuplicado(producto.Codigo,producto.Id);
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = "Update Productos set Nombre = @Nombre, codigo=@Codigo, Precio = @Precio, UltimaActualizacion = @UltimaActualizacion where Id = @Id";
            var parametros = new SQLiteParameter[]
            {
                con.CrearParametro("@Id", producto.Id),
                con.CrearParametro("@Codigo", producto.Codigo),
                con.CrearParametro("@Nombre", producto.Nombre),
                con.CrearParametro("@Precio", producto.Precio),
                con.CrearParametro("@UltimaActualizacion", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            };

            con.Ejecutar(query, parametros);
        }

        public static Producto BuscarPorCodigo(string codigo)
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            string query = "SELECT * FROM Productos WHERE Codigo = @Codigo";
            var parametros = new SQLiteParameter[]
            {
                con.CrearParametro("@Codigo", codigo)
            };

            var tabla = con.TraerDataTable(query, parametros);
            if (tabla.Rows.Count == 0) return null;

            return CargarEntidad(tabla.Rows[0]);
        }

        public static List<Producto> ObtenerTodos()
        {
            SqliteConexionDAL con = new SqliteConexionDAL();
            var lista = new List<Producto>();
            var tabla = con.TraerDataTable("SELECT * FROM Productos");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(CargarEntidad(fila));
            }

            return lista;
        }

        private static void ValidarCodigoDuplicado(string codigo, int Id=0)
        {
            var prod = BuscarPorCodigo(codigo);
            if (prod == null) return;

            if (prod.Id == Id)
                return;

            throw new Exception("Ya existe otro producto con el mismo codigo");
        }
    }
}

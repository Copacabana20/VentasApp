using VentasApp.Modelos;

namespace VentasApp.Dto
{
    public class GridDetalleVentaDto
    {
        public int? Id { get; set; } //id producto
        public int Cantidad { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal => Cantidad * Precio;
        const string prodSinCodigo = "Producto de almacén";

        public GridDetalleVentaDto() { }
        public GridDetalleVentaDto(DetalleVenta detalle) 
        {
            Id = detalle.ProductoId;
            Cantidad = detalle.Cantidad;
            Producto = detalle.NombreProducto;
            Precio = detalle.PrecioUnitario;
        }

        public GridDetalleVentaDto(int cantidad, Producto prod)
        {
            Id = prod.Id;
            Cantidad = cantidad;
            Producto = prod.Nombre;
            Precio = prod.Precio;
        }

        public GridDetalleVentaDto(int cantidad, decimal precio)
        {
            Cantidad = cantidad;
            Producto = prodSinCodigo;
            Precio = precio;
        }
    }
}

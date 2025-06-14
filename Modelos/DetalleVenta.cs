﻿using VentasApp.Dto;

namespace VentasApp.Modelos
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int? ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;

        public DetalleVenta() { }

        public DetalleVenta(GridDetalleVentaDto dto)
        {
            ProductoId = dto.Id;
            NombreProducto = dto.Producto;
            Cantidad = dto.Cantidad;
            PrecioUnitario = dto.Precio;
        }
    }
}

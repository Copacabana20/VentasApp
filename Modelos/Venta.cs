using System;
using System.Collections.Generic;
using System.Linq;
using VentasApp.Dto;

namespace VentasApp.Modelos
{
    public class Venta
    {
        public int Id { get; set; }              // ID de la venta
        public DateTime Fecha { get; set; }      // Fecha y hora de la venta
        public decimal Total { get; set; }       // Total de la venta
        public int CajaId { get; set; }
        public List<DetalleVenta> Detalle { get; set; } = new List<DetalleVenta>();

        public Venta() { }

        public Venta(int cajaId, List<GridDetalleVentaDto> dto)
        {
            Fecha = DateTime.Now;
            Total = dto.Sum(x=> x.Subtotal);
            CajaId = cajaId;
            Detalle = (from d in dto
                      select new DetalleVenta(d)).ToList();
        }

        public override string ToString()
        {
            return $"Venta #{Id} - {Fecha.ToShortDateString()} - Total: ${Total}";
        }
    }
}

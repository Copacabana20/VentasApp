using System;

namespace VentasApp.Modelos
{
    public class Venta
    {
        public int Id { get; set; }              // ID de la venta
        public DateTime Fecha { get; set; }      // Fecha y hora de la venta
        public decimal Total { get; set; }       // Total de la venta
        public int CajaId { get; set; }

        public Venta() { }

        public Venta(int id, DateTime fecha, decimal total)
        {
            Id = id;
            Fecha = fecha;
            Total = total;
        }

        public override string ToString()
        {
            return $"Venta #{Id} - {Fecha.ToShortDateString()} - Total: ${Total}";
        }
    }
}

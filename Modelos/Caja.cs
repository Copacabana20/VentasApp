using System;

namespace VentasApp.Modelos
{
    public class Caja
    {
        public int Id { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public decimal MontoApertura { get; set; }
        public decimal MontoCierre { get; set; }
        public decimal TotalVendido { get; set; }
    }
}

using System;

namespace VentasApp.Modelos
{
    public class Producto
    {
        public int Id { get; set; }              // Clave primaria (autoincremental)
        public string Codigo { get; set; }       // Código de barras o código interno
        public string Nombre { get; set; }       // Nombre del producto
        public decimal Precio { get; set; }      // Precio de venta
        public DateTime UltimaActualizacion { get; set; }

        public Producto() { }

        public Producto(int id, string codigo, string nombre, decimal precio)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            UltimaActualizacion = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Codigo}) - ${Precio}";
        }
    }
}

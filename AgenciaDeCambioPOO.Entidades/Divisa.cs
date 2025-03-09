using System.Text;

namespace AgenciaDeCambioPOO.Entidades
{
    public class Divisa
    {
        public string Abreviatura { get; set; }
        public decimal Cantidad{ get; set; }
        public decimal CotizacionCompra { get; set; }
        public decimal CotizacionVenta { get; set; }
        public string Nombre { get; set; }

        public Divisa(){  }

        public Divisa (string abreviatura, int cantidad, decimal cotizacionCompra, decimal cotizacionVenta, string nombre)
        {
            Abreviatura = abreviatura;
            Cantidad = cantidad;
            CotizacionCompra = cotizacionCompra;
            CotizacionVenta = cotizacionVenta;
            Nombre = nombre;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Abreviatura: {Abreviatura}");
            sb.AppendLine($"Cantidad: {Cantidad}");
            sb.AppendLine($"Cotización para la compra: {CotizacionCompra}");
            sb.AppendLine($"Cotización para la venta: {CotizacionVenta}");
            

            return sb.ToString();
        }

    }
}

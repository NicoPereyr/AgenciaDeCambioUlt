using System.Text;

namespace AgenciaDeCambioPOO.Entidades
{
    public abstract class Transaccion
    {
        public string Abreviatura { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Cotizacion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get => Cantidad * Cotizacion; }


        protected Transaccion(string abreviatura, decimal cantidad)
        {
            Abreviatura = abreviatura;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
        }

        public abstract void ObtenerCotizacion(Divisa divisa);

        public virtual string MostrarTransaccion()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Abreviatura: {Abreviatura}");
            sb.AppendLine($"Cotización: {Cotizacion}");
            sb.AppendLine($"Cantidad: {Cantidad}");
            sb.AppendLine($"Total: {Total}");
            return sb.ToString();
        }

    }
}

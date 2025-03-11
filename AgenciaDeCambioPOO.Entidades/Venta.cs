namespace AgenciaDeCambioPOO.Entidades
{
    public class Venta : Transaccion
    {
        public Venta(Divisa divisa, decimal cantidad) : base(divisa.Abreviatura, cantidad)
        {
            ObtenerCotizacion(divisa);
        }

        public override string MostrarTransaccion()
        {
            return base.MostrarTransaccion()+ "\nVenta Realizada";
        }

        public override void ObtenerCotizacion(Divisa divisa)
        {
            Cotizacion = divisa.CotizacionVenta;
        }
    }
}

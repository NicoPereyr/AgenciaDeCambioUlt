namespace AgenciaDeCambioPOO.Entidades
{
    public class Compra : Transaccion
    {
        public Compra(Divisa divisa, decimal cantidad) : base(divisa.Abreviatura, cantidad)
        {
            ObtenerCotizacion(divisa);
        }

        public override void ObtenerCotizacion(Divisa divisa)
        {
            Cotizacion = divisa.CotizacionCompra;
        }

        public override string MostrarTransaccion()
        {
            return base.MostrarTransaccion() + "\nCompra Realizada Satisfactoriamente!!!";
        }
    }
}

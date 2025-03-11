using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{
    public class RepositorioTransacciones
    {
        private readonly IArchivoSecuencial? _manejadorSecuencial;
        private readonly string _ruta;
        private readonly RepositorioDivisas? _repositorioDivisas;
        private List<Transaccion> _transacciones = new();


        public RepositorioTransacciones(IArchivoSecuencial? manejadorSecuencial,
                RepositorioDivisas repositorioDivisas,
                string ruta)
        {
            _manejadorSecuencial = manejadorSecuencial;
            _repositorioDivisas = repositorioDivisas;
            _ruta = ruta;
            CargarTransacciones();
        }

        private void CargarTransacciones()
        {
            _transacciones = _manejadorSecuencial!.LeerDatos(_ruta);
        }

        public void GuardarTransaccion(Transaccion transaccion)
        {
            _transacciones.Add(transaccion);
            /*
             * Al crear una transaccion se actualizan las cantidades
             * de la divisa que se compre o venda
             * Y la cantidad de pesos
             */
            Divisa? pesoArgentino = _repositorioDivisas!.BuscarDivisa("ARS");
            Divisa? divisaOperacion = _repositorioDivisas!.BuscarDivisa(transaccion.Abreviatura);
            if(transaccion is Venta)
            {
                pesoArgentino!.Cantidad += transaccion.Total;
                divisaOperacion!.Cantidad -= transaccion.Cantidad;
            }
            else
            {
                pesoArgentino!.Cantidad -= transaccion.Total;
                divisaOperacion!.Cantidad += transaccion.Cantidad;
            }
            _repositorioDivisas.GuardarDivisa(pesoArgentino);
            _repositorioDivisas.GuardarDivisa(divisaOperacion);
            _manejadorSecuencial!.GuardarDatos(_ruta, transaccion);
        }
        public List<Transaccion> ObtenerTransacciones()
        {
            return _transacciones;
        }
    }
}

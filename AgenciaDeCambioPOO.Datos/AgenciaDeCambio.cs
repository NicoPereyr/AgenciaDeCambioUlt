using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{

    public class AgenciaDeCambio
    {
        private readonly RepositorioDivisas _repositorioDivisas;
        private readonly RepositorioTransacciones _repositorioTransacciones;
        public AgenciaDeCambio(RepositorioDivisas repositorioDivisas, RepositorioTransacciones repositorioTransacciones)
        {
            _repositorioDivisas = repositorioDivisas;
            _repositorioTransacciones = repositorioTransacciones;

        }


        public List<Divisa> ObtenerDivisas()
        {
            return _repositorioDivisas.ObtenerTodas();
        }

        public void GuardarTransaccion(Transaccion transaccion)
        {
            _repositorioTransacciones.GuardarTransaccion(transaccion);
        }
    }



}

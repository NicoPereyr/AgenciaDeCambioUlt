using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{

    public class AgenciaDeCambio
    {
        private readonly RepositorioDivisas _repositorioDivisas;

  
        public AgenciaDeCambio(RepositorioDivisas repositorioDivisas)
        {
            _repositorioDivisas = repositorioDivisas;
        }


        public List<Divisa> ObtenerDivisas()
        {
            return _repositorioDivisas.ObtenerTodas();
        }

        public void GuardarTransaccion(Transaccion transaccion)
        {
            _repositorioDivisas.GuardarTransaccion(transaccion);
        }
    }



}

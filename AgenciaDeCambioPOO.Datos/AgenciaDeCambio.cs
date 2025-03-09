using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{

    public class AgenciaDeCambio
    {
        private readonly RepositorioDivisas _divisasRepositorio;

  
        public AgenciaDeCambio(RepositorioDivisas repositorioDivisas)
        {
            _divisasRepositorio = repositorioDivisas;
        }


        public List<Divisa> ObtenerDivisas()
        {
            return _divisasRepositorio.ObtenerTodas();
        }
    }



}

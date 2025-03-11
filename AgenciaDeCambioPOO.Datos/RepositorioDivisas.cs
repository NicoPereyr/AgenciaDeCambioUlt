using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{
    public class RepositorioDivisas
    {
        private readonly IArchivo _manejadorXml;
        private readonly string _ruta;

        private Dictionary<string, Divisa> divisas = new();


        public RepositorioDivisas(string ruta, IArchivo manejadorXml)
        {
            _manejadorXml = manejadorXml;
            _ruta = ruta;
            CargarDivisas();
        }
        private void CargarDivisas()
        {
            var lista = _manejadorXml.LeerDatos(_ruta);
            divisas = lista.ToDictionary(d => d.Abreviatura, d => d);
        }

        public List<Divisa> ObtenerTodas()
        {
            return divisas.Values.ToList();
        }

        public Divisa? BuscarDivisa(string abreviatura)
        {
            divisas.TryGetValue(abreviatura, out Divisa? buscarDivisa);
            return buscarDivisa;
        }

        public void GuardarDivisa(Divisa divisa)
        {
            var divisaBuscada = BuscarDivisa(divisa.Abreviatura);
            if (divisaBuscada == null)
            {
                divisas.Add(divisa.Abreviatura, divisa);
            }
            else
            {
                divisaBuscada.CotizacionCompra = divisa.CotizacionCompra;
                divisaBuscada.CotizacionVenta = divisa.CotizacionVenta;
                divisaBuscada.Cantidad = divisa.Cantidad;
            }
            GuardarDatos();
        }

        private void GuardarDatos()
        {
            _manejadorXml.GuardarDatos(_ruta, divisas.Values.ToList());
        }
    }
}

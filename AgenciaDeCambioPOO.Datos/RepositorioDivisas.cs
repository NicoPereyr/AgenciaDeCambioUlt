using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{
    public class RepositorioDivisas
    {
        private readonly IArchivo _manejadorXml;
        private readonly string _ruta;

        private Dictionary<String, Divisa> divisas = new();

        private void CargarDivisas()
        {
            var lista = _manejadorXml.LeerDatos(_ruta);
            divisas = lista.ToDictionary(d => d.Abreviatura, d=>d);
        }

        public RepositorioDivisas(IArchivo manejadorXml, string ruta)
        {
            _manejadorXml = manejadorXml;
            _ruta = ruta;
            CargarDivisas();
        }

        public List<Divisa> ObtenerTodas()
        {
            return divisas.Values.ToList();
        }

    }
}

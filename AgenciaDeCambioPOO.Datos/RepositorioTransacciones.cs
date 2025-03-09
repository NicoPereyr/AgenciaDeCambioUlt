using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{
    public class RepositorioTransacciones
    {
        private readonly IArchivoSecuencial? _manejadorSecuencial;
        private readonly string _ruta;

        private List<Transaccion> _transacciones = new();

        public RepositorioTransacciones(IArchivoSecuencial? manejadorSecuencial, string ruta)
        {
            _manejadorSecuencial = manejadorSecuencial;
            _ruta = ruta;
        }

    public void GuardarTransaccion(Transaccion transaccion)
        {
            _transacciones.Add(transaccion);
            _manejadorSecuencial.GuardarDatos(_ruta, transaccion);
        }
        public List<Transaccion> ObtenerTransacciones()
        {
            return _transacciones;
        }
    }
}

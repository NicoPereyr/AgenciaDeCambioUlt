using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{
    public interface IArchivoSecuencial
    {
        List<Transaccion> LeerDatos(string ruta);
        void GuardarDatos(string ruta, Transaccion datos);
    }
}

using AgenciaDeCambioPOO.Entidades;

namespace AgenciaDeCambioPOO.Datos
{
    public interface IArchivo
    {
        List<Divisa> LeerDatos(string ruta);
        void GuardarDatos(string ruta, List<Divisa>datos);
    }
}

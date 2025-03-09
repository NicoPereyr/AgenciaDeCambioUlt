using AgenciaDeCambioPOO.Entidades;
using System.Xml.Serialization;

namespace AgenciaDeCambioPOO.Datos
{
    public class ManejadorXml : IArchivo
    {
        public void GuardarDatos(string ruta, List<Divisa> datos)
        {
            using (var escritor = new StreamWriter(ruta!))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Divisa>));
                xmlSerializer.Serialize(escritor, datos);
            }
        }

        public List<Divisa> LeerDatos(string ruta)
        {
            if (!File.Exists(ruta))
            {
                return new List<Divisa>();
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Divisa>));
            using (StreamReader lector = new StreamReader(ruta))
            {
                return (List<Divisa>)xmlSerializer.Deserialize(lector)!;
            }
        }
    }
}

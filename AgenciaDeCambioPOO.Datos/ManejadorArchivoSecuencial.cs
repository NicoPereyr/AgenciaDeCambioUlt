using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Datos
{
    public class ManejadorArchivoSecuencial : IArchivoSecuencial
    {
        private readonly string _ruta;
        private List<Transaccion> transacciones=new();

        public ManejadorArchivoSecuencial(string ruta)
        {
            _ruta = ruta;
        }

        public void GuardarDatos(string _ruta, Transaccion datos)
        {
            
        }

        public List<Transaccion> LeerDatos(string _ruta)
        {
            throw new NotImplementedException();
        }
    }
}

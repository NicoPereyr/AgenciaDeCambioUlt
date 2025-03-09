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

        public ManejadorArchivoSecuencial(string ruta)
        {
            _ruta = ruta;
        }

        public void GuardarDatos(string _ruta, Transaccion datos)
        {
            /*
             * El parametro true, hace que el
             * streamwriter agregue un registro al
             * final del archivo
             */
            using (StreamWriter escritor=new StreamWriter(_ruta, true))
            {
                var linea = ConstruirLinea(datos);
                escritor.WriteLine(linea);
            }
        }

        private object ConstruirLinea(Transaccion datos)
        {
            string tipoOperacion = "Venta";
            return $"{datos.Fecha}|" +
                $"{datos.Abreviatura}|" +
                $"{datos.Cantidad}|" +
                $"{datos.Cotizacion}|" +
                $"{tipoOperacion}|" +
                $"{datos.Total}";
        }

        public List<Transaccion> LeerDatos(string _ruta)
        {
            throw new NotImplementedException();
        }
    }
}

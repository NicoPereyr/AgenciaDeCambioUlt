using AgenciaDeCambioPOO.Entidades;

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
            using (StreamWriter escritor = new StreamWriter(_ruta, true))
            {
                var linea = ConstruirLinea(datos);
                escritor.WriteLine(linea);
            }
        }

        private string ConstruirLinea(Transaccion datos)
        {
            string tipoOperacion = datos is Venta? "Venta":"Compra";
            return $"{datos.Fecha}|{datos.Abreviatura}|{datos.Cantidad}| {tipoOperacion}|{datos.Cotizacion}";
        }

        public List<Transaccion> LeerDatos(string _ruta)
        {
            if (!File.Exists(_ruta)) return new List<Transaccion>();
            List<Transaccion> lista = new List<Transaccion>();
            using (StreamReader lector = new StreamReader(_ruta))
            {
                while (!lector.EndOfStream)
                {
                    string? lineaLeida = lector.ReadLine();
                    Transaccion t = ConstruirTransaccion(lineaLeida);
                    lista.Add(t);
                }
            }
            return lista;
        }

        private Transaccion ConstruirTransaccion(string? lineaLeida)
        {
            var campos = lineaLeida!.Split('|');
            var fecha = DateTime.Parse(campos[0]);
            var abreviatura = campos[1];
            var cantidad = int.Parse(campos[2]);
            var tipoOperacion = campos[3];
            var cotizacion = decimal.Parse(campos[4]);

            return tipoOperacion == "Venta" ?
                new Venta(new Divisa { Abreviatura = abreviatura }, cantidad)
                {
                    Abreviatura = abreviatura,
                    Cotizacion = cotizacion,
                    Fecha = fecha
                } : new Compra(new Divisa { Abreviatura = abreviatura }, cantidad)
                {
                    Abreviatura = abreviatura,
                    Cotizacion = cotizacion,
                    Fecha = fecha
                };

        }
    }
}

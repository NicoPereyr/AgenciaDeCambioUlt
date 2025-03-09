using AgenciaDeCambioPOO.Datos;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaDeCambioPOO.Ioc
{
    public static class DI
    {
        public static IServiceProvider ConfigurarDI()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IArchivo, ManejadorXml>();
            services.AddSingleton(provider => new RepositorioDivisas(provider.GetRequiredService<IArchivo>(), "NuevasDivisas.xml"));
            services.AddSingleton<IArchivoSecuencial>(provider => new ManejadorArchivoSecuencial("Transacciones.txt"));
            services.AddSingleton(provider => new RepositorioTransacciones(provider.GetRequiredService<IArchivoSecuencial>(),
                        "Transacciones.txt"));
            //services.AddSingleton(provider =>
            //        new AgenciaDeCambio(provider.GetRequiredService<RepositorioDivisas>(),
            //        provider.GetRequiredService<RepositorioTransacciones>()
            //    )
            services.AddSingleton(provider =>
                    new AgenciaDeCambio(provider.GetRequiredService<RepositorioDivisas>(),
                    provider.GetRequiredService<RepositorioTransacciones>()
                ));

            //   );
            return services.BuildServiceProvider();
        }
    }
}

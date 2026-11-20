using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ProjectGasStation.Repositories;
using ProjectGasStation.Repositories.Implementations;
using Serilog;
using Unity;
using Unity.Lifetime;
using Unity.Microsoft.Logging;

namespace ProjectGasStation;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<FormGasStation>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();

        container.AddExtension(new LoggingExtension(CreateLoggerFactory()));

        container.RegisterType<DataContext>(new TransientLifetimeManager());

        container.RegisterType<IFuelRepository, FuelRepository>(new TransientLifetimeManager());
        container.RegisterType<ISellerRepository, SellerRepository>(new TransientLifetimeManager());
        container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
        container.RegisterType<ISaleRepository, SaleRepository>(new TransientLifetimeManager());
        container.RegisterType<IPurchaseRepository, PurchaseRepository>(new TransientLifetimeManager());

        return container;
    }

    private static LoggerFactory CreateLoggerFactory()
    {
        var loggerFactory = new LoggerFactory();
        loggerFactory.AddSerilog(new LoggerConfiguration()
            .ReadFrom.Configuration(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build())
            .CreateLogger());
        return loggerFactory;
    }
}

using ProjectGasStation.Repositories;
using ProjectGasStation.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

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

        container.RegisterType<IFuelRepository, FuelRepository>(new TransientLifetimeManager());
        container.RegisterType<ISellerRepository, SellerRepository>(new TransientLifetimeManager());
        container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
        container.RegisterType<ISaleRepository, SaleRepository>(new TransientLifetimeManager());
        container.RegisterType<IPurchaseRepository, PurchaseRepository>(new TransientLifetimeManager());
        
        return container;
    }
}

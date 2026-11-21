using ProjectGasStation.Entities;
using ProjectGasStation.Repositories.Interfaces;

namespace ProjectGasStation.Repositories.Implementations;

internal class FuelPurchaseRepository : IFuelPurchaseRepository
{
    public void CreateFuelPurchase(int purchaseId, FuelPurchase fuelPurchase)
    {
    }

    public void DeleteFuelPurchase(int id)
    {
    }

    public IEnumerable<FuelPurchase> ReadFuelPurchases(int? purchaseId = null, int? fuelId = null)
    {
        return [];
    }
}

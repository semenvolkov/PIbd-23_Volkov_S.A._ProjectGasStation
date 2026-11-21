using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Interfaces;

public interface IFuelPurchaseRepository
{
    IEnumerable<FuelPurchase> ReadFuelPurchases(int? purchaseId = null, int? fuelId = null);

    void CreateFuelPurchase(int purchaseId, FuelPurchase fuelPurchase);

    void DeleteFuelPurchase(int id);
}

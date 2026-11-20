using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories;

public interface IPurchaseRepository
{
    IEnumerable<Purchase> ReadPurchases(DateTime? dateFrom = null, DateTime? dateTo = null, int? supplierId = null, int? fuelId = null);

    void CreatePurchase(Purchase purchase);

    void DeletePurchase(int id);
}

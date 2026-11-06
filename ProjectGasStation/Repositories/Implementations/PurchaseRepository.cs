using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

internal class PurchaseRepository : IPurchaseRepository
{
    public void CreatePurchase(Purchase purchase)
    {
    }

    public void DeletePurchase(int id)
    {
    }

    public IEnumerable<Purchase> ReadPurchases(DateTime? dateFrom = null, DateTime? dateTo = null, int? supplierId = null, int? fuelId = null)
    {
        return [];
    }
}

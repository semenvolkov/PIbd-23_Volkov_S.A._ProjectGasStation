using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

internal class SaleRepository : ISaleRepository
{
    public void CreateSale(Sale sale)
    {
    }

    public IEnumerable<Sale> ReadSales(DateTime? dateFrom = null, DateTime? dateTo = null, int? sellerId = null, int? fuelId = null)
    {
        return [];
    }
}

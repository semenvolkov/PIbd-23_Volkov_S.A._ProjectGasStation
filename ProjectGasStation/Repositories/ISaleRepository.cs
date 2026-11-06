using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories;

public interface ISaleRepository
{
    IEnumerable<Sale> ReadSales(DateTime? dateFrom = null, DateTime? dateTo = null, int? sellerId = null, int? fuelId = null);

    void CreateSale(Sale sale);
}

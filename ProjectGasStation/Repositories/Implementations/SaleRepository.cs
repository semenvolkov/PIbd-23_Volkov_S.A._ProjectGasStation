using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

internal class SaleRepository : ISaleRepository
{
    private readonly DataContext _context;

    private readonly ILogger<SaleRepository> _logger;

    public SaleRepository(DataContext context, ILogger<SaleRepository> logger)
    {
        _context = context ??
            throw new ArgumentNullException(nameof(context));
        _logger = logger ??
            throw new ArgumentNullException(nameof(logger));
    }

    public void CreateSale(Sale sale)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(sale));
        try
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            _logger.LogDebug("Объект добавлен, Id: {id}", sale.Id);
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public IEnumerable<Sale> ReadSales(DateTime? dateFrom = null, DateTime? dateTo = null, int? sellerId = null, int? fuelId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var query = _context.Sales.AsNoTracking();
            if (dateFrom.HasValue)
            {
                query = query.Where(x => x.SaleDate >= dateFrom.Value);
            }

            if (dateTo.HasValue)
            {
                query = query.Where(x => x.SaleDate <= dateTo.Value);
            }

            if (sellerId.HasValue)
            {
                query = query.Where(x => x.SellerId == sellerId.Value);
            }

            if (fuelId.HasValue)
            {
                query = query.Where(x => x.FuelId == fuelId.Value);
            }

            var sales = query.OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(sales));
            return sales;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}

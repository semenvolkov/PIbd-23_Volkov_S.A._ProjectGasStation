using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

internal class PurchaseRepository : IPurchaseRepository
{
    private readonly DataContext _context;

    private readonly ILogger<PurchaseRepository> _logger;

    public PurchaseRepository(DataContext context, ILogger<PurchaseRepository> logger)
    {
        _context = context ??
            throw new ArgumentNullException(nameof(context));
        _logger = logger ??
            throw new ArgumentNullException(nameof(logger));
    }

    public void CreatePurchase(Purchase purchase)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(purchase));
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Purchases.Add(purchase);
            _context.SaveChanges();
            transaction.Commit();
            _logger.LogDebug("Объект добавлен, Id: {id}", purchase.Id);
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeletePurchase(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var purchase = _context.Purchases.FirstOrDefault(x => x.Id == id) ??
                throw new InvalidDataException($"Не найден объект с Id={id}");
            _context.Purchases.Remove(purchase);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public IEnumerable<Purchase> ReadPurchases(DateTime? dateFrom = null, DateTime? dateTo = null, int? supplierId = null, int? fuelId = null)
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var query = _context.Purchases
                .Include(x => x.FuelPurchases)
                .AsNoTracking();
            if (dateFrom.HasValue)
            {
                query = query.Where(x => x.PurchaseDate >= dateFrom.Value);
            }

            if (dateTo.HasValue)
            {
                query = query.Where(x => x.PurchaseDate <= dateTo.Value);
            }

            if (supplierId.HasValue)
            {
                query = query.Where(x => x.SupplierId == supplierId.Value);
            }

            if (fuelId.HasValue)
            {
                query = query.Where(x => x.FuelPurchases.Any(y => y.FuelId == fuelId.Value));
            }

            var purchases = query.OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(purchases));
            return purchases;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}

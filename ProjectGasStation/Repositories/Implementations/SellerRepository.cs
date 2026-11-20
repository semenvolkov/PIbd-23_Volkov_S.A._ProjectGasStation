using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

internal class SellerRepository : ISellerRepository
{
    private readonly DataContext _context;

    private readonly ILogger<SellerRepository> _logger;

    public SellerRepository(DataContext context, ILogger<SellerRepository> logger)
    {
        _context = context ??
            throw new ArgumentNullException(nameof(context));
        _logger = logger ??
            throw new ArgumentNullException(nameof(logger));
    }

    public void CreateSeller(Seller seller)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(seller));
        try
        {
            _context.Sellers.Add(seller);
            _context.SaveChanges();
            _logger.LogDebug("Объект добавлен, Id: {id}", seller.Id);
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void UpdateSeller(Seller seller)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(seller));
        try
        {
            _context.Sellers.Update(seller);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }

    public void DeleteSeller(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var seller = _context.Sellers.FirstOrDefault(x => x.Id == id) ??
                throw new InvalidDataException($"Не найден объект с Id={id}");
            _context.Sellers.Remove(seller);
            _context.SaveChanges();
        }
        catch (DbUpdateException ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw new InvalidOperationException("Нельзя удалить запись: она используется в других записях", ex);
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public Seller ReadSellerById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var seller = _context.Sellers.AsNoTracking().FirstOrDefault(x => x.Id == id) ??
                throw new InvalidDataException($"Не найден объект с Id={id}");
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(seller));
            return seller;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Seller> ReadSellers()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var sellers = _context.Sellers.AsNoTracking().OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(sellers));
            return sellers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}

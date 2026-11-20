using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

internal class SupplierRepository : ISupplierRepository
{
    private readonly DataContext _context;

    private readonly ILogger<SupplierRepository> _logger;

    public SupplierRepository(DataContext context, ILogger<SupplierRepository> logger)
    {
        _context = context ??
            throw new ArgumentNullException(nameof(context));
        _logger = logger ??
            throw new ArgumentNullException(nameof(logger));
    }

    public void CreateSupplier(Supplier supplier)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(supplier));
        try
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            _logger.LogDebug("Объект добавлен, Id: {id}", supplier.Id);
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void UpdateSupplier(Supplier supplier)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(supplier));
        try
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }

    public void DeleteSupplier(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var supplier = _context.Suppliers.FirstOrDefault(x => x.Id == id) ??
                throw new InvalidDataException($"Не найден объект с Id={id}");
            _context.Suppliers.Remove(supplier);
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

    public Supplier ReadSupplierById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var supplier = _context.Suppliers.AsNoTracking().FirstOrDefault(x => x.Id == id) ??
                throw new InvalidDataException($"Не найден объект с Id={id}");
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(supplier));
            return supplier;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Supplier> ReadSuppliers()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var suppliers = _context.Suppliers.AsNoTracking().OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(suppliers));
            return suppliers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}

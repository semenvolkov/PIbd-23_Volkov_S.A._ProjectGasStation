using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

internal class FuelRepository : IFuelRepository
{
    private readonly DataContext _context;

    private readonly ILogger<FuelRepository> _logger;

    public FuelRepository(DataContext context, ILogger<FuelRepository> logger)
    {
        _context = context ??
            throw new ArgumentNullException(nameof(context));
        _logger = logger ??
            throw new ArgumentNullException(nameof(logger));
    }

    public void CreateFuel(Fuel fuel)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(fuel));
        try
        {
            _context.Fuels.Add(fuel);
            _context.SaveChanges();
            _logger.LogDebug("Объект добавлен, Id: {id}", fuel.Id);
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void UpdateFuel(Fuel fuel)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(fuel));
        try
        {
            _context.Fuels.Update(fuel);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }

    public void DeleteFuel(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var fuel = _context.Fuels.FirstOrDefault(x => x.Id == id) ??
                throw new InvalidDataException($"Не найден объект с Id={id}");
            _context.Fuels.Remove(fuel);
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

    public Fuel ReadFuelById(int id)
    {
        _logger.LogInformation("Получение объекта по идентификатору");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var fuel = _context.Fuels.AsNoTracking().FirstOrDefault(x => x.Id == id) ??
                throw new InvalidDataException($"Не найден объект с Id={id}");
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(fuel));
            return fuel;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<Fuel> ReadFuels()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var fuels = _context.Fuels.AsNoTracking().OrderBy(x => x.Id).ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(fuels));
            return fuels;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }
}

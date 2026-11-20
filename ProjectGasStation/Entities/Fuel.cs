using ProjectGasStation.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectGasStation.Entities;

public class Fuel
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; private set; } = string.Empty;

    public FuelType FuelType { get; private set; }

    public double Price { get; private set; }

    protected Fuel()
    {
    }

    public static Fuel CreateEntity(int id, string name, FuelType fuelType, double price)
    {
        return new Fuel
        {
            Id = id,
            Name = name ?? string.Empty,
            FuelType = fuelType,
            Price = price
        };
    }
}

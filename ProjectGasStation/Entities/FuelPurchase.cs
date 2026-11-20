using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectGasStation.Entities;

public class FuelPurchase
{
    [Key]
    public int Id { get; private set; }

    public int FuelId { get; private set; }

    [Browsable(false)]
    [ForeignKey(nameof(FuelId))]
    public Fuel? Fuel { get; private set; }

    public double Quantity { get; private set; }

    public double Price { get; private set; }

    protected FuelPurchase()
    {
    }

    public static FuelPurchase CreateElement(int id, int fuelId, double quantity, double price)
    {
        return new FuelPurchase
        {
            Id = id,
            FuelId = fuelId,
            Quantity = quantity,
            Price = price
        };
    }
}

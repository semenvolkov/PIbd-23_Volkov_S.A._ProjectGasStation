namespace ProjectGasStation.Entities;

public class FuelPurchase
{
    public int Id { get; private set; }

    public int FuelId { get; private set; }

    public double Quantity { get; private set; }

    public double Price { get; private set; }

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

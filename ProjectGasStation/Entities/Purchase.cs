namespace ProjectGasStation.Entities;

public class Purchase
{
    public int Id { get; private set; }

    public int SupplierId { get; private set; }

    public DateTime PurchaseDate { get; private set; }

    public IEnumerable<FuelPurchase> FuelPurchases { get; private set; } = [];

    public static Purchase CreateOperation(int id, int supplierId, IEnumerable<FuelPurchase> fuelPurchases)
    {
        return new Purchase
        {
            Id = id,
            SupplierId = supplierId,
            PurchaseDate = DateTime.Now,
            FuelPurchases = fuelPurchases ?? []
        };
    }
}

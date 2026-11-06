using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities;

public class Sale
{
    public int Id { get; private set; }

    public int SellerId { get; private set; }

    public int FuelId { get; private set; }

    public ShiftType ShiftType { get; private set; }

    public double Quantity { get; private set; }

    public double Sum { get; private set; }

    public DateTime SaleDate { get; private set; }

    public static Sale CreateOperation(int id, int sellerId, int fuelId, ShiftType shiftType, double quantity, double sum)
    {
        return new Sale
        {
            Id = id,
            SellerId = sellerId,
            FuelId = fuelId,
            ShiftType = shiftType,
            Quantity = quantity,
            Sum = sum,
            SaleDate = DateTime.Now
        };
    }
}

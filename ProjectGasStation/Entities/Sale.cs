using ProjectGasStation.Entities.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectGasStation.Entities;

public class Sale
{
    [Key]
    public int Id { get; private set; }

    public int SellerId { get; private set; }

    [Browsable(false)]
    [ForeignKey(nameof(SellerId))]
    public Seller? Seller { get; private set; }

    public int FuelId { get; private set; }

    [Browsable(false)]
    [ForeignKey(nameof(FuelId))]
    public Fuel? Fuel { get; private set; }

    public ShiftType ShiftType { get; private set; }

    public double Quantity { get; private set; }

    public double Sum { get; private set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime SaleDate { get; private set; }

    protected Sale()
    {
    }

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

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectGasStation.Entities;

public class Purchase
{
    [Key]
    public int Id { get; private set; }

    public int SupplierId { get; private set; }

    [Browsable(false)]
    [ForeignKey(nameof(SupplierId))]
    public Supplier? Supplier { get; private set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime PurchaseDate { get; private set; }

    [Browsable(false)]
    public IEnumerable<FuelPurchase> FuelPurchases { get; private set; } = new List<FuelPurchase>();

    protected Purchase()
    {
    }

    public static Purchase CreateOperation(int id, int supplierId, IEnumerable<FuelPurchase> fuelPurchases)
    {
        return new Purchase
        {
            Id = id,
            SupplierId = supplierId,
            PurchaseDate = DateTime.Now,
            FuelPurchases = fuelPurchases?.ToList() ?? new List<FuelPurchase>()
        };
    }
}

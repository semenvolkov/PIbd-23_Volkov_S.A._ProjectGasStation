using ProjectGasStation.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectGasStation.Entities;

public class Seller
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; private set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName { get; private set; } = string.Empty;

    public SellerPost SellerPost { get; private set; }

    public FuelType AllowedFuelTypes { get; private set; }

    protected Seller()
    {
    }

    public static Seller CreateEntity(int id, string first, string last, SellerPost sellerPost, FuelType allowedFuelTypes)
    {
        return new Seller
        {
            Id = id,
            FirstName = first ?? string.Empty,
            LastName = last ?? string.Empty,
            SellerPost = sellerPost,
            AllowedFuelTypes = allowedFuelTypes
        };
    }
}

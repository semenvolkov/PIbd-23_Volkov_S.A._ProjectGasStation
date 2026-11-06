using ProjectGasStation.Entities.Enums;

namespace ProjectGasStation.Entities;

public class Seller
{
    public int Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public SellerPost SellerPost { get; private set; }

    public FuelType AllowedFuelTypes { get; private set; }

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

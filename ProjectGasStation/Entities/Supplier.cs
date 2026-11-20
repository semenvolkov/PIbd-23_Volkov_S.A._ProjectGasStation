namespace ProjectGasStation.Entities;

public class Supplier
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Phone { get; private set; } = string.Empty;

    public string Address { get; private set; } = string.Empty;

    public static Supplier CreateEntity(int id, string name, string phone, string address)
    {
        return new Supplier
        {
            Id = id,
            Name = name ?? string.Empty,
            Phone = phone ?? string.Empty,
            Address = address ?? string.Empty
        };
    }
}

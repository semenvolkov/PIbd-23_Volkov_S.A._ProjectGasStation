using System.ComponentModel.DataAnnotations;

namespace ProjectGasStation.Entities;

public class Supplier
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; private set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string Phone { get; private set; } = string.Empty;

    [Required]
    [MaxLength(200)]
    public string Address { get; private set; } = string.Empty;

    protected Supplier()
    {
    }

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

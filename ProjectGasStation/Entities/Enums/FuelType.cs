namespace ProjectGasStation.Entities.Enums;

[Flags]
public enum FuelType
{
    None = 0,
    Petrol92 = 1,
    Petrol95 = 2,
    Petrol98 = 4,
    Diesel = 8,
    Gas = 16,
    Materials = 32
}

namespace design_patterns;

public class Vehicle
{
    public string Brand;
    public string Model;

    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Vehicle: {Brand} {Model}");
    }
}

namespace MPA201;

public class Car
{
    private static int defaultId = 1;
    public int Id;
    public string Brand;
    public string Model;
    public string Color;
    public int Year;
    public double PriceForSale;
    public double PriceForRent;
    public bool IsSold;
    public bool IsRented;

    public Car(
        string brand, 
        string model, 
        string color, 
        int year, 
        double priceForSale,
        double priceForRent)
    {
        Id = defaultId++;
        Brand = brand;
        Model = model;
        Color = color;
        Year = year;
        PriceForSale = priceForSale;
        PriceForRent = priceForRent;
        IsSold = false;
        IsRented = false;
    }

    public void ShowInfo() => Console.WriteLine($"{Id}) Brand: {Brand} Model: {Model} Color: {Color} Year: {Year} Price for sale: {PriceForSale} Price for rent: {PriceForRent}");
}

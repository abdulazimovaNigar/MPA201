namespace MPA201;

public class Car
{
    private static int defaultId = 1;
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public decimal PriceForSale { get; set; }
    public decimal PriceForRent { get; set; }
    public bool IsSold { get; set; }
    public bool IsRented { get; set; }

    public Car(
        string brand,
        string model,
        string color,
        int year,
        decimal priceForSale,
        decimal priceForRent)
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

    public void ShowInfo() => Console.WriteLine($"{Id}) Brand: {Brand}\nModel: {Model}\nColor: {Color}\nYear: {Year}\nPrice for sale: {PriceForSale}\nPrice for rent: {PriceForRent}\n");
}

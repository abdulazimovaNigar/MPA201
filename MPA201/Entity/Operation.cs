namespace MPA201.Entity;

public class Operation
{
    private static int defaultId = 1;
    public int Id { get; set; }

    public bool Sale { get; set; }

    public decimal Price { get; set; }

    public Car Car = null;

    public Operation(bool sale, decimal price, Car car) 
    {
        Id = defaultId++;
        Price = price;
        Sale = sale;
        Car = car;
    }

    public void ShowInfo() 
    {
        Console.WriteLine($"{Id}------------\nSale: {Sale}\nPrice: {Price}\nCar-----------");
        Car.ShowInfo();
    } 

}
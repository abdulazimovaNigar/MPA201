namespace MPA201.Service;
using MPA201.Entity;

public class CarService
{
    public List<Car> cars = new List<Car>();
    public void CarSaleMenu(User user)
    {
    CarSaleMenu:
        Console.Clear();
        Console.WriteLine(
            "Car Sale" +
            "\n1. Add a car" +
            "\n2. View cars" +
            "\n3. Delete a car" +
            "\n4. Filter cars by brand" +
            "\n5. Sort cars" +
            "\n6. Sell a car" +
            "\n0. Back" +
            "\nChoose wanted option: ");

        switch (Console.ReadLine())
        {
            case "1":
                AddCar();
                goto CarSaleMenu;

            case "2":
                ShowAllCars();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto CarSaleMenu;

            case "3":
                DeleteCar();
                goto CarSaleMenu;

            case "4":
                FilterCar();
                goto CarSaleMenu;

            case "5":
                SortPrice();
                goto CarSaleMenu;

            case "6":
                SellCar();
                goto CarSaleMenu;

            case "0":
                Console.Clear();
                return;

            default:
                Console.Clear();
                Console.WriteLine(
                    $"Wrong input!" +
                    "\nTry again!");
                Console.ReadKey();
                goto CarSaleMenu;
        }
    }

    public void CarRentMenu(User user)
    {
    CarRentMenu:
        Console.Clear();
        Console.WriteLine(
            "Car Rent" +
            "\n1. Add car" +
            "\n2. View cars" +
            "\n3. Delete a car" +
            "\n4. Filter cars by brand" +
            "\n5. Sort cars" +
            "\n6. Rent a car" +
            "\n0. Back" +
            "\nChoose wanted option: ");

        switch (Console.ReadLine())
        {
            case "1":
                AddCar();
                goto CarRentMenu;

            case "2":
                ShowAllCars();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto CarRentMenu;

            case "3":
                DeleteCar();
                goto CarRentMenu;

            case "4":
                FilterCar();
                goto CarRentMenu;

            case "5":
                SortPrice();
                goto CarRentMenu;

            case "6":
                RentCar();
                goto CarRentMenu;
            case "0":
                Console.Clear();
                return;
            default:
                Console.Clear();
                Console.WriteLine(
                    $"Wrong input!" +
                    "\nTry again!");
                Console.ReadKey();
                goto CarRentMenu;
        }
    }

    public void AddCar()
    {
        Console.Clear();

        Console.Write("Brand:");
        string brand = Console.ReadLine();
        Console.Write("Model:");
        string model = Console.ReadLine();
        Console.Write("Color:");
        string color = Console.ReadLine();
        Console.Write("Year:");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Price for sale:");
        decimal priceForSale = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Price for rent:");
        decimal priceForRent = Convert.ToDecimal(Console.ReadLine());

        cars.Add(new Car(brand, model, color, year, priceForSale, priceForRent));

        Console.WriteLine("Car was successfully added!");
        Console.ReadKey();
        Console.Clear();
    }

    public void ShowAllCars()
    {
        Console.Clear();
        Console.WriteLine("List of cars:");
        foreach (var car in cars)
            car.ShowInfo();
    }

    public void DeleteCar()
    {
    DeleteCar:
        Console.Clear();
        ShowAllCars();

        Console.WriteLine("Enter the number of the car to delete:");

        if (int.TryParse(Console.ReadLine(), out int id)) 
        {
            var carToRemove = cars.FirstOrDefault(car => car.Id == id);
            if (carToRemove == null) 
            {
                Console.Clear();
                Console.WriteLine($"Car with id: {id} was not found!");
                Console.ReadKey();
                goto DeleteCar;
            }
            cars.Remove(carToRemove);
            Console.WriteLine("Car deleted successfully.");
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(
                $"Wrong input!" +
                "\nTry again!");
            Console.ReadKey();
            goto DeleteCar;
        }
        Console.ReadKey();
    }

    public void FilterCar()
    {
        Console.WriteLine("Enter a car brand to filter:");
        string brand = Console.ReadLine();
        foreach (var car in cars.Where(car => car.Brand == brand).ToList())
            car.ShowInfo();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void SortPrice()
    {
    SortPrice:
        Console.Clear();
        Console.WriteLine(
            "1. Sort by price ascending" +
            "\n2. Sort by price descending" +
            "\n0. Exit" +
            "\nChoose sorting option: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("");
                foreach (var car in cars.OrderBy(car => car.PriceForSale).ToList())
                    car.ShowInfo();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                goto SortPrice;
            case "2":
                Console.WriteLine("");
                foreach (var car in cars.OrderByDescending(car => car.PriceForSale).ToList())
                    car.ShowInfo();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                goto SortPrice;
            case "0":
                Console.Clear();
                return;
            default:
                Console.Clear();
                Console.WriteLine(
                    $"Wrong input!" +
                    "\nTry again!");
                Console.ReadKey();
                goto SortPrice;
        }
    }

    public void SellCar()
    {
    SellCar:
        Console.Clear();

        foreach (var car in cars)
        {
            if(car.PriceForSale != 0) 
            {
                car.ShowInfo();
            }
        }
        
        Console.WriteLine("Enter the ID of the car to sell:");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var carToSell = cars.FirstOrDefault(car => car.Id == id);
            if (carToSell == null)
            {
                Console.Clear();
                Console.WriteLine($"Car with id: {id} was not found!");
                Console.ReadKey();
                goto SellCar;
            }
            else 
            {
                if (carToSell.IsSold == true)
                {
                    Console.WriteLine("This car has already been sold");
                }
                else
                {
                    carToSell.IsSold = true;
                    Console.WriteLine($"Car sold. Price: {carToSell.PriceForSale}");
                }
            }               
        }
        else
        {
            Console.Clear();
            Console.WriteLine(
                $"Wrong input!" +
                "\nTry again!");
            Console.ReadKey();
            goto SellCar;
        }
        Console.ReadKey();
    }

    public void RentCar()
    {
    SellCar:
        Console.Clear();

        foreach (var car in cars)
        {
            if (car.PriceForRent != 0)
            {
                car.ShowInfo();
            }
        }

        Console.WriteLine("Enter the ID of the car to rent:");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var carToRent = cars.FirstOrDefault(car => car.Id == id);
            if (carToRent == null)
            {
                Console.Clear();
                Console.WriteLine($"Car with id: {id} was not found!");
                Console.ReadKey();
                goto SellCar;
            }
            else
            {
                if (carToRent.IsRented == true)
                {
                    Console.WriteLine("This car has already been rented");
                }
                else
                {
                    carToRent.IsRented = true;
                    Console.WriteLine($"Car rented. Price: {carToRent.PriceForRent}");
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(
                $"Wrong input!" +
                "\nTry again!");
            Console.ReadKey();
            goto SellCar;
        }
        Console.ReadKey();
    }
}

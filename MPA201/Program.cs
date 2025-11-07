namespace MPA201;
using MPA201.Service;
using MPA201.Entity;
internal class Program
{
    static void Main(string[] args)
    {
        BankService bankService = new BankService();//For Bank methods
        UserService userService = new UserService();//For User DB
        CarService carService = new CarService();//For Car methods
        User currentUser = null;
        InitializeCars(carService);

    again:
        Console.WriteLine();
        Console.Clear();
        if (currentUser == null) 
        {
            Console.WriteLine("Welcome to Car Dealership!  | User is not logged in. To log in, use Bank.");
        }
        else 
        {
            Console.WriteLine($"Welcome to Car Dealership!  | You are loged in as {currentUser.Email}");
        }
            Console.Write(
                "1. Car Sale" +
                "\n2. Rent a Car" +
                "\n3. Bank" +
                "\n0. Exit" +
                "\nChoose what to do: ");
        
        switch (Console.ReadLine())
        {
            case "1":
                carService.CarSaleMenu(bankService.LoginMenu(userService, currentUser));
                goto again;

            case "2":
                carService.CarRentMenu(bankService.LoginMenu(userService, currentUser));
                goto again;

            case "3":
                currentUser = bankService.LoginMenu(userService, currentUser);
                bankService.BankMenu(currentUser);
                goto again;

            case "0":
                Console.Clear();
                return;

            default: Console.WriteLine("Something went wrong. Please, try again."); goto again;
        }
    }

    public static void InitializeCars(CarService carService)
    {

        carService.cars.Add(new Car("Toyota", "Camry", "White", 2020, 20000, 0));
        carService.cars.Add(new Car("Honda", "Civic", "Black", 2019, 18000, 0));
        carService.cars.Add(new Car("Ford", "Focus", "Blue", 2021, 22000, 0));


        carService.cars.Add(new Car("BMW", "X5", "Grey", 2022, 0, 150));
        carService.cars.Add(new Car("Audi", "A4", "Red", 2021, 0, 120));
        carService.cars.Add(new Car("Mercedes", "C-Class", "Silver", 2020, 0, 130));
    }
}
namespace MPA201;
using MPA201.Service;

internal class Program
{
    static void Main(string[] args)
    {
        BankService bankService = new BankService();//For Bank methods
        UserService userService = new UserService();//For User DB
        CarService carService = new CarService();//For Car methods

        Console.WriteLine("Welcome to Car Dealership!");
        Console.WriteLine("1. Car Sale \n2. Rent a Car \n3. Bank \n4. Exit");

        again:
        Console.Write("Choose what to do: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine("Welcome to Drivable!");
                carService.CarSaleMenu(bankService.LoginMenu(userService));
                break;

            case "2":
                Console.WriteLine("Welcome to Cruise Wheels!");
                carService.CarRentMenu(bankService.LoginMenu(userService));
                break;

            case "3":
                Console.WriteLine("Welcome to BlueBank!");
                bankService.BankMenu(bankService.LoginMenu(userService));
                break;

            case "4":
                return;

            default: Console.WriteLine("Something went wrong. Please, try again."); goto again;
        }
    }
}
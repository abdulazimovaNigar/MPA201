namespace MPA201;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Car Dealership!");
        Console.WriteLine("1. Car Sale \n2. Rent a Car \n3. Bank \n4. Exit");

        again:
        Console.Write("Choose what to do: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine("Welcome to Drivable!");
                break;

            case "2":
                Console.WriteLine("Welcome to Cruise Wheels!");
                break;

            case "3":
                Console.WriteLine("Welcome to BlueBank!");
                break;

            case "4":
                return;

            default: Console.WriteLine("Something went wrong. Please, try again."); goto again;
        }
    }
}
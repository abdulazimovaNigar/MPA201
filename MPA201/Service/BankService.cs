namespace MPA201.Service;
using MPA201.Entity;

public class BankService
{
    public User LoginMenu(UserService userService) 
    {
    LoginMenu:
        Console.Clear();
        Console.WriteLine(
            "Do you have an account?" +
            "\n1. Yes  | (Log in)" +
            "\n2. No   | (Register)" +
            "\n0. Exit | (Back to MainMenu)");

        switch (Console.ReadLine())
        {
            //Log in
            case "1":
                return userService.LogIn();
            //Register
            case "2":
                return userService.Register();
            //Exit
            case "0":
                Console.Clear();
                return null;
            default:
                Console.Clear();
                Console.WriteLine(
                    $"Wrong input!" +
                    "\nTry again!");
                Console.ReadKey();
                goto LoginMenu;
        }
    }

    public void BankMenu(User user)
    {
    BankMenu:
        Console.Clear();
        Console.WriteLine(
            "Choose an option:" +
            "\n1. Balance" +
            "\n2. My operations" +
            "\n0. Exit | (Back to MainMenu)");

        switch (Console.ReadLine())
        {
            //Balance
            case "1":
                user.ShowBalance();
                goto BankMenu;
            //Register
            case "2":
                user.ShowOperations();
                goto BankMenu;
            //Exit
            case "0":
                Console.Clear();
                return;
            default:
                Console.Clear();
                Console.WriteLine(
                    $"Wrong input!" +
                    "\nTry again!");
                Console.ReadKey();
                goto BankMenu;
        }
    }
}

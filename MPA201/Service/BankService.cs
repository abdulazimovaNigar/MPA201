namespace MPA201.Service;

public class BankService
{
    UserService userService = new UserService();
    public void BankMenu()
    {
        string email, password;

    LoginSignup:
        Console.Clear();
        Console.WriteLine(
            $"Do you have an account?" +
            "\n1. Yes  | (Log in)" +
            "\n2. No   | (Register)" +
            "\n0. Exit | (Back to Car Dealership)");

        switch (Console.ReadLine())
        {
            //Log in
            case "1":
                userService.LogIn();
                goto LoginSignup;
            //Register
            case "2":
                userService.Register();
                goto LoginSignup;
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
                goto LoginSignup;
        }
    }
}

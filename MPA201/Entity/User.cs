namespace MPA201.Entity;

public class User
{
    private static int defaultId = 1;
    public int Id { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public decimal Balance { get; set; } = 0;

    public List<Operation> Operations { get; set; } = new List<Operation>();
    //public List<Car> Cars { get; set; } = new List<Car>();

    public User(string email, string password)
    {
        Id = defaultId++;
        Email = email;
        Password = password;
    }

    public void ShowBalance()
    {
        Console.Clear();
        Console.WriteLine(
            $"Your balance is: {this.Balance:0.00}" +
            "\nPress any key to Continue");
        Console.ReadKey();
    }

    public void ShowOperations()
    {
        Console.Clear();
        Console.WriteLine("Operations");
        Console.ReadKey();
    }
}

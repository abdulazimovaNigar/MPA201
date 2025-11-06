namespace MPA201.Entity;

public class User
{
    public int Id { get; set; } = 1;

    public string Email { get; set; }

    public string Password { get; set; }

    public double Balance { get; set; } = 0;

    List<Operation> operations = new List<Operation>();

    public User(string email, string password)
    {
        Id = Id++;
        Email = email;
        Password = password;
    }

    public void ShowBalance(User user)
    {
        Console.Clear();
        Console.WriteLine(
            $"Youre balance is: {user.Balance}" +
            "Press any key to Continue");
        Console.ReadKey();
    }
}

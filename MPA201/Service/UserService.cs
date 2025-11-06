using MPA201.Entity;

namespace MPA201.Service
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public void Register()
        {
            Console.Clear();
            string email, password;

            Console.Write("Email:"); email = Console.ReadLine();
            Console.Write("Password:"); password = Console.ReadLine();

            if (users.Any(user => user.Email == email))
            {
                Console.WriteLine("User with this email already exists!");
                Console.ReadKey();
                return;
            }

            User user = new User(email, password);
            users.Add(user);

            Console.WriteLine(
                "Account successfully created!" +
                "\nPress any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }

        public User LogIn()
        {
            Console.Clear();
            string email, password;
            Console.Write("Email:"); email = Console.ReadLine();
            Console.Write("Password:"); password = Console.ReadLine();

            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                Console.WriteLine("Invalid email or password!");
                Console.WriteLine("Invalid email or password!");
                Console.ReadKey();
                return null;
            }

            Console.WriteLine($"Welcome back, {user.Email}!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return user;
        }
    }
}

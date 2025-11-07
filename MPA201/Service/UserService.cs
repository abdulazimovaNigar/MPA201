using MPA201.Entity;

namespace MPA201.Service
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public User Register()
        {
        repeat:
            Console.Clear();
            string email, password;
            Console.WriteLine("Input 0 to exit.");
            Console.Write("Email:"); email = Console.ReadLine();
            Console.Write("Password:"); password = Console.ReadLine();

            if (email == "0" || password == "0")
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Email or password cannot be empty!");
                Console.ReadKey();
                goto repeat;
            }

            if (users.Any(user => user.Email == email))
            {
                Console.WriteLine("User with this email already exists!\nTry again!");
                Console.ReadKey();
                goto repeat;
            }

            User user = new User(email, password);
            users.Add(user);

            Console.WriteLine(
                "Account successfully created!" +
                "\nPress any key to Continue");
            Console.ReadKey();
            Console.Clear();
            return user;
        }

        public User LogIn()
        {
        repeat:
            Console.Clear();
            string email, password;
            Console.WriteLine("Input 0 to exit.");
            Console.Write("Email:"); email = Console.ReadLine();
            Console.Write("Password:"); password = Console.ReadLine();

            if(email == "0" || password == "0") 
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Email or password cannot be empty!");
                Console.ReadKey();
                goto repeat;
            }


            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
            {
                Console.WriteLine("Invalid email or password!\nTry again!");
                Console.ReadKey();
                goto repeat;
            }
            Console.Clear();
            Console.WriteLine($"Welcome back, {user.Email}!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return user;
        }
    }
}

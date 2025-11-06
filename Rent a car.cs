namespace MPA201Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> OwnedCars = new List<Car>() { };

            // case "2":

            while (true)
            {
                Console.WriteLine("1. Add car");
                Console.WriteLine("2. Explore cars");
                Console.WriteLine("3. Remove car");
                Console.WriteLine("4. Filter cars");
                Console.WriteLine("5. Sort cars");
                Console.WriteLine("6. Rent a car");
                Console.WriteLine("7. Back");
                Console.Write("\nChoose wanted option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Add(OwnedCars);
                        break;
                    case "2":
                        //Функция из файла Руфата
                        ShowCars(OwnedCars);
                        break;
                    case "3":
                        DeleteCar(OwnedCars);
                        break;
                    case "4":
                        List<Car> filtredCars = new List<Car>();
                        filtredCars = OwnedCars;
                        filtredCars.RemoveAll(car => car.GetStatus() == "Rented");
                        // filtredCars.Функция вывода списка машин
                        break;
                    case "5":
                        SortPrice(OwnedCars);
                        break;
                    case "6":
                        Console.Write("Write an ID of a car you want to rent: ");
                        int choisedID = Convert.ToInt32(Console.ReadLine());
                        if (OwnedCars[choisedID].GetStatus() == "Rented")
                        {
                            Console.WriteLine("Car is already rented!");
                            break;
                        }

                        //else if (cars[choisedID].GetStatus() == "Sold")
                        //{
                        //    Console.WriteLine("Car is sold!");
                        //    break;
                        //}
                        // По-моему это уже не нужно, но на всякий случай закомментил

                        OwnedCars[choisedID].SetStatus("Rented");
                        BankAccount += OwnedCars[choisedID].GetPrice();

                        break;
                    case "7":
                        return;
                }
            }


        }

        public class Car
        {
            public int ID;
            public string Name;
            public int year;
            private double price;
            private string status;

            public void SetStatus(string status)
            {
                this.status = status;
            }

            public string GetStatus()
            {
                return this.status;
            }

            //public void SetPrice(double price)
            //{ 
            //    this.price = price; 
            //}

            public double GetPrice()
            {
                return this.price;
            }
        }

        static public double BankAccount = 1000;
    }
}

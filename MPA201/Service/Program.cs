namespace MPA201
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();
            CarSale(cars);
        }
        static void ShowCars(List<Car> cars)
        {
            Console.WriteLine("Masinlari siyahi:");
            foreach (var item in cars)
                Console.WriteLine($"Id:{item.Id}, Brand:{item.Brand}, Model:{item.Model}, Color:{item.Color}, Year:{item.Year}, Price:{item.Price}, Status:{item.Status}");
        }
        static void CarSale(List<Car> cars)
        {
        start:
            Console.WriteLine("Avtomobil satisi");
            Console.WriteLine("Seciminizi edin: ");
            Console.WriteLine("1.Masin elave et");
            Console.WriteLine("2.Masinlara bax");
            Console.WriteLine("3.Masini sil");
            Console.WriteLine("4.Masini filtirle markaya gore");
            Console.WriteLine("5.Masinlari cesidle");
            Console.WriteLine("6.Masini sat");
            Console.WriteLine("0.Geriye");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCar(cars);
                    goto start;

                case "2":
                    ShowCars(cars);
                    goto start;

                case "3":
                    DeleteCar(cars);
                    goto start;

                case "4":
                    FilterCar(cars);
                    goto start;
                case "5":
                    SortPrice(cars);
                    goto start;
                case "6":
                    ShowCars(cars);
                    SellCar(cars);
                    goto start;


            }
        }
        static void AddCar(List<Car> cars)
        {
            Console.Write("Brand:");
            string car_brand = Console.ReadLine();
            Console.Write("Model:");
            string car_model = Console.ReadLine();
            Console.Write("Reng:");
            string car_color = Console.ReadLine();
            Console.Write("Buraxilis ili:");
            int car_year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qiymet:");
            double car_price = Convert.ToDouble(Console.ReadLine());

            Car car = new Car(car_brand, car_model, car_color, car_year, car_price);
            cars.Add(car);
            Console.WriteLine("Masin elave olundu");
        }
        static void DeleteCar(List<Car> cars)
        {
            Console.WriteLine("Silmey ucun masinin Id-ni daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());
            cars = cars.Where(car => car.Id != id).ToList();
            Console.WriteLine("Masin silindi");
        }
        static void FilterCar(List<Car> cars)
        {
            Console.WriteLine("Filterlemey ucun bir masin markasini daxil edin");
            string carBrand = Console.ReadLine();
            List<Car> filtered_brand = cars.Where(car => car.Brand == carBrand).ToList();
            ShowCars(filtered_brand);
        }
        static void SortPrice(List<Car> cars)
        {
            Console.WriteLine("1 — Qiymete gore artan");
            Console.WriteLine("2 — Qiymete gore azalan");
            List<Car> sortedPrice = new List<Car>();
            string choiceSortedPrice = Console.ReadLine();
            switch (choiceSortedPrice)
            {
                case "1":
                    sortedPrice = cars.OrderBy(car => car.Price).ToList();
                    break;
                case "2":
                    sortedPrice = cars.OrderByDescending(car => car.Price).ToList();
                    break;
            }
            ShowCars(sortedPrice);
        }
        static void SellCar(List<Car> cars)
        {
            Console.WriteLine("Masini satmaq ucun Id-ni daxil edin:");
            int idSell = Convert.ToInt32(Console.ReadLine());
            var carToSell = cars.FirstOrDefault(x => x.Id == idSell);

            if (carToSell.Status == "Sold")
            {
                Console.WriteLine("Bu masin artiq satilib");
            }
            else
            {
                carToSell.Status = "Sold";
                Console.WriteLine($"Masin satildi. Qiymet: {carToSell.Price}");
            }

        }
    }
}

using _16_10_23.Metods;

namespace _16_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colored.WriteLine("Car Simulation", ConsoleColor.Green);
            Colored.Write("Enter initial gasoline amount (default 20): ");
            double initialGas = double.Parse(Console.ReadLine());
            Colored.Write("Enter tank capacity (default 40): ");
            double tankCapacity = double.Parse(Console.ReadLine());
            Colored.Write("Enter fuel consumption per 100 km (default 10): ");
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car car = new Car(initialGas, tankCapacity, fuelConsumption);

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Drive");
                Console.WriteLine("2. Enter Zapravka");
                Console.WriteLine("3. Show the gas");
                Console.WriteLine("4. Show the way we are going");
                Console.Write("Select an option (1/2/3/4): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter distance to drive (km): ");
                        double distance = double.Parse(Console.ReadLine());
                        car.Drive(distance);
                        break;
                    case 2:
                        Console.Write("Enter amount of gasoline to fill (liters): ");
                        double fillAmount = double.Parse(Console.ReadLine());
                        car.Refuel(fillAmount);
                        break;
                    case 3:
                        car.ShowGas();
                        break;
                    case 4:
                        car.ShowMileage();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
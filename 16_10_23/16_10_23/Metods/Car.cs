using _16_10_23.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_10_23.Metods
{
    internal class Car : IVehicle
    {
        private double MileAge;
        private double Fuel;
        private double FuelConsumption;
        private double TankCapacity;

        public Car(double fuel = 20, double tankCapacity = 40, double fuelConsumption = 10)
        {
            Fuel = fuel;
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;
        }

        public bool Drive(double kilometers)
        {
            double fuelRequired = kilometers / 100 * FuelConsumption;
            if (fuelRequired <= Fuel)
            {
                MileAge += kilometers;
                Fuel -= fuelRequired;
                Console.WriteLine($"You traveled {kilometers} km. Gasoline left: {Fuel} liters. Total mileage: {MileAge} km.");
                return true;
            }
            else
            {
                Console.WriteLine("It is impossible to go this way.");
                return false;
            }
        }

        public bool Refuel(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("You have entered wrongly.");
                return false;
            }

            if (Fuel + amount <= TankCapacity)
            {
                Fuel += amount;
            }
            else
            {
                Fuel = TankCapacity;
            }
            Console.WriteLine($"Gasoline filled: {amount} liters. Gasoline left: {Fuel} liters.");
            return true;
        }

        public void ShowGas()
        {
            Console.WriteLine($"Gasoline left: {Fuel} liters");
        }

        public void ShowMileage()
        {
            Console.WriteLine($"Total mileage: {MileAge} km");
        }
    }
}

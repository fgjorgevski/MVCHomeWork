using Entites.enums;
using Entites;
using System;

namespace CarProjecct
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mercedes", "CLS-400", 5, 362, Consumption.Economic, EngineType.Petrol);
            car.PrintInfo();

            ElectircCar electricCar = new ElectircCar("Mercedes", "G$", 4, 132,Consumption.Medium,EngineType.Electric);
            electricCar.Drive(30);
            electricCar.Recharhe(10);

            FuelCar fuelCar = new FuelCar("Mercedes", "G$", 4, 132,Consumption.Medium,EngineType.Electric, 100, 30);
            //electricCar.Recharhe(10);
            


            Console.ReadLine();
        }
    }
}

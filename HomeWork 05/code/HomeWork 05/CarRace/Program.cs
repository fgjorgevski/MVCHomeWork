using CarRace.MyClasses;
using System;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.CalculateSpeed();
            Console.WriteLine("Result is: " + newCar.CalculateSpeed());
            Console.WriteLine("=");
            Console.WriteLine("==");
            Console.WriteLine("===");
            Console.WriteLine(RaceCars());

         //   Car carNo1 = new Car();
         //   Car carNo2 = new Car();
         //   Car carNo3 = new Car();
         //   Car carNo4 = new Car();
         //
         //   Driver driverNo1 = new Driver();
         //   Driver driverNo2 = new Driver();
         //   Driver driverNo3 = new Driver();
         //   Driver driverNo4 = new Driver();

        }

        public static string RaceCars()
        {
            Car firstCar = new Car();
            firstCar.Model = "DART";
            firstCar.SpeedGenerator();
            firstCar.Driver = "Phill";

            Car secondCar = new Car();
            secondCar.Model = "EQUATOR";
            secondCar.SpeedGenerator();
            secondCar.Driver = "Leo";

            if (firstCar.SpeedGenerator() > secondCar.SpeedGenerator())
            {
                string formatInMS = string.Format("{0,2:0,000}", firstCar.SpeedGenerator());
                string result = $"{firstCar.Driver} wins the race! He leads {secondCar.Driver} only for {formatInMS}ms";
                return result;
            }
            else
            {
                string formatInMS1 = string.Format("{0,2:0,000}", secondCar.SpeedGenerator());
                string result2 = $"{secondCar.Driver} wins the race! He leads {firstCar.Driver} only for {formatInMS1}";
                return result2;
            }
        }
    }
}

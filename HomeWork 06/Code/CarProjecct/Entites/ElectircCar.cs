using Entites.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites
{
    public class ElectircCar : Car
    {
        public ElectircCar(string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType) : base(brand, model, doors, topSpeed, consumption, engineType)
        {

        }

        public int BatteryCapacity { get; set; }
        public double BatteryUsage{ get; set; }

        public void Drive(int distance)  
        {

            int result = distance * (int)Consumption / 10;
            Console.WriteLine(result);
        }

        public void Recharhe(int minutes)
        {
            int result = minutes / 10;
            Console.WriteLine();
        }
        
    }
}

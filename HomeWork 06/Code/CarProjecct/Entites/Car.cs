using Entites.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites
{
    public class Car 
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model{ get; set; }
        public int Doors{ get; set; }
        public int TopSpeed{ get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }


        public Car()
        {


        }
        public Car( string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType)
        {
            
            Id = RandomId();
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
            EngineType = engineType;

        }
        
        private int RandomId()
        {
            int result = new Random().Next(99999);
            return result;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id:{Id}, Brand:{Brand}, Model:{Model}, Doors:{Doors}, Top Speed: {TopSpeed}, Consumption: {Consumption}, EngineType: {EngineType}");
        }


    }
}

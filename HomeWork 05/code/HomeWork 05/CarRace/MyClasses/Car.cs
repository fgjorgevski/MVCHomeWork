using System;

namespace CarRace.MyClasses
{
    class Car
    {
        public string Model{ get; set; }
        public int Speed{ get; set; }
        public string Driver{ get; set; }

        public Car()
        {
            Speed = SpeedGenerator();
            
        }


        public  int CalculateSpeed()
        {
            Driver driver = new Driver();
            int result = driver.Skill * Speed;
            return result;

        }


        public int SpeedGenerator()
        {
            int speed = new Random().Next(10, 100);
            return speed;
        }
    }
}

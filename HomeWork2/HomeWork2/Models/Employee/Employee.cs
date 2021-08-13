using HomeWork2.Models.Employee.Enum;
using System;

namespace HomeWork2.Models.Emoloyee
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int DateOfHire{ get; set; }
        public PositionEnum Position{ get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            EmployeeId = RandomNumber(1, 100);
            Salary = 1000;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    

        public  int RandomNumber(int from, int to)
        {
            int randomNumber = new Random().Next(from, to);
            return randomNumber;
        }

        public double salaryOfEmployee(PositionEnum position)
        {

            if (position == PositionEnum.Junior)
            {
                var random = new Random().Next(1000, 2500);
                var doubleToRandom = Convert.ToDouble(random);
                return doubleToRandom;
            }
            else  if(position == PositionEnum.Intermediate)
            {
                var random = new Random().Next(2500, 4000);
                var doubleToRandom = Convert.ToDouble(random);
                return doubleToRandom;
            }

            else if (position == PositionEnum.Senior)
            {
                var random = new Random().Next(4000, 6500);
                var doubleToRandom = Convert.ToDouble(random);
                return doubleToRandom;
            }
            else if (position == PositionEnum.Teamlead)
            {
                var random = new Random().Next(4000, 6500);
                var doubleToRandom = Convert.ToDouble(random);
                return doubleToRandom;

            }
            else
            {
                return 0;
            }




        }



    
    }


}
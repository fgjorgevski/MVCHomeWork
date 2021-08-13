using System;
using HomeWork2.Models.Employee.Enum;

namespace HomeWork2.Models.Division
{
    public class Division 
    {
        public int DivisionId { get; set; }
        public string Name{ get; set; }
        public Emoloyee.Employee HeadOfDivision{ get; set; }

        public Division()
        {
            DivisionId = RandomNumber(1, 1000);

        }

        public int RandomNumber(int from, int to)
        {
            int randomNumber = new Random().Next(from, to);
            return randomNumber;
        }
    }

    
}
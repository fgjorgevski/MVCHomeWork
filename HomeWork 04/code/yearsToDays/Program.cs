using System;

namespace yearsToDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello if you want to see how many days old you are, please enter your age in years");
            Console.Write("Age: ");
            string inputFromUser = Console.ReadLine();
            
            int checkedInputFromUser;
            bool inputCheck = int.TryParse(inputFromUser,out checkedInputFromUser);

            int yearsMethod = YearsToDays(checkedInputFromUser);
            if (inputCheck)
            {

                string daysBorn = $"You are {yearsMethod} days old";
                Console.Write(daysBorn);
            }
            else
            {
                Console.WriteLine("Please enter your birth year.");
            }
        }

        static public int YearsToDays(int age)
        {

            return age * 365;
        }

    }
}

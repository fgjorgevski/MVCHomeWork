using System;

namespace minutesInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to use the converter please enter minutes");
            string inputFromUser = Console.ReadLine();
            int checkedInput;
            bool checkInputFromUser = int.TryParse(inputFromUser, out checkedInput);

            int minInSecMethod = MinInSec(checkedInput);

            if (checkInputFromUser)
            {
                string minInSecString = $" {inputFromUser} minutes is {minInSecMethod} seconds";
                Console.WriteLine(minInSecString);
            }
            else
            {
                Console.WriteLine("You can enter only numbers here!");
            }
        }
    static public int MinInSec(int mins)
    {
        return mins * 60;
    }

    }

}

using System;

namespace AvergeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers to calculate the averge of them: \n");
            Console.Write("First Number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Second Number: ");
            string secondNumber = Console.ReadLine();
            Console.Write("Third Number: ");

            string thirdNumber = Console.ReadLine();
            Console.Write("Fourth Number: ");
            string fourthNumber = Console.ReadLine();

            int[] arrOfNumb = { int.Parse(firstNumber), int.Parse(secondNumber), int.Parse(thirdNumber), int.Parse(fourthNumber) };
            int num;
            bool numCheck = int.TryParse(firstNumber, out num);
            bool numCheck2 = int.TryParse(secondNumber, out num);
            bool numCheck3 = int.TryParse(thirdNumber, out num);
            bool numCheck4 = int.TryParse(fourthNumber, out num);

            if (numCheck || numCheck2 || numCheck3 || numCheck4)
            {

            int sum = 0;
            foreach(int item in arrOfNumb)
            {
                sum += item;
            }
            Console.WriteLine("The sum of this numbers is " + sum);
            int result = sum / arrOfNumb.Length;
            Console.WriteLine("The average of "+ firstNumber +", "+ secondNumber+", "+ thirdNumber + ", " + fourthNumber +" is "+ result);

            }
            else
            {
                Console.WriteLine("Please enter number");
            }



        }
    }
}

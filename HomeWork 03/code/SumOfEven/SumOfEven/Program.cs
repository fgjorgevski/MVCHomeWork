using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter six numbers and see the sum only from even numbers");
            int checkedFirstNumber;
            int checkedSecondNumber;
            int checkedThirdNumber;
            int checkedFourthNumber;
            int checkedFifthNumber;
            int checkedSixtNumber;

            bool firstNumber = int.TryParse(Console.ReadLine(), out checkedFirstNumber);
            bool secondNumber = int.TryParse(Console.ReadLine(), out checkedSecondNumber);
            bool thirdNumber = int.TryParse(Console.ReadLine(), out checkedThirdNumber);
            bool fourthNumber = int.TryParse(Console.ReadLine(), out checkedFourthNumber);
            bool fifthNumber = int.TryParse(Console.ReadLine(), out checkedFifthNumber);
            bool sixtNumber = int.TryParse(Console.ReadLine(), out checkedSixtNumber);
            
            
            if (firstNumber && secondNumber && thirdNumber && fourthNumber && fifthNumber && sixtNumber)
            {
                int[] arrOfNums = { checkedFirstNumber, checkedSecondNumber, checkedThirdNumber, checkedFourthNumber, checkedFifthNumber, checkedSixtNumber };
            int sum = 0;
            foreach (var num in arrOfNums)
            { 
                if(num % 2 == 0)
                {
                    sum += num;
                }

            }
            Console.WriteLine("The result is " + sum);

            }
            else
            {
                Console.WriteLine("Please enter six numbers");
            }






            Console.ReadLine();
        }
    }
}

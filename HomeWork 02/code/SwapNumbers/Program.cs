using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input 2 numbes and swap the values");
            Console.Write("First number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string secondNumber = Console.ReadLine();
            int.Parse(firstNumber);
            int.Parse(secondNumber);
            Console.WriteLine("Numbers before swapping");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);


            Console.WriteLine("Numbers after swapping");
            (firstNumber, secondNumber) = (secondNumber, firstNumber);
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);


            
            


        }
    }
}

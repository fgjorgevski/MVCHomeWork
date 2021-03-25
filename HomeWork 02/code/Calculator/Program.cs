using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please insert your name.");
            string name = Console.ReadLine();
            Console.Write(name + ", please choose arithmetic operator '+','-','*','/':");
            string aritOperat = Console.ReadLine();
            int num;
            if (aritOperat == "+")
            {
                Console.Write("First number: ");
                string firstNum = Console.ReadLine();
                bool numCheck = int.TryParse(firstNum, out num);

                Console.Write("Second number: ");
                string secondNum = Console.ReadLine();
                numCheck = int.TryParse(secondNum, out num);
                if (numCheck) { 
                
                int result = int.Parse(firstNum) + int.Parse(secondNum);
                Console.WriteLine("Result:" + result);
                }
                else
                {
                    Console.WriteLine("Please enter Number");
                }




            }
            else if (aritOperat == "-")
            {
                Console.Write("First number: ");
                string firstNum = Console.ReadLine();
                bool numCheck = int.TryParse(firstNum, out num);
                Console.Write("Second number: ");
                string secondNum = Console.ReadLine();
                numCheck = int.TryParse(secondNum, out num);
                if (numCheck)
                {

                    int result = int.Parse(firstNum) - int.Parse(secondNum);
                    Console.WriteLine("Result:" + result);
                }
                else
                {
                    Console.WriteLine("Please enter Number");
                }
            }
            else if (aritOperat == "*")
            {
                Console.Write("First number: ");
                string firstNum = Console.ReadLine();
                bool numCheck = int.TryParse(firstNum, out num);

                Console.Write("Second number: ");
                string secondNum = Console.ReadLine();
                numCheck = int.TryParse(secondNum, out num);
                if (numCheck)
                {

                    int result = int.Parse(firstNum) * int.Parse(secondNum);
                    Console.WriteLine("Result:" + result);
                }
                else
                {
                    Console.WriteLine("Please enter Number");
                }
            }
            else if (aritOperat == "/")
            {
                Console.Write("First number: ");
                string firstNum = Console.ReadLine();
                bool numCheck = int.TryParse(firstNum, out num);

                Console.Write("Second number: ");
                string secondNum = Console.ReadLine();
                numCheck = int.TryParse(secondNum, out num);
                if (numCheck)
                {

                    int result = int.Parse(firstNum) / int.Parse(secondNum);
                    Console.WriteLine("Result:" + result);
                }
                else
                {
                    Console.WriteLine("Please enter Number");
                }
            }
            else
            {
                Console.WriteLine(name + ", you can only enter operators!");
            }
            

            
        }
    }
}

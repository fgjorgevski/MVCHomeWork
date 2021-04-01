using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Maja", "Ana", "Mirko", "Jana", "Filip" };

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            string input = Console.ReadLine();
            if(input != "1" && input != "2")
            {
                Console.WriteLine("Please enter 1 or 2");
            }
            else { 
            if (input == "1")
            {
                foreach (var student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if(input == "2")
            {
                foreach (var student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            }


        }
    }
}

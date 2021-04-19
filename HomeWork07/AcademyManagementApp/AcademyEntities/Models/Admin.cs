using AcademyEntities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyEntities.Models
{
    public class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
        public int Id { get; set; }

        public List<Trainer> AddOptionTrainer { get; set; }
        public List<Trainer> RemoveOptionTrainer{ get; set; }
        public List<Student> AddOptionStudent{ get; set; }
        public List<Student> RemoveOptionStudent{ get; set; }






        public Admin()
        {

        }


        public Admin(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = maskPassword();
            Id = RandomId();
        }


        public int RandomId()
        {
            int randomId = new Random().Next(1, 100);
            return randomId;
        }

        public string maskPassword()
        {
            string pass = "";
            Console.Write("Password: ");
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;

                    Console.Write("*");
                }
                else
                {
                    Console.Write("\b");
                }
            }
            while (key.Key != ConsoleKey.Enter);
            return pass;

        }


        public virtual void info()
        {
            Console.WriteLine("-----------------------------------ADMIN-----------------------------------");
            Console.WriteLine($"Hello {FirstName} {LastName} ID:{Id}");
            Console.WriteLine("Write !help to see your options");

            Console.WriteLine("\n-----------------------------------COMMANDS----------------------------------");

            Console.WriteLine("!AddAdmin / !RemoveAdmin");
            Console.WriteLine("!AddTrainer / !RemoveTrainer");
            Console.WriteLine("!AddStudent / !RemoveStudent");

        }

    }
}

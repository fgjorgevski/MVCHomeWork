using AcademyEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEntities.Models
{
    public class Trainer : Admin
    {

        public List<Student> ShowAllStudents { get; set; }



        public Trainer()
        {

        }
        public Trainer(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
            Password = maskPassword();
            Id = RandomId();
            
        }





        public override void info()
        {
            Console.WriteLine("-----------------------------------TRAINER-----------------------------------");
            Console.WriteLine($"Trainer: {FirstName} {LastName} ID:{Id}");

            Console.WriteLine("\n-----------------------------------COMMANDS----------------------------------");
            Console.WriteLine("\n!Students - all students names.");
            Console.WriteLine("!Choose(student) - it will print all the subjects of student.");
            Console.WriteLine("!Subjects - all subject names appear with how many students attend it next to it.");

        }
        public  void printSub()
        {
            List<Subjects> subjectsList = Enum.GetValues(typeof(Subjects))
                                                    .Cast<Subjects>()
                                                    .ToList();
            foreach (var sub in subjectsList)
            {
                Console.WriteLine($"Subject:{sub}  Attenders:{new Random().Next(15, 40)}");
            }



        }



        }
    }

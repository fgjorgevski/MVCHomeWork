using AcademyEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEntities.Enums
{
    public class Student : Admin
    {

        public string Grades { get; set; }
        public Subjects Subject { get; set; }
        


        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = RandomId();
            Subject = randomSub();
        }


        

        public Subjects randomSub(){
            Array values = Enum.GetValues(typeof(Subjects));
            Random r = new Random();
            Subjects RandomSubjects = (Subjects)values.GetValue(r.Next(values.Length));
            return RandomSubjects;
        }
        public void RandomGrades()
        {
            List<Subjects> subjectsList = Enum.GetValues(typeof(Subjects))
                                                    .Cast<Subjects>()
                                                    .ToList();
            foreach (var sub in subjectsList)
            {
                Console.WriteLine($"Subject: {sub}  Grade: {new Random().Next(1, 5)}");
            }



        }



        public override void info()
        {
            Console.WriteLine("-----------------------------------STUDENT-----------------------------------");
            Console.WriteLine($"Hello {FirstName} {LastName} ID: {Id}");
            Console.WriteLine($"Current Subject: {Subject}");
            Console.WriteLine("-----------------------------------GRADES-----------------------------------");
            RandomGrades();
        }

        
    }




}




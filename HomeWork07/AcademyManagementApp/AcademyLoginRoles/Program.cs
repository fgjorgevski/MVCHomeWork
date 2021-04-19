using AcademyEntities.Enums;
using AcademyEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyLoginRoles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello to login please enter your role(Admin, Trainer, Student)");
            string roleInput = Console.ReadLine();

            switch (roleInput)
            {
                case "Admin":
                    AdminRole();
                    break;

                case "Trainer":
                    TrainerRole();
                    break;
                case "Student":
                    StudentRole();
                    break;
                default:
                    Console.WriteLine("Please enter your role!");
                    break;
            }


        }

        public static void AdminRole()
        {

            Console.Write("First Name: ");
            string firsName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Admin newAdmin = new Admin(firsName, lastName);
            Console.Clear();

            while (true)
            {
                newAdmin.info();
                string removeOrAdd = Console.ReadLine();

                trainerOption(removeOrAdd);
                continue;
            }




        }


        public static void TrainerRole()
        {

            Console.Write("First Name: ");
            string firsName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Trainer newTrainer = new Trainer(firsName, lastName);
            Console.Clear();


            while (true)
            {
                newTrainer.info();
                string optionInput = Console.ReadLine();

                if (optionInput == "!Students")
                {
                    printAllStudents();

                    continue;
                }
                else if (optionInput == "!Choose")
                {
                    Console.WriteLine("Choose student by starting char");
                    string studentChoosing = Console.ReadLine();
                    filterStudent(studentChoosing);

                    continue;
                }

                else if (optionInput == "!Subjects")
                {
                    newTrainer.printSub();

                    continue;
                }
                else
                {
                    Console.WriteLine("Please use only the commands on the list!");

                    return;
                }
            }
        }
        public static void StudentRole()
        {
            Console.Write("First Name: ");
            string firsName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            int r = new Random().Next();
            Student newStudent = new Student(firsName, lastName);

            Console.Clear();

            newStudent.info();
        }

        public static List<Trainer> trainerOption(string addOrRemove)
        {
            List<Trainer> listOfTrainers = new List<Trainer>();
            if (addOrRemove == "!AddTrainer")
            {
                Console.WriteLine("Please enter FirstName and Lastname of trainer");
                Console.Write("First Name:");
                string firstName = Console.ReadLine();
                Console.Write("Last Name:");
                string lastName = Console.ReadLine();
                Trainer addTrainer = new Trainer(firstName, lastName);
                Console.Clear();
                listOfTrainers.Add(addTrainer);

                foreach (var trainer in listOfTrainers)
                {
                    Console.WriteLine($"You add {trainer.FirstName} {trainer.LastName} as a Role: Trainer");
                }
            }
            else if (addOrRemove == "!RemoveTrainer")
            {

                Console.WriteLine("Please enter Firstname of trainer to remove");
                Console.Write("First Name:");
                 string fName = Console.ReadLine();
                List<Trainer> filterList = listOfTrainers.Where(name => fName == name.FirstName).ToList();
                foreach (var name in filterList)
                {
                    listOfTrainers.Remove(name);
                    Console.WriteLine($"You deleted {name.FirstName} as Role:Admin");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid Firstname and Lastname");
            }

            return listOfTrainers;        
        }





        public static void printAllStudents()
        {
            List<Student> students = StudentGenerator();
                foreach (var stud in students)
                {
                    Console.WriteLine($"FirstName: {stud.FirstName}  LastName: {stud.LastName} ID:{stud.Id}");
                }
  
        }


        public static List<Student> filterStudent(string chooseStud)
        {
            List<Student> students = StudentGenerator();
            List<Student> onlyOneStud = students.Where(student => chooseStud == student.FirstName).ToList();

            foreach (var stud in onlyOneStud)
            {
                Console.WriteLine($"FirstName: {stud.FirstName}  LastName: {stud.LastName} ID:{stud.Id}");
                stud.RandomGrades();

            }

            return onlyOneStud;

        }


        public static  List<Student> StudentGenerator()
        {
            var student1 = new Student("Zivko", "Jankovic");
            var student2 = new Student("Mitre", "Bilic");
            var student3 = new Student("Jovan", "Nikolov");
            var student4 = new Student("Petar", "Mijalkov");
            var student5 = new Student("Marija", "Gucova");
            var student6 = new Student("Ivana", "Konzulova");
            var student7 = new Student("Sandra", "Temova");
            var student8 = new Student("Sara", "Ristova");
            var student9 = new Student("Eli", "Kostadinova");

            List<Student> students = new List<Student>() { student1, student2, student3, student4, student5, student6, student7, student8, student9 };

            return students;
        }
        public static List<Subjects> SubjectGenerator()
        {
            List<Subjects> subjectsList = Enum.GetValues(typeof(Subjects))
                                                    .Cast<Subjects>()
                                                    .ToList();
            return subjectsList;

        }


    }
}

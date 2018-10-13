using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 3; i++)
            {
                students.Add(InputStudent());
            }

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1) Show all female students");
            Console.WriteLine("2) Show all students with a live account");
            Console.WriteLine("3) Show all students that have programmer in expectations");
            int input;
            bool isInputValid = Int32.TryParse(Console.ReadLine(), out input);
            do
            {
                switch (input)
                {
                    case 1:
                        foreach (var student in students.Where(student => student.Gender == Gender.Female))
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;
                    case 2:
                        foreach (var student in students.Where(student =>
                        student.Email.Split('@')[1] == "hotmail.com" ||
                        student.Email.Split('@')[1] == "live.com" ||
                        student.Email.Split('@')[1] == "outlook.com"))
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;
                    case 3:
                        foreach (var student in students.Where(student=> student.Expectations.Split(' ').Where(word=> word=="programmer").Count() > 0))
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
                isInputValid = Int32.TryParse(Console.ReadLine(), out input);

            }
            while (isInputValid);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public static Student InputStudent()
        {
            Console.WriteLine("Enter Information about a new student:");
            Console.Write("Enter a student First Name: ");
            var inputName = Console.ReadLine();
            Console.Write("Enter a student Last Name: ");
            var inputLast = Console.ReadLine();
            Console.Write("Enter a student Gender ( F/M ): ");
            var inputGender = Console.ReadLine().ToLower() == "f" ? Gender.Female : Gender.Male;
            Console.Write("Enter a student Email: ");
            var inputEmail = Console.ReadLine();
            Console.Write("Enter student expectations from the academy: ");
            string inputExpectations = Console.ReadLine();
            return new Student(inputName, inputLast, inputGender, inputEmail, inputExpectations);

        }
    }
}

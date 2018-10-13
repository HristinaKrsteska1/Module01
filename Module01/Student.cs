using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Expectations { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Gender} {Email} Expectations: {Expectations}";
        }

        public Student(string firstName, string lastName, Gender gender, string eMail, string expectations)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = eMail;
            Expectations = expectations;
            
        }

    }
}

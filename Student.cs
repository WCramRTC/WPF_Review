using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Review
{
    internal class Student
    {

        string _firstName;
        string _lastName;
        string _studentID;

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;

            Random rand = new Random();
            _studentID = rand.Next(100000000, 1000000000).ToString();
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} - {_studentID}";
        }
    }
}

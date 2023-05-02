using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Review
{
    internal static class Data
    {

        private static ObservableCollection<Student> _student;

        // static constructor
        // this only runs the first time a member in the containing class is called
        // Takes no parameters
        static Data()
        {
            _student = new ObservableCollection<Student>();

            _student.Add(new Student("Will", "Cram"));
        }

        internal static ObservableCollection<Student> Students { get => _student; }


        // Create a method to add a student
        public static void AddStudent(Student student)
        {
            _student.Add(student);
        }



    }
}

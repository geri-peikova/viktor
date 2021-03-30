using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        public static List<Student> TestStudents = new List<Student>();

        public StudentData()
        {
            TestStudents.Add(new Student("Gosho", "Goshev", "Goshov", "FKST", "KSI", "Bakalavur", "200 OK", "121218017", "2018", "1", "50"));
        }
        public static bool IsFacultyNumberValid(string facultyNumber)
        {
            var studentResult = (from student in TestStudents
                              where facultyNumber == student.FacultyNumber
                              select student);
            return studentResult.Any();
        }

        public static Student GetStudentByFacultyNumber(string facultyNumber)
        {
            var studentResult = (from student in TestStudents
                              where facultyNumber == student.FacultyNumber
                              select student);
            if (studentResult.Any())
                return studentResult.First();
            else
                return null;
        }
    }
}

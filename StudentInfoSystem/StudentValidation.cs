using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public Student GetStudentDataByUser(UserLogin.User user)
        {
            if (!user.FacultyNumber.Equals(string.Empty)
                || StudentData.IsFacultyNumberValid(user.FacultyNumber))
                return new Student();
            return null;
        }
    }
}

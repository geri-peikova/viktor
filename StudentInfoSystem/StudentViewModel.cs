using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem
{
    internal class StudentViewModel
    {
        private StudentData studentData;

        public ICommand CheckCommand { get; private set; }
        public ICommand ClearCommand { get; private set; }

        public Student Student { get; set; }
        public State FormState { get; set; }

        public StudentViewModel()
        {
            Student = new Student();
            FormState = new State();
            studentData = new StudentData();
            CheckCommand = new StudentCheckCommand(this);
            ClearCommand = new StudentClearCommand(this);
        }

        public void ClearForm()
        {
            if (Student != null)
                Student.Clear();
            else
                Student.SetStudent(new Student());
        }

        public bool CanCheck {
            get
            {
                if (Student == null)
                    return false;
                return !string.IsNullOrEmpty(Student.FacultyNumber);
            }
        }
        public void SaveChanges()
        {
            Student student = StudentData.GetStudentByFacultyNumber(Student.FacultyNumber);
            UserLogin.User user = UserLogin.UserData.GetUserByFacultyNumber(Student.FacultyNumber);
            if (student != null)
            {
                if (user != null)
                    student.LastEnter = user.LastEnter.ToString();
                Student.SetStudent(student);
            }
            else
            {
                Student.Clear();
                FormState.IsEnabled = false;
            }
        }
    }
}

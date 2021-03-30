using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student : INotifyPropertyChanged
    {
        private string name;
        private string middleName;
        private string lastName;
        private string faculty;
        private string major;
        private string degree;
        private string status;
        private string facultyNumber;
        private string year;
        private string stream;
        private string group;
        private string lastEnter;

        public Student(string name,
            string middleName,
            string lastName,
            string faculty,
            string major,
            string degree,
            string status,
            string facultyNumber,
            string year,
            string stream,
            string group)
        {
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Major = major;
            Degree = degree;
            Status = status;
            FacultyNumber = facultyNumber;
            Year = year;
            Stream = stream;
            Group = group;
        }

        public void SetStudent(Student student)
        {
            Name = student.name;
            MiddleName = student.middleName;
            LastName = student.lastName;
            Faculty = student.faculty;
            Major = student.major;
            Degree = student.degree;
            Status = student.status;
            FacultyNumber = student.facultyNumber;
            Year = student.year;
            Stream = student.stream;
            Group = student.group;
            LastEnter = student.lastEnter;
        }
        public void Clear()
        {
            Name = "";
            MiddleName = "";
            LastName = "";
            Faculty = "";
            Major = "";
            Degree = "";
            Status = "";
            FacultyNumber = "";
            Year = "";
            Stream = "";
            Group = "";
            LastEnter = "";
        }

        public Student(){}

        public string Name  {
            get {
                return name;
            }
            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string MiddleName
        {
            get {
                return middleName;
            }
            set {
                middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }
        public string LastName
        {
            get {
                return lastName;
            }
            set {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string Faculty
        {
            get {
                return faculty;
            }
            set {
                faculty = value;
                OnPropertyChanged("Faculty");
            }
        }
        public string Major
        {
            get {
                return major;
            }
            set {
                major = value;
                OnPropertyChanged("Major");
            }
        }
        public string Degree
        {
            get {
                return degree;
            }
            set {
                degree = value;
                OnPropertyChanged("Degree");
            }
        }
        public string Status
        {
            get {
                return status;
            }
            set {
                status = value;
                OnPropertyChanged("Status");
            }
        }
        public string FacultyNumber
        {
            get {
                return facultyNumber;
            }
            set {
                facultyNumber = value;
                OnPropertyChanged("FacultyNumber");
            }
        }
        public string Year
        {
            get {
                return year;
            }
            set {
                year = value;
                OnPropertyChanged("Year");
            }
        }
        public string Stream
        {
            get {
                return stream;
            }
            set {
                stream = value;
                OnPropertyChanged("Stream");
            }
        }
        public string Group
        {
            get {
                return group;
            }
            set {
                group = value;
                OnPropertyChanged("Group");
            }
        }

        public string LastEnter
        {
            get {
                return lastEnter;
            } set
            {
                lastEnter = value;
                OnPropertyChanged("LastEnter");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #region INotifyPropertyChanged Members
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

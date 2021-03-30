using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public User() {}
        public User(string username, string password, string facultyNumber, DateTime created, DateTime validUntil, UserRoles role)
        {
            this.Username = username;
            this.Password = password;
            this.FacultyNumber = facultyNumber;
            Created = created;
            ValidUntil = validUntil;
            this.Role = role;
        }

        public String Username { get; set; }
        public String Password { get; set; }
        public String FacultyNumber { get; set; }
        public DateTime Created { get; set; }
        public DateTime ValidUntil { get; set; }
        public UserRoles Role { get; set; }
        public DateTime LastEnter { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {

        static private List<User> _testUsers;
        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }

            set { }
        }
        public static bool AssignUserRole(String username, UserRoles role)
        {
            foreach (User user in TestUsers)
            {
                if (username == user.Username)
                {
                    user.Role = role;
                    Logger.LogActivity("Role change on user " + username);
                    return true;
                }
            }
            return false;
        }

        public static bool SetUserActiveTo(String username, DateTime newDate)
        {
            foreach (User user in TestUsers)
            {
                if (username == user.Username)
                {
                    user.ValidUntil = newDate;
                    Logger.LogActivity("Validity change on user " + username);
                    return true;
                }
            }
            return false;
        }

        public static User IsUserPassCorrect(String username, String password)
        {
            var userResult = (from user in TestUsers
                              where username == user.Username && password == user.Password
                              select user);
            if (userResult.Any())
                return userResult.First();
            else
                return null;
        }

        public static User GetUserByFacultyNumber(string facultyNumber)
        {
            var userResult = (from user in TestUsers
                                 where facultyNumber == user.FacultyNumber
                                 select user);
            if (userResult.Any())
                return userResult.First();
            else
                return null;
        }

        static private void ResetTestUserData()
        {
            if (_testUsers == null)
            {
                _testUsers = new List<User>();
                _testUsers.Add(new User("Gosho", "otpochiwka", "121218017", DateTime.Now, new DateTime(0), UserRoles.ADMIN));
                _testUsers.Add(new User("Pesho", "parolalalala", "121218037", DateTime.Now, new DateTime(0), UserRoles.STUDENT));
                _testUsers.Add(new User("Sasho", "asdasdasdasdasd", "121218027", DateTime.Now, new DateTime(0), UserRoles.STUDENT));
                _testUsers[0].LastEnter = DateTime.Now;
            }
        }
    }
}

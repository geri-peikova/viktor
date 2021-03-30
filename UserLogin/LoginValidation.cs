using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private String username;
        private String password;
        private ActionOnError actionOnError;
        public static String ErrorMessage { get; set; }
        public static UserRoles CurrentUserRole { get; private set; }
        public static String CurrentUserUsername { get; private set; }

        public delegate void ActionOnError(string errorMsg);
        public bool ValidateUserInput(ref User user)
        {
            int usernameLen = username.Length;
            int passwordLen = password.Length;
            CurrentUserRole = UserRoles.ANONYMOUS;
            CurrentUserUsername = "Anonimniq tip";

            if (usernameLen == 0 || passwordLen == 0)
            {
                ErrorMessage = "Username or password is empty";
                actionOnError(ErrorMessage);
                return false;
            } else if (usernameLen < 5 || passwordLen < 5)
            {
                ErrorMessage = "Username or password is less than 5 characters long";
                actionOnError(ErrorMessage);
                return false;
            }
            
            User userResult = UserData.IsUserPassCorrect(username, password);
            
            if (userResult == null)
            {
                ErrorMessage = "Username or password is incorrect";
                actionOnError(ErrorMessage);
                return false;
            }

            user.Username = username;
            user.Password = password;
            user.Role = userResult.Role;
            user.FacultyNumber = userResult.FacultyNumber;
            user.LastEnter = DateTime.Now;
            CurrentUserRole = userResult.Role;
            CurrentUserUsername = userResult.Username;

            Logger.LogActivity("Successful login");
            return true;
        }

        public LoginValidation(String username, String password, ActionOnError action)
        {
            this.username = username;
            this.password = password;
            this.actionOnError = action;
        }

    }
}

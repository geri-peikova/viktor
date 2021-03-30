using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem
{
    class LoginViewModel
    {
        public Login Login { get; set; }
        public ICommand LoginCommand { get; private set; }
        public LoginViewModel()
        {
            Login = new Login();
            LoginCommand = new LoginCommand(this);
        }

        public bool CanCheck
        {
            get
            {
                if (Login == null)
                    return false;
                return !(string.IsNullOrEmpty(Login.Username) || string.IsNullOrEmpty(Login.Password));
            }
        }
        public void SaveChanges()
        {
            UserLogin.User user = UserLogin.UserData.IsUserPassCorrect(Login.Username, Login.Password);
            if (user != null)
            {
                if (user.Role == UserLogin.UserRoles.ADMIN)
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                }
            }
        }
    }
}

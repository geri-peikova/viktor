using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    class ShowUsersModelView
    {
        public ObservableCollection<string> Users { get; set; }


        public ShowUsersModelView()
        {
            Users = new ObservableCollection<string>();
            foreach (User user in UserData.TestUsers)
            {
                Users.Add(user.Username);
            }
        }
    }
}

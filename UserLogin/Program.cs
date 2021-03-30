using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        private static void StudentMenu(User user)
        {
            Console.WriteLine("Username: " + user.Username);
            Console.WriteLine("Password: " + user.Password);
            Console.WriteLine("Faculty number: " + user.FacultyNumber);
            Console.WriteLine("Role: " + user.Role);
        }

        private static void AdminMenu()
        {
            Console.WriteLine("~~MENU~~");
            Console.WriteLine("1. Change user valid date");
            Console.WriteLine("2. Change user role");
            Console.WriteLine("3. List Users");
            Console.WriteLine("4. View log");
            Console.WriteLine("5. View current session's log");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter Username: ");
                    String username = Console.ReadLine();
                    Console.WriteLine("Enter validity day: ");
                    String date = Console.ReadLine();
                    UserData.SetUserActiveTo(username, DateTime.Parse(date));
                    break;
                case "2":
                    Console.WriteLine("Enter Username: ");
                    String us = Console.ReadLine();
                    Console.WriteLine("Enter new role: ");
                    String roleString = Console.ReadLine();
                    UserRoles role = (UserRoles)Enum.Parse(typeof(UserRoles), roleString, true);
                    UserData.AssignUserRole(us, role);
                    break;
                case "3":
                    foreach (User user in UserData.TestUsers)
                    {
                        Console.WriteLine(user.Username);
                    }
                    break;
                case "4":
                    if (File.Exists("activity.log"))
                    {
                        foreach (string line in Logger.GetActivitiesLogFile())
                        {
                            Console.WriteLine(line);
                        }
                    }
                    else
                        Console.WriteLine("No file");
                    break;
                case "5":

                    StringBuilder sb = new StringBuilder();

                    foreach (string activity in Logger.GetCurrentSessionActivities(""))
                    {
                        sb.Append(activity);
                    }
                    Console.WriteLine(sb.ToString());
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Username: ");
            String username = Console.ReadLine();
            Console.WriteLine("Password: ");
            String password = Console.ReadLine();

            LoginValidation LogVal = new LoginValidation(username, password, (String err) => { 
                Console.WriteLine("!!" + err + "!!");
                Logger.LogActivity("Error: " + err);
            });

            User user = new User();
            

            if (LogVal.ValidateUserInput(ref user))
            {
                switch (LoginValidation.CurrentUserRole)
                {
                    case UserRoles.ADMIN :
                        Console.WriteLine("Zdr shefe");
                        AdminMenu();
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("Zdr malak student");
                        StudentMenu(user);
                        break;
                    case UserRoles.ANONYMOUS:
                        Console.WriteLine("koi si ti");
                        break;
                }
            }
        }
    }
}

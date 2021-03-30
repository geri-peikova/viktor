using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UserLogin
{
    public static class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            return (from activity in currentSessionActivities
                    where activity.Contains(filter)
                    select activity).ToList();
        }

        static public IEnumerable<string> GetActivitiesLogFile()
        {
            return (from line in File.ReadLines("activity.log")
                    where line.Length > 0
                    select line);
        }
        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
                + LoginValidation.CurrentUserUsername + ";" 
                + LoginValidation.CurrentUserRole + ";"
                + activity;

            currentSessionActivities.Add(activityLine);

            File.AppendAllText("activity.log", activityLine + "\n");
        }
    }
}

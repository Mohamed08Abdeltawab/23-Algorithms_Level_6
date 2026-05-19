using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitySelection
{
    public class Activity
    {
        public int Start { get; set; }
        public int Finish { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Activity { Start = 1, Finish = 4 },
                new Activity { Start = 3, Finish = 5 },
                new Activity { Start = 0, Finish = 6 },
                new Activity { Start = 5, Finish = 7 },
                new Activity { Start = 8, Finish = 9 },
                new Activity { Start = 5, Finish = 9 },
            };

            var selectedActivities = SelectedActivity(activities);


                Console.WriteLine("Selected activities:");
            foreach (var activity in selectedActivities)
            {
                Console.WriteLine($"Start: {activity.Start}, Finish: {activity.Finish}");
            }
            Console.WriteLine($"\nCount of selected activities: {selectedActivities.Count}");
        }

        public static List<Activity> SelectedActivity(List<Activity> activities)
        {
            // sort activities by finish time to ensure we always select the activity that finishes earliest
            var sortedActivities = activities.OrderBy(a => a.Finish).ToList();

            //cearte a list to hold the selected activities
            List<Activity> selected = new List<Activity>();

            // keep track of the finish time of the last selected activity
            int lastFinishTime = -1;
            // iterate through the sorted activities and select those that start after the last selected activity finishes
            foreach(var activity in sortedActivities)
            {
                if(activity.Start >= lastFinishTime)
                {
                    selected.Add(activity);
                    lastFinishTime = activity.Finish;
                }
            }

            return selected;
        }
    }
}

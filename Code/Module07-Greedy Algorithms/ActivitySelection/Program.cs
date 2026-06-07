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

        public Activity(int start, int finish)
        {
            Start = start;
            Finish = finish;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Activity (1,4),
                new Activity (3,5),
                new Activity (0,6),
                new Activity (5,7),
                new Activity (8,9),
                new Activity (5,9),
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
            //var sortedActivities = activities.OrderBy(a => a.Finish).ToList();

            activities.Sort((a,b) => a.Finish.CompareTo(b.Finish));
            //cearte a list to hold the selected activities
            List<Activity> selected = new List<Activity>();

            // keep track of the finish time of the last selected activity
            Activity lastSelectedActivity = null;
            // iterate through the sorted activities and select those that start after the last selected activity finishes
            foreach(var activity in activities)
            {
                if(lastSelectedActivity == null || activity.Start >= lastSelectedActivity.Finish)
                {
                    selected.Add(activity);
                    lastSelectedActivity = activity;
                }
            }

            return selected;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            Running run1 = new Running("12/02/2025", 30, 3.10);
            Cycling bike1 = new Cycling("12/03/2025", 45, 14.50);
            Swimming swim1 = new Swimming("12/04/2025", 40, 64);

            activities.Add(run1);
            activities.Add(bike1);
            activities.Add(swim1);

            for (int i = 0; i < activities.Count; i++)
            {
                Activity a = activities[i];
                Console.WriteLine(a.GetSummary());
            }
        }
    }
}

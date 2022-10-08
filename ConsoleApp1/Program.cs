using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution.solve(new String[] { "23:00", "04:22", "18:05", "06:24" });
        }
    }
    public class Solution
    {
        public static string solve(string[] arr)
        {
            //TimeSpan t = TimeSpan.Parse(arr[0]);
            List<TimeSpan> ts = arr.Select(x => TimeSpan.Parse(x)).ToList();
            ts.Sort();
            ts = ts.Distinct().ToList();
            string result = "";
            if (ts.Count > 1)
            {
                TimeSpan duration = TimeSpan.Zero;
                for (int i = 0; i < ts.Count; i++)
                {                
                    for (int k = 0; k < ts.Count; k++)
                    {
                        if (i == k)
                        {
                            continue;
                        }
                        if (ts[k] - ts[i] > duration && ts[k] > ts[i])
                        {
                            if (ts[k] - ts[i] > new TimeSpan(12, 0, 0))
                            {
                                if (ts[k] - ts[i] - new TimeSpan(12, 0, 0) > duration)
                                {
                                    duration = ts[k] - ts[i] - new TimeSpan(12, 0, 0);
                                }
                            }
                            else { duration = ts[k] - ts[i]; }
                        }
                    }
                    //ts.RemoveAt(i);
                }
                duration += new TimeSpan(0, 1, 0);
                result = duration.ToString(@"hh\:mm");
            }
            else if(ts.Count == 1)
            {
                result = "23:59";
            }
            return result;


        }
    }

}

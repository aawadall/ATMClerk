using System;
using Microsoft.AppCenter; 
using Microsoft.AppCenter.Analytics;
namespace ATMClerk.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            AppCenter.Start("127517ff-3ad0-490d-884c-c93edca80281", typeof(Analytics));
            Event ev = new Event();

            Console.WriteLine($"Event Id = {ev.Id}");
            Console.WriteLine($"Query ID once again {ev.Id}");
        }
    }
}

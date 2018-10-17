using System;
using Microsoft.AppCenter; 
using Microsoft.AppCenter.Analytics;
namespace ATMClerk.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Event ev = new Event();

            Console.WriteLine($"Event Id = {ev.Id}");
            Console.WriteLine($"Query ID once again {ev.Id}");

            Currency curr = new Currency("Canadian Dollars", "CAD", "124", 2);
            Console.WriteLine($"New Currency Created {curr.Name} as {curr.Code} ");
        }
    }
}

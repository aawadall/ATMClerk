using System;

namespace ATMClerk.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Event ev = new Event();

            Console.WriteLine($"Event Id = {ev.Id}");
            Console.WriteLine($"Query ID once again {ev.Id}");
        }
    }
}

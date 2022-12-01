using FunctionalProgramming;
using System;

namespace FunctionalProgramming1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calling Harmonic Number");

            Console.WriteLine("Calling Quotient reminder");
            QuotientAndRemindercls quotientAndRemindercls =new QuotientAndRemindercls();
            quotientAndRemindercls.QuotientAndReminder();

            Console.WriteLine("Calling Leap Year");
            LeapYear xyz = new LeapYear();
            xyz.leap();

            Console.ReadLine();
        }
    }
}

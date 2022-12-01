using FunctionalProgramming;
using System;

namespace FunctionalProgramming1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calling Prime Factor");
            PrimeFactor primeFactor = new PrimeFactor();
            primeFactor.Factor();

            Console.WriteLine("Calling Power Of Two");
            PowerOfTwo powerOfTwo = new PowerOfTwo();
            powerOfTwo.Power();

            Console.WriteLine("Calling for Largest Number Among Three");
            LargestNumberAmongThree largestNumberAmongThree = new LargestNumberAmongThree();
            largestNumberAmongThree.LargestNumber();

            Console.WriteLine("Calling VowelOrConsonant");
            VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
            vowelOrConsonant.Vowel();

            Console.WriteLine("Calling EvenOrOdd");
            EvenOrOdd evenOrOdd = new EvenOrOdd();
            evenOrOdd.Even();

            Console.WriteLine("Calling Swap Two Numbers");
            SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
            swapTwoNumbers.Swap();

            Console.WriteLine("Calling Harmonic Number");
            HarmonicNumber harmonicNumber = new HarmonicNumber();
            harmonicNumber.Harmonic();

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

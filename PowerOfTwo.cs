using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    internal class PowerOfTwo
    {
        public void Power()
        {
            int num;
            Console.Write("Enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            bool result = ((num & -num) == num);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

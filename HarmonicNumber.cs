using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FunctionalProgramming
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            int i, n;
            double s = 0.0;

            Console.Write("Calculate the harmonic series");

            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
        }
    }
}

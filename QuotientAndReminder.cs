using System;

public class QuotientAndRemindercls
{
	public void QuotientAndReminder()
	{
        int dividend = 50, divisor = 8;

        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        {
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}

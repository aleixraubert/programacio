using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            const string MSG_IS = "Is a leap year.", MSG_ISNT = "Is not a leap year.";
            int year;

            Console.WriteLine("Introduce a year ot knwo if it is a leap year or not: ");

            year=Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0) Console.WriteLine(MSG_IS);
            else Console.WriteLine(MSG_ISNT);
        }
    }
}
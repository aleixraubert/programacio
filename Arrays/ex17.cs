using System;
using System.Xml.Schema;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            const string MSG_Welcome = "Quants valors vols emmagatzemar?";
            const string MSG_Error = "El nombre no es natural, tornahi.";

            int temp, total = 0, size, greater_than_thirty = 0, lower_that_fifty = 0, trys = 0;

            Console.WriteLine(MSG_Welcome);

            size = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[size];

            int i = 0;

            while (trys < 3 && i < size)
            {
                temp = Convert.ToInt32(Console.ReadLine());

                while (trys < 3 && temp < 0)
                {
                    Console.WriteLine(MSG_Error);
                    trys++;
                    temp = Convert.ToInt32(Console.ReadLine());
                }

                if (temp > 0)
                {
                    nums[i] = temp;
                    total++;
                }

                if (temp > 30) greater_than_thirty++;

                if (temp < 15) lower_that_fifty++;
                i++;
            }

            Console.WriteLine("Total de nombres introduits " + total);
            Console.WriteLine("Total de nombres més petits de 15 " + lower_that_fifty);
            Console.WriteLine("Total de nombres mes grans de 30 " + greater_than_thirty);
        }
    }
}
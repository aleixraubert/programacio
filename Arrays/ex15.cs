using System;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            const string MSG_welcome = "Quants valors vols intorudir?";

            int size, result=0;

            Console.WriteLine(MSG_welcome);

            size=Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
                result += nums[i];
            }

            Console.WriteLine(result);

        }
    }
}
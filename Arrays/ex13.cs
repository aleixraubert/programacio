using System;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            const int SIZE = 20;

            int[] nums = new int[SIZE];

            for(int i=0; i < SIZE; i++) nums[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < SIZE; i++) if (i % 2 != 0) Console.Write(nums[i] + " ");
        }
    }
}
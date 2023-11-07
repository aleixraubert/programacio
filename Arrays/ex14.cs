using System;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            const int SIZE = 5;

            int[] nums = new int[SIZE];

            for(int i=0; i < SIZE; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i < SIZE; i++) Console.Write(nums[i] + " ");

            Console.WriteLine();

            for (int i = SIZE-1; i >= 0; i--) Console.Write(nums[i] + " ");
        }
    }
}
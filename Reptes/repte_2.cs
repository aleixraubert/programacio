using System;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            int num, rows,total, square;

            num=Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<num; i++)
            {
                square = 1;
                total = 0;

                rows=Convert.ToInt32(Console.ReadLine());

                for(int j=0; j<rows; j++)
                {
                    total += square * square;
                    square++;
                }

                Console.WriteLine(total);
            }
        }
    }
}
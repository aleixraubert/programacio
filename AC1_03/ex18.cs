using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            int height;

            Console.WriteLine("Introduce la altura de la piramide: ");

            height=Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<height+1; i++)
            {
                for (int j = 0; j < i; j++) Console.Write("#");
                Console.WriteLine();
            }
        }
    }
}
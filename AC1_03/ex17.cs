using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {

            for(int i=1; i<10; i++)
            {
                for (int j = 1; j < 10; j++) Console.Write((j * i) + " ");
                Console.WriteLine();
            }
        }
    }
}
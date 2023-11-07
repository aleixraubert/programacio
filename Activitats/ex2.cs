using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            const int Min= 2000, Max = 3000;
            bool first = false;

            for(int i=Min; i<=Max; i++)
            {
                
                if (i%7==0 && i/5!=0)
                {
                    if (first) Console.Write(",");
                    Console.Write(i);
                    first = true;
                }
            }
        }
    }
}
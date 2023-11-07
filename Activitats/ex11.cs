/*
 * Author: Aleix Raubert
 * M03. Programació UF1
 * v1. 09/10/2023
 * Exercici 14. 
 *
 **/

using System;

namespace prog
{
    class Asterisc
    {
        static void Main()
        {
            int num, num_temp, firsttemp, secondtemp, numbers=0, mod=1;
            bool found = true;

            num=num_temp=Convert.ToInt32(Console.ReadLine());

            while (num_temp > 0)
            {
                num_temp /= 10;
                numbers++;
            }

            num_temp = num;

            for (int i = 0; i < numbers - 1; i++) mod *= 10;

            while (found && numbers>0)
            {
                firsttemp = num / mod;

                secondtemp = num % 10;

                if (firsttemp != secondtemp) found = false;
                
                numbers-=2;
                num = (num % mod) / 10;
                mod /=100;
            }

            if (found) Console.WriteLine("És palindromo.");
            else Console.WriteLine("No és palindromo.");
        }
    }
}



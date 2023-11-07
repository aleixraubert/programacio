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
            int num, result=1;

            num=Convert.ToInt32(Console.ReadLine());

            for (int i = num; i > 0; i--) result *= i;

            Console.WriteLine(result);
        }
    }
}



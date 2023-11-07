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
            int num, result=0, last=0;

            num = Convert.ToInt32(Console.ReadLine());


            for(int i=0; i<num; i++)
            {
                if (result == 0)
                {
                    Console.Write(result + " ");
                    result++;
                }
                else if (result == 1)
                {
                    last = result;
                    Console.Write(result + " ");
                    result++;
                }
                else
                {
                    int temp = last;

                    last = result;

                    result = temp + last;
                }
                Console.Write(result + " ");
            }
        }
    }
}



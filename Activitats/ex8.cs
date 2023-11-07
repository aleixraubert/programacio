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
            const string MSG_W = "Intorduce un número para saber si es primo o no: ";
            const string MSG_IS = "Es un número primo.";
            const string MSG_ISNT = "No es un número primo.";
            int num, i=2;
            bool found_square = false, found_prim=false;


            Console.WriteLine(MSG_W);

            num=Convert.ToInt32(Console.ReadLine());   

            if(num==0 || num==1) Console.WriteLine(MSG_ISNT);
            else
            {
                while ((!found_square && !found_prim) && i<num)
                {
                    if(num%i==0) found_prim = true;
                    if (num % 2 == 0)
                    {
                        if (i * i == num) found_square = true;
                    }
                    else if (i * i == num - 1) found_square = true;
                    i++;
                }
            }

            if(!found_prim) Console.WriteLine(MSG_IS);
            else Console.WriteLine(MSG_ISNT);
        }
    }
}



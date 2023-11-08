/*
* Author: Aleix Raubert
* M03. Programació UF1
* v1. 8/1/2023
* Exercici 5. Implementa un programa que generi una matriu de 4x4 i mostri la diagonal principal (pots inicialitzar-la amb els valors enters que consideris).
*
*/



using System;
using System.Xml.Schema;

namespace prog
{
    class Repte_10_Alter
    {
        static void Main()
        {
            const string MSG_Welcome = "Tenim aquesta matriu: ";
            const string MSG_Welcome_Two = "La seva diagonal és: ";

            int[,] nums = { { 1, 2, 3, 4 }, { 4, 3, 2, 1 }, { 5, 6, 7, 8 }, { 9, 8, 7, 6 } };

            Console.WriteLine(MSG_Welcome);

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(MSG_Welcome_Two);

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if(i==j) Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

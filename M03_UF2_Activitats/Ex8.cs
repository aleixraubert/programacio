/*
 * Author: Aleix Raubert
 * M03. Programació UF2
 * v1. 29/11/2023
 * Exercici 8. Implementa un mètode que retorni 10 nombres al·leatoris entre 0 i 256.
 */


using System;

namespace Testing
{
    public class Acts
    {
        public static void Main()
        {
            for(int i=0; i<10; i++)
            {
                Console.Write(Acts.Random_Num() + " ");
            }
        }


        public static int Random_Num()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 256);
            return num;
        }
    }
}
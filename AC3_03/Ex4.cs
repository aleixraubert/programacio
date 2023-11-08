/*
* Author: Aleix Raubert
* M03. Programació UF1
* v1. 8/1/2023
* Exercici 4. Implementa un programa que generi un array, indicant la seva mida per teclat. L’usuari haurà d’indicar un número per teclat, de manera que els valors de cada posició seran nombres múltiples consecutius del valor introduït per teclat. Per exemple, si es defineix un array de grandària 5 i s’indica un 3 com a valor, l’array contindrà els valors 3, 6, 9, 12, 15.
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
            const string MSG_Welcome = "Bones, indica la mida del array: ";
            const string MSG_Welcome_Two = "Ara indica el valor per forma la array: ";

            int size, mult;

            Console.WriteLine(MSG_Welcome);

            size = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[size];

            Console.WriteLine(MSG_Welcome_Two);

            mult = Convert.ToInt32(Console.ReadLine());
            nums[0] = mult;

            for(int i=2; i<=nums.Length; i++)
            {
                nums[i-1] = mult*i;
            }


            foreach(int n in nums)
            {
                Console.Write(n + " ");
            }
        }
    }
}

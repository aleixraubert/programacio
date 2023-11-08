/*
 * Author: Aleix Raubert
 * M03. Programació UF1
 * v1. 8/1/2023
 * Exercici 1. Implementa un programa que demani a l’usuari quants valors vol introduir i el programa generi una llista, a partir de valors introduïts per teclat, retornant la suma de tots els elements d’aquesta.
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
            const string MSG_Welcome = "Quants valors vols introduir?:";
            const string MSG_Do = "Dons vinga, introduerix-los:";
            const string MSG_Final = "La suma és {0}.";

            Console.WriteLine(MSG_Welcome);

            int size=Convert.ToInt32(Console.ReadLine());

            int sum=0;

            int[] nums = new int[size];

            Console.WriteLine(MSG_Do);

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]=Convert.ToInt32(Console.ReadLine());
            }

            foreach(int i in nums)
            {
                sum += i;
            }

            Console.WriteLine(MSG_Final, sum);
        }
    }
}
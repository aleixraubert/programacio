/*
* Author: Aleix Raubert
* M03. Programació UF1
* v1. 8/1/2023
* Exercici 3. Implementa un programa que, donada la següent llista, retorni l’element més gran i el més petit.
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
            const string MSG_Welcome = "Tenim aquesta llista: [5,10,15,2,25,30,35,40].";
            const string MSG_Final = "Aquí està el element més gran {0}, i el element més petit {1}.";


            Console.WriteLine(MSG_Welcome);

            int[] nums = new int[] { 5, 10, 15, 2, 25, 30, 35, 40};

            int biggest = nums[0], lowest = nums[0];

            foreach(int num in nums)
            {
                if (num<lowest) lowest = num;
                if (num>biggest) biggest = num;
            }

            Console.WriteLine(MSG_Final, biggest, lowest);
        }
    }
}

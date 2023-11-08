/*
 * Author: Aleix Raubert
 * M03. Programació UF1
 * v1. 8/1/2023
 * Exercici 2. Donada la següent llista: a = [10,20,30,20,10,50,60,40,80,50,40] implementa un programa que retorni una llista sense els elements duplicats.
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
            const string MSG_Welcome = "Tenim aquesta llista: a = [10,20,30,20,10,50,60,40,80,50,40].";
            const string MSG_Final = "Aquí està la llista sense elements duplicats.";


            Console.WriteLine(MSG_Welcome);

            int[] nums = new int[] { 10, 20, 30, 20, 10, 50, 60, 40, 80, 50, 40 };

            int[] no_rep = new int[nums.Length];

            for(int i=0; i<nums.Length-1; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        int aux = nums[j];
                        nums[j] = nums[i];
                        nums[i] = aux;
                    }
                }
            }

            int k = 0;

            for(int i=0 ; i<nums.Length-1 ; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    no_rep[k] = nums[i];
                    k++;
                }

            }

            if (nums[nums.Length-1] != no_rep[k]) no_rep[k + 1] = nums[nums.Length-1];

            Console.WriteLine(MSG_Final);

            foreach(int i in no_rep)
            {
                if(i!=0) Console.Write(i + " ");
            }
        }
    }
}


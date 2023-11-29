/*
 * Author: Aleix Raubert
 * M03. Programació UF2
 * v1. 29/11/2023
 * Exercici 6. Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net.
 */


using System;

namespace Testing
{
    public class Acts
    {
        public static void Main()
        {
            const string MSG = "Introdueix un valor per a obtenir el valor absolut.";

            Console.WriteLine(MSG);

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Acts.Absolut(num));
        }


        public static int Absolut(int num)
        {
            return Math.Abs(num);
        }
    }
}
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
            const string MSG_Wel = "Introduce una nota: "; 
            double note;

            Console.WriteLine(MSG_Wel);
            note=Convert.ToDouble(Console.ReadLine());

            if (note < 5 && note >=0) Console.WriteLine("Suspés");
            else
            {
                if (note < 6) Console.WriteLine("Suficient");
                else if (note < 7) Console.WriteLine("Bé");
                else if (note < 9) Console.WriteLine("Notable");
                else if (note <= 10) Console.WriteLine("Excel.lent");
                else Console.WriteLine("Nota invàlida");
            }
            
        }
    }
}



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
            int day;

            day=Convert.ToInt32(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("Dilluns");
                    break;
                case 2:
                    Console.WriteLine("Dimarts");
                    break;
                case 3:
                    Console.WriteLine("Dimecres");
                    break;
                case 4:
                    Console.WriteLine("Dijous");
                    break;
                case 5:
                    Console.WriteLine("Divendres");
                    break;
                case 6:
                    Console.WriteLine("Dissabte");
                    break;
                case 7:
                    Console.WriteLine("Diumenge");
                    break;
                default:
                    Console.WriteLine("Ese dia no existe.");
                    break;
            }
        }
    }
}



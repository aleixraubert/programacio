/*
 * Author: Aleix Raubert
 * M03. Programació UF2
 * v1. 29/11/2023
 * Exercici 12.  Demanar per teclat el nombre de litres consumits aquest mes i calcular la factura d’aigua, tenint en compte les següents dades:
 * La quota fixa és de 6€.
 * Els primers 50 litres d’aigua són de franc.
 * Entre 50 i 200 litres, el litre costa 0,1€
 * A partir de 200 el litre costa 0,3€.
 */


using System;

namespace Testing
{
    public class Acts
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix el numero de litres consumits i calcularem la factura de l'aigua: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("EL preu serà de: " + Acts.Water_Bill(num));
        }


        public static double Water_Bill(int liters)
        {
            double prize = 6;

            if(liters <=50)
            {
                return prize;
            }
            else
            {
                if(liters <=200) 
                {
                    for (int i = 0; i < liters - 50; i++)
                    {
                        prize += 0.1;
                    }
                }
                else
                {
                    for(int i = 0; i < liters-50; i++)
                    {
                        prize += 0.1;
                    }


                    for (int i = 0; i < liters - 200; i++)
                    {
                        prize += 0.3;
                    }
                }

                return Math.Round(prize, 1);
            }
        }
    }
}
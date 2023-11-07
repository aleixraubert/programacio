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
            const string MSG_Welcome = "Introduce que quieres hacer:\nJugar [J] o Sortir [S]:";
            const string MSG_Error = "Error";
            const string MSG_Bye = "Adios!";
            const string MSG_Play = "Tienes que adivinar un número entre [1,100], tienes 10 intentos, introduce tu primer intento.";
            const string MSG_BiggerT = "El número es mas grande que ";
            const string MSG_LowerT = "El número es mas pequeño que ";
            const string MSG_Fail = "Te has quedado sin intentos has perdido. El número era: ";
            const string MSG_Win = "Enhorabuena ese es el número secreto! Has ganado!";

            int random_int = new Random().Next(0,101);
            int intent, i=0;
            bool found = false;
            char option;

            Console.WriteLine(MSG_Welcome);

            option=Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 'j':
                case 'J':
                    Console.WriteLine(MSG_Play);
                    while(i<10 && !found)
                    {
                        intent = Convert.ToInt32(Console.ReadLine());
                        if (intent == random_int) found = true;
                        else
                        {
                            if (intent > random_int) Console.WriteLine(MSG_LowerT + intent);
                            else Console.WriteLine(MSG_BiggerT + intent);
                        }
                        i++;
                    }

                    if (found) Console.WriteLine(MSG_Win);
                    else Console.WriteLine(MSG_Fail + random_int);

                    break;

                case 's':
                case 'S':
                    Console.WriteLine(MSG_Bye);
                    break;

                default:
                    Console.WriteLine(MSG_Error);
                    break;
            }
        }

    }
}



using System;
using System.Xml.Schema;

namespace prog
{
    class Arrays
    {
        static void Main()
        {
            const int SIZE = 10;
            const string MSG_Welcome = "Introdueix 20 valors [0,10]:";
            const string MSG_Ask = "Que vols, ascendent[A] o descendent[D]";
            const string MSG_Error = "Error, el valor no està entre el 0 i el 10";
            int[] numbers = new int[SIZE];

            char option;
            
            Console.WriteLine(MSG_Welcome);

            for (int j = 0; j < SIZE; j++)
            {
                numbers[j] = Convert.ToInt32(Console.ReadLine());

                while (numbers[j] < 0 || numbers[j] > 10)
                {
                    Console.WriteLine(MSG_Error);
                    numbers[j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            

            for (int i = 0; i < SIZE - 1; i++)
            {
                for (int j = i + 1; j < SIZE; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = aux;
                    }
                }
            }

            Console.WriteLine(MSG_Ask);

            option=Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("Ascendent:");

                    for (int i = 0; i < SIZE; i++) Console.Write(numbers[i] + " ");

                    Console.WriteLine();
                    break;

                case 'd':
                case 'D':

                    Console.WriteLine("Descendent:");

                    for (int i = SIZE - 1; i >= 0; i--) Console.Write(numbers[i] + " ");

                    Console.WriteLine();

                    break;
            }

        }
    }
}
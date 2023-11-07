using System;
using System.Xml.Schema;

namespace prog
{
    class Arrays
    {
        static void Main()
        {
            const int SIZE = 10;
            const string MSG_Welcome="Introdueix 20 valors:";
            int[] numbers = new int[SIZE];


            Console.WriteLine(MSG_Welcome);

            for(int j=0; j<SIZE; j++) numbers[j]=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ascendent:");

            for(int i=0; i<SIZE-1; i++)
            {
                for(int j=i+1; j<SIZE; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = aux;
                    }
                }
            }


            for (int i = 0; i < SIZE; i++) Console.Write(numbers[i] + " ");

            Console.WriteLine();

            Console.WriteLine("Descendent:");

            for (int i = SIZE-1; i >= 0; i--) Console.Write(numbers[i] + " ");

            Console.WriteLine();

        }
    }
}
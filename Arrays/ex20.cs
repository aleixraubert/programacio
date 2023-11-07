using System;
using System.Xml.Schema;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            const int ROWS = 7;
            const int COLUMNS = 3;
            const string MSG = "Intorudeix els valors d'una matriu de 7x3, els valors han de estar entre 1 i 9:";

            int[,] matInt = new int[ROWS, COLUMNS];

            Console.WriteLine(MSG);

            for(int i = 0; i < ROWS; i++)
            {
                for(int j = 0; j < COLUMNS; j++)
                {
                    matInt[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int j=0; j < COLUMNS; j++)
            {
                for(int i=0; i < ROWS; i++)
                {
                    Console.Write(matInt[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
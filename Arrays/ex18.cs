using System;
using System.Xml.Schema;

namespace prog
{
    class Arrays
    {
        static void Main()
        {
            const string MSG_Health = "vida [1-1000]: ";
            const string MSG_Power = "poder [100-500]: ";
            const string MSG_Strenght = "força [20-50]: ";
            const string MSG_Error = "El numero que estigui al interval siusplau: ";

            const int ROWS = 4;
            const int COLUMNS = 3;

            int[,] stats = new int[ROWS, COLUMNS];



            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    int num;
                    if (j == 0)
                    {
                        Console.WriteLine(MSG_Health);

                        num = Convert.ToInt32(Console.ReadLine());

                        while (num < 1 || num > 1000)
                        {
                            Console.WriteLine(MSG_Error);
                            Console.WriteLine(MSG_Health);
                            num = Convert.ToInt32(Console.ReadLine());
                        }

                        stats[i, j] = num;
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine(MSG_Power);

                        num = Convert.ToInt32(Console.ReadLine());

                        while (num < 100 || num > 500)
                        {
                            Console.WriteLine(MSG_Error);
                            Console.WriteLine(MSG_Power);
                            num = Convert.ToInt32(Console.ReadLine());
                        }

                        stats[i, j] = num;
                    }
                    else
                    {
                        Console.WriteLine(MSG_Strenght);

                        num = Convert.ToInt32(Console.ReadLine());

                        while (num < 20 || num > 50)
                        {
                            Console.WriteLine(MSG_Error);
                            Console.WriteLine(MSG_Strenght);
                            num = Convert.ToInt32(Console.ReadLine());
                        }

                        stats[i, j] = num;
                    }
                }
            }




            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Console.Write(stats[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
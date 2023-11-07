using System;
using System.Xml.Schema;

namespace prog
{
    class Arrays
    {
        static void Main()
        {
            const int SIZE = 20;
            const string MSG_Welcome="Introdueix 20 valors:";
            const string MSG_Continue = "Introdueix el número que vols buscar.";
            const string MSG_OK = "El número esta a la llista.";
            const string MSG_KO = "El número no esta a la llista.";

            int[] numbers = new int[SIZE];

            int num, i=0;

            bool found=false;

            Console.WriteLine(MSG_Welcome);

            for(int j=0; j<SIZE; j++) numbers[j]=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MSG_Continue);

            num=Convert.ToInt32(Console.ReadLine());

            while((i<numbers.Length) && (!found))
            {
                if (numbers[i] == num) found = true;
                i++;
            }


            Console.WriteLine(found ? MSG_OK : MSG_KO);
        }
    }
}
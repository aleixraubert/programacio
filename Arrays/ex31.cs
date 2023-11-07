using System;
using System.Drawing;
using System.Xml.Schema;

namespace prog
{
    class Arrays
    {
        static void Main()
        {
            const int MIN_Liters = 5;
            const int MAX_Liters = 18;
            const string MSG_Month = "Mes {0}: {1}";
            const string MSG_Final = "La mitjana és {0}\nHi ha {1} mesos amb mitjnes de pluges entre {2} i {3} litres";

            float[] arrayPluges = { 15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f };

            float med=0;
            int count = 0;

            for (int i = 0; i < arrayPluges.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayPluges.Length; j++)
                {
                    if (arrayPluges[j] > arrayPluges[i])
                    {
                        float aux = arrayPluges[j];
                        arrayPluges[j] = arrayPluges[i];
                        arrayPluges[i] = aux;
                    }
                }
            }


            for(int i = 0; i < arrayPluges.Length; i++)
            {
                Console.WriteLine(MSG_Month, i, arrayPluges[i]);
                med += arrayPluges[i];

                if (arrayPluges[i] >= MIN_Liters && arrayPluges[i] <= MAX_Liters) count++;
            }

            med /= arrayPluges.Length;

            Console.WriteLine(MSG_Final, med, count, MIN_Liters, MAX_Liters);
        }
    }
}

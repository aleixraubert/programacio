using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            int num, result=0;

            Console.WriteLine("Introduce un numero para saber el resultado de sumar sus cifras: ");

            num=Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                result += num % 10;
                num /= 10;
            }
            Console.WriteLine("La suma de las cifras es: " + result);
        }
    }
}
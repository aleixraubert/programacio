using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            int num, result, power;

            Console.WriteLine("Introduce la base y la potencia: ");

            num=Convert.ToInt32(Console.ReadLine());
            power = Convert.ToInt32(Console.ReadLine());
            result = num;
            for (int i = 0; i < power - 1; i++) result *= num;

            Console.WriteLine("El resultado es: " + result);
        }
    }
}
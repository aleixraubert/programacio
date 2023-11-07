using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            int min, max, num;

            Console.WriteLine("Introduce tres valores, el mínimo, el máximo y un número cualquiera (en ese orden): ");

            min=Convert.ToInt32(Console.ReadLine());
            max=Convert.ToInt32(Console.ReadLine());
            num=Convert.ToInt32(Console.ReadLine());

            if (num > min && num < max)
            {
                Console.WriteLine("Está dentro del rango.");
            }
            else Console.WriteLine("No está dentro del rango.");
        }
    }
}
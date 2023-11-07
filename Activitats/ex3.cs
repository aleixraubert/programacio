using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            int num, numbers=0, par_num=0, impar_num=0;
            Console.WriteLine("Introduce un numero entero: ");

            num=Convert.ToInt32(Console.ReadLine());  

            while (num > 0)
            {
                if(num%2==0) par_num++;
                else impar_num++;
                numbers++;

                num /= 10;
            }
            Console.WriteLine("Num de cifras: " + numbers + ", cifras pares: " + par_num + ", cifras impares: " +  impar_num);
        }
    }
}
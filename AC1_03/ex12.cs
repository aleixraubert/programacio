using System;

namespace prog{
    class Mult{
        static void Main(){
            int num;

            Console.WriteLine("Introduce un numero: ");

            num=Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<11; i++){
                Console.WriteLine(i + " * " + num + "=" + (num*i));
            }
        }
    }
}
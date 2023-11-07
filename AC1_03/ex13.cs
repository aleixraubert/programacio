using System;

namespace prog{
    class Enrere{
        static void Main(){
            int num;

            Console.WriteLine("Introduce un numero: ");

            num=Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<num; i++){
                Console.Write(num-i);
            }
        }
        
    }
}
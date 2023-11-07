using System;
using System.Globalization;

namespace prog{
    class Asterisc{
        static void Main(){
            int num, spaces,asterics;

            Console.WriteLine("Introduce el tamaño del rombo: ");

            num=Convert.ToInt32(Console.ReadLine());
            spaces=num;
            asterics=1;
            for(int i=0; i<num-1; i++){ //Parte arriba rombo
                for(int j=0; j<spaces-1; j++) Console.Write(" ");
                for(int k=0; k<asterics; k++) Console.Write("* ");
                Console.WriteLine();
                spaces--;
                asterics++;
            }

            for(int i=0; i<num; i++) Console.Write("* ");
            Console.WriteLine();

            spaces=2;
            asterics=num-1;
            for (int i=0; i<num-1; i++){
                for(int j=0; j<spaces-1; j++) Console.Write(" ");
                for(int k=0; k<asterics; k++) Console.Write("* ");
                spaces++;
                asterics--;
                Console.WriteLine();
            }
        }
        
    }
}
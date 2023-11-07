using System;

class conver {
    static void Main(){
        const double conver=2.2046;
        double num;
        
        Console.Write("Introduce un peso en libras para pasarlo a kilogramos: ");
        
        do{
            num=Convert.ToDouble(Console.ReadLine());
            if(num!=0){
                Console.WriteLine("El peso en kilogramos es: " + (num/conver) + " kg.");
                Console.WriteLine("Si quieres volver a convertir un número, puedes escribirlo a continuación, en caso contrario escribe '0' para salir.");
            }
            }while(num!=0);
    }
}
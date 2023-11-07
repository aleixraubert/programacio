using System;

class absolut{
    static void Main(){
        int num1;
        
        Console.Write("Introduce un número para obtener su valor absoluto: ");
        num1=Convert.ToInt32(Console.ReadLine());
        
        if(num1<0) Console.Write("El valor absoluto es: " + (num1*-1));
        else Console.Write("El valor absoluto es: " + num1);
    }
}

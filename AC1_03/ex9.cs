using System;

class sum_mod {
    static void Main(){
        int num, num2, mod, result;
        
        Console.Write("Escriu 4 números enters: ");
        
        num=Convert.ToInt32(Console.ReadLine());
        num+=Convert.ToInt32(Console.ReadLine());
        
        num2=Convert.ToInt32(Console.ReadLine());
        mod=Convert.ToInt32(Console.ReadLine());
        
        num2=num2%mod;
        
        result=num*num2;
        
        Console.WriteLine("El resultat de sumar el primer i el segon i multiplicarlo pel mòdul del tercer amb el quart és: " + result);
    }
}
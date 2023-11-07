using System;

class enters{
    static void Main() {
        const int Num_Total=20;
        int num, result=0;
        
        Console.WriteLine("Introduce "+ Num_Total + " números: ");
        
        for(int i=0; i<Num_Total; i++){
            num=Convert.ToInt32(Console.ReadLine());
            if(num%5==0) result+=num+3;
            else if(num%3==0) result+=num-2;
            else result+=num;
        }
        Console.WriteLine("El resultat es: " + result);
    }
}
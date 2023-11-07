using System;

class par_impar {
    static void Main(){
        const int Count=20;
        int total_par=0, total_impar=0, num, iteration=0;
        
        while(iteration<Count){
            num=Convert.ToInt32(Console.ReadLine());
            
            if(num%2==0) total_par++;
            else total_impar++;
            iteration++;
        }
        
        Console.WriteLine("Total parells " + total_par);
        Console.WriteLine("Total imparells " + total_impar);
    }
}

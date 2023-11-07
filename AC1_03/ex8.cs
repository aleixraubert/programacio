using System;

class invert{
    static void Main(){
        const int Total_Numbers=20;
        int num, normal=0, reversed=0, reversed_2=0, power=1, div;
        
        Console.WriteLine("Introduce " + Total_Numbers + " números: ");
        
        for(int i=0; i<Total_Numbers; i++){
            num=Convert.ToInt32(Console.ReadLine());
            
            reversed+=(num*power);
            power*=10;
            while(num<1 || num>9){
                Console.Write("El número no esta al interval [1,9], torna a introduirlo: ");
                num=Convert.ToInt32(Console.ReadLine());
            }
        }
        
        div=power/10;
        power=1;
        reversed_2=reversed;
        
        for(int i=0; i<Total_Numbers; i++){
            num=reversed/div;
            reversed=reversed%div;
            normal+=(num*power);
            power*=10;
            div/=10;
        }
        
        Console.WriteLine(normal);
        Console.WriteLine(reversed_2);
    }
}



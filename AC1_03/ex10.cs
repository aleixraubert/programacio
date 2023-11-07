using System;

class Taules{
    static void Main(){
        const int Num_Class=3;
        int num, result=0;
        
        Console.WriteLine("Escriu el número de alumnes de cada clase una per una: ");
        
        for(int i=0; i<Num_Class; i++){
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2!=0) num++;
            result+=num/2;
        }
        
        Console.WriteLine("El número de taules total necesari serà de: " + result);
    }
}


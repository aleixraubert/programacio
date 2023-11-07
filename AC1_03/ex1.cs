using System;

class natural {
    static void Main() {
        int num1, num2;
        
        Console.Write("Introduce dos número naturales: ");
        num1=Convert.ToInt32(Console.ReadLine());
        num2=Convert.ToInt32(Console.ReadLine());  
        
        while(num1<=0 || num2<=0){
            Console.Write("Uno o varios números introducidos no son naturales, vuelve a introducirlos: ");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
        }
        
        if(num1%num2==0) Console.Write(num1 + " es multiple de " + num2);
        else Console.Write(num1 + " no es multiple de " + num2);
    }
}

using System; 

namespace program{
    class Invert{
        static void Main(){
            const string MSG="Escriu dos nombres: ";
            int num1,num2,aux;

            Console.WriteLine(MSG);

            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            aux=num1;
            num1=num2;
            num2=aux;

            Console.WriteLine(num1 + " " + num2);
        }
    }
}
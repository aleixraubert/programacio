using System;
using System.Drawing;
using System.Xml.Schema;

namespace prog
{
    class Repte_8
    {
        static void Main()
        {
            const int SIZE = 11;

            const string MSG_Welcome = "Introdueix un número de 10 digits, un per un, per comprobar que sigui correcte per l'algorisme de Lhun:";
            const string MSG_OK = "Correcte.";
            const string MSG_KO = "Incorrecte.";

            int[] number = new int[SIZE];

            int sume = 0;

            Console.WriteLine(MSG_Welcome);

            for(int i = 0; i < SIZE; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < number.Length; i++)
            {
                if(i%2!=0)
                {
                    int aux = number[i]*2;
                    if(aux>=10)
                    {
                        aux = (aux / 10) + (aux % 10);
                    }
                    number[i] = aux;
                }
                sume += number[i];
            }

            Console.WriteLine(sume % 10==0 ? MSG_OK : MSG_KO);
        }
    }
}
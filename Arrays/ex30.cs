using System;
using System.Xml.Schema;

namespace prog
{
    class Program
    {
        static void Main()
        {
            string membres = Console.ReadLine();
            string[] noms = membres.Split(", ");
            string[] noms_2 = membres.Split(" i ");
            //string inicials = "";

            foreach (string nom in noms)
            {
                //Replace de Acentos
                //inicials += nom[0];
                Console.Write(nom[0]);
            }

            //Replace de Acentos
            //inicials += noms_2[1][0];
            Console.Write(noms_2[1][0]);


            //Console.WriteLine(inicials);
        }
    }
}
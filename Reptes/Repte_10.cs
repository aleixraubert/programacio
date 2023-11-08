using System;
using System.Xml.Schema;

namespace prog
{
    class Repte_10
    {
        static void Main()
        {
            const string MSG_Welcome = "Introdueix un nombre de 3 cifres com a màxim:";
            const string MSG_Error = "Malament, torna-hi: ";
            const string MSG_Abundant = "És abundant ja que la suma dels seus divisors és: {0} i es més gran que ell.";
            const string MSG_Deficient = "És deficient ja que la suma dels seus divisors és: {0} i es més petit que ell.";
            const string MSG_Perfect = "És perfecte ja que la suma dels seus divisors és: {0} i es igual que ell.";


            int sum_abundant =0;

            Console.WriteLine(MSG_Welcome);

            int num = Convert.ToInt32(Console.ReadLine());

            while (num >= 1000)
            {
                Console.WriteLine(MSG_Error);
                num = Convert.ToInt32(Console.ReadLine());
            }


            for(int i = 1; i < num; i++)
            {
                if (num % i == 0) sum_abundant += i;
            }

            if (sum_abundant > num) Console.WriteLine(MSG_Abundant, sum_abundant);
            else if (sum_abundant == num) Console.WriteLine(MSG_Perfect, sum_abundant);
            else Console.WriteLine(MSG_Deficient, sum_abundant);
        }
    }
}
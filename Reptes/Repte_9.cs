using System;
using System.Xml.Schema;

namespace prog
{
    class Repte_9
    {
        static void Main()
        {
            const string MSG_Welcome = "Introdueix la targeta: ";
            const string MSG_OK = "La targeta és vàlida.";
            const string MSG_KO = "La targeta no és vàlida.";
            bool valid = false;

            Console.WriteLine(MSG_Welcome);

            string card=Console.ReadLine();

            string card_no_spaces = card.Replace(" ", "");

            Console.WriteLine(card_no_spaces);

            if (card_no_spaces.Length != 16)
            {
                Console.WriteLine(card_no_spaces.Length);
                valid = false;
            }
            else if ((card_no_spaces[0] == '4') || (card_no_spaces[0] == '5'))
            {
                valid = true;
            }

            Console.WriteLine(valid ? MSG_OK : MSG_KO);
        }
    }
}
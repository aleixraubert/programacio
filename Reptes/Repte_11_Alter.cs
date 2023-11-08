using System;
using System.Xml.Schema;

namespace prog
{
    class Repte_10_Alter
    {
        static void Main()
        {
            const string MSG_Welcome = "Introdueix la hora en format hh:mm.";
            const string MSG_Error = "La hora introduida no és correcte.";

            const string MSG_Clock = "Son les {0} del {1}.";
            const string MSG_Quart = "És un quart de {0} del {1}.";
            const string MSG_Clock_One = "És l'{0} del {1}.";
            const string MSG_Quart_One = "És un quart d'{0} del {1}.";
            const string MSG_Half = "Són dos quarts de {0} del {1}.";
            const string MSG_Half_One = "Són dos quarts d'{0} del {1}.";
            const string MSG_Three_Quart = "Són tres quarts de {0} del {1}.";
            const string MSG_Three_Quart_One = "Són tres quarts d'{0} del {1}.";

            const string ONE = "una";
            const string TWO = "dues";
            const string THREE = "tres";
            const string FOUR = "quatre";
            const string FIVE = "cinc";
            const string SIX = "sis";
            const string SEVEN = "set";
            const string EIGHT = "vuit";
            const string NINE = "nou";
            const string TEN = "deu";
            const string ELEVEN = "onze";
            const string TWELVE = "dotze";

            const string Morning = "matí";
            const string Night = "vespre";
            const string Midday = "mitgdia";



            Console.WriteLine(MSG_Welcome);

            string hour=Console.ReadLine();

            string[] hour_split = hour.Split(":");

            int minutes = Int32.Parse(hour_split[1]);

            switch (hour_split[0])
            {
                case "00":
                case "0":
                    
                    if(minutes==0 || (minutes<=7 || minutes >=53))
                    {
                        Console.WriteLine(MSG_Clock, TWELVE, Morning);
                    }
                    else if(minutes>7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart_One, ONE, Morning);
                    }
                    else if(minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half_One, ONE, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart_One, ONE, Morning);
                    }

                    break;

                case "01":
                case "1":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock_One, ONE, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, TWO, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, TWO, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, TWO, Morning);
                    }

                    break;

                case "02":
                case "2":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, TWO, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, THREE, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, THREE, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, THREE, Morning);
                    }

                    break;

                case "03":
                case "3":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, THREE, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, FOUR, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, FOUR, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, FOUR, Morning);
                    }

                    break;

                case "04":
                case "4":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, FOUR, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, FIVE, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, FIVE, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, FIVE, Morning);
                    }

                    break;

                case "05":
                case "5":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, FIVE, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, SIX, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, SIX, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, SIX, Morning);
                    }

                    break;

                case "06":
                case "6":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, SIX, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, SEVEN, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, SEVEN, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, SEVEN, Morning);
                    }

                    break;

                case "07":
                case "7":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, SEVEN, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, EIGHT, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, EIGHT, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, EIGHT, Morning);
                    }

                    break;

                case "08":
                case "8":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, EIGHT, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, NINE, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, NINE, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, NINE, Morning);
                    }

                    break;

                case "09":
                case "9":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, NINE, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, TEN, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, TEN, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, TEN, Morning);
                    }

                    break;

                case "10":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, TEN, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, ELEVEN, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, ELEVEN, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, ELEVEN, Morning);
                    }

                    break;

                case "11":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, ELEVEN, Morning);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, TWELVE, Morning);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, TWELVE, Morning);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, TWELVE, Morning);
                    }

                    break;

                case "12":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, TWELVE, Midday);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart_One, ONE, Midday);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half_One, ONE, Midday);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart_One, ONE, Midday);
                    }

                    break;

                case "13":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock_One, ONE, Midday);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, TWO, Midday);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, TWO, Midday);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, TWO, Midday);
                    }

                    break;

                case "14":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, TWO, Midday);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, THREE, Midday);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, THREE, Midday);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, THREE, Midday);
                    }
                    break;

                case "15":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, THREE, Midday);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, FOUR, Midday);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, FOUR, Midday);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, FOUR, Midday);
                    }
                    break;

                case "16":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, FOUR, Midday);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, FIVE, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, FIVE, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, FIVE, Night);
                    }
                    break;

                case "17":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, FIVE, Night);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, SIX, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, SIX, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, SIX, Night);
                    }
                    break;

                case "18":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, SIX, Night);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, SEVEN, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, SEVEN, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, SEVEN, Night);
                    }
                    break;

                case "19":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, SEVEN, Night);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, EIGHT, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, EIGHT, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, EIGHT, Night);
                    }
                    break;

                case "20":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, EIGHT, Night);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, NINE, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, NINE, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, NINE, Night);
                    }
                    break;

                case "21":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, NINE, Night);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, TEN, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, TEN, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, TEN, Night);
                    }
                    break;

                case "22":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, TEN, Night);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, ELEVEN, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, ELEVEN, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, ELEVEN, Night);
                    }
                    break;

                case "23":

                    if (minutes == 0 || (minutes <= 7 || minutes >= 53))
                    {
                        Console.WriteLine(MSG_Clock, ELEVEN, Night);
                    }
                    else if (minutes > 7 && minutes <= 23)
                    {
                        Console.WriteLine(MSG_Quart, ELEVEN, Night);
                    }
                    else if (minutes > 23 && minutes <= 37)
                    {
                        Console.WriteLine(MSG_Half, ELEVEN, Night);
                    }
                    else
                    {
                        Console.WriteLine(MSG_Three_Quart, ELEVEN, Night);
                    }
                    break;

                default:
                    Console.WriteLine(MSG_Error);

                    break;
            }
        }
    }
}
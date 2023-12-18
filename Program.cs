/* Implementa un programa que retorni l'àrea per consola de les següents figures geomètriques:
quadrat
rectangle
cercle
pentàgon
El programa haurà de demanar per teclat els valors necessaris.
*/


using System;

namespace Programacio
{
    public class Ex23
    {
        public static void Main()
        {
            const string Msg_Area = "El area es: {0}";
            const string Msg_Ask = "Que figura quieres calcular? (1:Cuadrado, 2:Rectangulo, 3:Circulo, 4:Pentagono): ";

            int option;

            Console.Write(Msg_Ask);

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int baseSquare, heightSquare;
                    Console.Write("Introduce la base del cuadrado: ");
                    baseSquare = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Introduce la altura del cuadrado: ");
                    heightSquare = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Msg_Area,Area(baseSquare,heightSquare));
                    break;
                case 2:
                    int baseRectangle, heightRectangle;
                    Console.Write("Introduce la base del rectangulo: ");
                    baseRectangle = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Introduce la altura del rectangulo: ");
                    heightRectangle = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Msg_Area,Area(baseRectangle,heightRectangle));
                    break;
                case 3:
                    double radius;
                    Console.Write("Introduce el radio del circulo: ");
                    radius = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Msg_Area,Area(radius));
                    break;
                case 4:
                    int side, apothem;
                    Console.Write("Introduce el lado del pentagono: ");
                    side = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Introduce el apotema del pentagono: ");
                    apothem = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Msg_Area,Area(side, apothem, 5));
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static double Area(int bases, int height)
        {
            return bases * height;
        }

        public static double Area(int side, int apothem, int nSides)
        {
            return (nSides * side * apothem) / 2;
        }
    }
}
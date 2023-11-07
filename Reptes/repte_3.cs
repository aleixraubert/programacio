using System;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            int min_floor, max_floor, current_floor, num, floors_changes=0, floors_moved=0;
            bool wrong_floor = false;
            string input;

            min_floor=Convert.ToInt32(Console.ReadLine());
            max_floor=Convert.ToInt32(Console.ReadLine());
            current_floor = Convert.ToInt32(Console.ReadLine());

            input=Console.ReadLine();

            while (input != "X")
            {
                num = Int32.Parse(input);

                if (num >= min_floor && num <= max_floor)
                {
                    if (num != current_floor) {
                        if (num > current_floor)
                        {
                            floors_moved += num - current_floor;
                            current_floor = num;
                            floors_changes++;
                        }
                        else
                        {
                            floors_moved += current_floor - num;
                            current_floor = num;
                            floors_changes++;
                        }
                    }
                }
                else wrong_floor = true;

                input = Console.ReadLine();
            }

            Console.Write(floors_changes + " " + floors_moved + " " + current_floor);
            if (wrong_floor) Console.Write(" E");
        }
    }
}
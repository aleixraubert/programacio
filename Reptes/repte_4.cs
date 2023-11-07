using System;

namespace prog
{
    class Repte_2
    {
        static void Main()
        {
            int cases, rows, left, right, velocity=300, right_c_mass=0, left_c_mass=0, first_car_mass=0, second_car_mass=0, mid=0, diff, simetric_diff;
            bool impar = false;

            cases=Convert.ToInt32 (Console.ReadLine());

            for(int i=0; i< cases; i++)
            {
                right_c_mass = left_c_mass = first_car_mass = second_car_mass = diff = simetric_diff = 0;
                rows= Convert.ToInt32 (Console.ReadLine());

                if (rows % 2 != 0)
                {
                    mid = rows / 2 + 1;
                    impar = true;
                }
                else mid = rows / 2;

                for (int j=1; j<= rows; j++)
                {
                    left= Convert.ToInt32 (Console.ReadLine());
                    right = Convert.ToInt32(Console.ReadLine());

                    right_c_mass += right;
                    left_c_mass += left;

                    if (impar)
                    {
                        if (j < mid)
                        {
                            first_car_mass += left + right;
                        }
                        else if (j > mid)
                        {
                            second_car_mass += left + right;
                        }
                    }
                    else
                    {
                        if (j <= mid)
                        {
                            first_car_mass += left + right;
                        }
                        else if (j > mid)
                        {
                            second_car_mass += left + right;
                        }
                    }
                }

                if (right_c_mass > left_c_mass) diff = right_c_mass - left_c_mass;
                else diff = left_c_mass - right_c_mass;

                while (diff >= 50)
                {
                    velocity -= 2;
                    diff -= 50;
                }

                if (first_car_mass > second_car_mass) simetric_diff = first_car_mass - second_car_mass;
                else simetric_diff = second_car_mass - first_car_mass;

                while (simetric_diff >= 100)
                {
                    velocity -= 5;
                    simetric_diff -= 100;
                }

                
                Console.WriteLine(velocity);
            }
        }
    }
}
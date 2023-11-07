using System;

namespace prog
{
    class Twitch
    {
        static void Main()
        {
            int hp_jungle, rammus_attack, twitch_attack, inputs, rounds;

            inputs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < inputs; i++)
            {
                rounds = 0;
                hp_jungle = Convert.ToInt32(Console.ReadLine());
                rammus_attack = Convert.ToInt32(Console.ReadLine());
                twitch_attack = Convert.ToInt32(Console.ReadLine());

                while (hp_jungle > 0)
                {
                    hp_jungle -= rammus_attack;
                    if (hp_jungle > 0)
                    {
                        hp_jungle -= twitch_attack;
                        if (hp_jungle <= 0) Console.Write("TWITCH");
                    }
                    else
                    {
                        Console.Write("RAMMUS");
                    }
                    rounds++;
                }
                Console.WriteLine(" " + rounds);
            }
        }
    }
}
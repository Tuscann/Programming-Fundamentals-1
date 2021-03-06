﻿using System;
class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        long max = long.MinValue;

        for (int i = 0; i < count; i++)
        {
            decimal currentNUmber = decimal.Parse(Console.ReadLine());

            if (type == "sbyte" && -128 <= currentNUmber && currentNUmber <= 127)
            {
                if (currentNUmber > max)
                {
                    max = (sbyte)currentNUmber;
                }
            }
            else if (type == "int" && int.MinValue <= currentNUmber && currentNUmber <= int.MaxValue)
            {
                if (currentNUmber > max)
                {
                    max = (int)currentNUmber;
                }
            }
            else if (type == "long" && long.MinValue <= currentNUmber && currentNUmber <= long.MaxValue)
            {
                if (currentNUmber > max)
                {
                    max = (long)currentNUmber;
                }
            }
        }
        
        if (max > 1)
        {
            double yearsInPrison = Math.Ceiling(max / 127d);

            if (yearsInPrison > 1)
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", max, yearsInPrison);
            }
            else
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to 1 year", max);
            }
        }
        else
        {
            double yearsInPrison = Math.Ceiling(max / -128d);

            if (yearsInPrison > 1)
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", max, yearsInPrison);
            }
            else
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to 1 year", max);
            }
        }
    }
}
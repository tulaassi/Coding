﻿using System;

namespace Task_C_Sharp
{
    class _53_Stars
    {
        static void Main()
        {

            int length = 4;
            int space, star;
            for (int i = 1; i <= length; i++)
            {
                for (space = 1; space <= i - 1; space++)
                    Console.Write(" ");
                for (star = 1; star <= 6; star++)
                    Console.Write("*");
             Console.WriteLine();

            }
        }
    }
}


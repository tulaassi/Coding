﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Repeated_Char
    {
        public static void Main()
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();

            char rptchar = '\0';
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (input.IndexOf(currentChar) != input.LastIndexOf(currentChar))
                {
                    rptchar = currentChar;
                    break;
                }
            }
            if (rptchar == '\0')
            {
                Console.WriteLine("No repeat character is found");
            }
            else
            {
                Console.WriteLine("First repeated character is  " + rptchar);
            }

        }
    }
}

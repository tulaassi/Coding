﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_basic_programs
{
    class Removing_Chars
    {
        public static void Main()
        {
            Console.WriteLine("Enter two strings");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string result = "";
            foreach(char c in str1)
            {
                if (!str2.Contains(c))
                {
                    result += c;
                }
            }
            Console.WriteLine(result);
        }
    }
}
                                                                 
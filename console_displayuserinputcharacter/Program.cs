﻿using System;

namespace console_displayuserinputcharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name:");
            string fname = Console.ReadLine();
            Console.Write("Enter your last name:");
            string lname = Console.ReadLine();
            Console.WriteLine("The name is {0} {1}",fname,lname);
        }
    }
}

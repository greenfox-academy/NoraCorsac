﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
            Console.WriteLine("Please enter a number: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number <= 0)
            {
                Console.WriteLine("Not enough!");
            }
            else if(number == 1)
            {
                Console.WriteLine("One");
            }
            else if(number == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
        }
    }
}

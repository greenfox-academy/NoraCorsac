﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Models
{
    public class Greet
    {
        public string Name { get; set; }

        public Greet(string name)
        {
            Name = name;
        }

        public Greet()
        {
        }

        public string SayHello()
        {
            return "Hello, " + Name + "! Have a nice day!";
        }
    }
}

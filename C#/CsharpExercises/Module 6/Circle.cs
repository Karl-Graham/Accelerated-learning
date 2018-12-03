﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6
{
    class Circles
    {
        string name;
        double radius;

        public Circle(string n, double r)
        {
            
            name = n;
            radius = r;

        }

        public void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name {name}!");
        }

        public void WriteArea()
        {
            double area = radius * radius * Math.PI;
            Console.WriteLine($"My name is {name}. I have a radius of {radius} and an area of {area:.##}");
        }
    }
}

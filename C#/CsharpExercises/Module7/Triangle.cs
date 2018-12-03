using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Triangle : Shape
    {
        public decimal Height { get; set; }
        public decimal Base { get; set; }
        public string tString => $"I'm a triangle with base={Base} and height={Height}";
    }
}

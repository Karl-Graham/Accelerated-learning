using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Circle : Shape
    {
        public decimal Radius { get; set; }
        public string tString => $"I'm a circle with radius={Radius}";
    }
}

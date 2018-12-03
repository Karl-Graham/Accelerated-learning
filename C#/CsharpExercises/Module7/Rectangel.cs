using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Rectangel : Shape
    {
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public string tString => $"I'm a rectangel with base={Length} and height={Height}";

    }
}

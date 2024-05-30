using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeight
{
    public class Candy
    {
        public string Colour { get; private set; }

        public string Shape { get; private set; }

        public Candy(string color, string shape)
        {
            Colour = color;
            Shape = shape;
        }
    }
}

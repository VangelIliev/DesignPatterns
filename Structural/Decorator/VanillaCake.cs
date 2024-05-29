using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class VanillaCake : ICake
    {
        private IList<string> layers = new List<string>();
        public void AddLayer(string layer)
        {
            this.layers.Add(layer);
        }

        public void PrintLayers()
        {
            foreach (var layer in layers) { Console.WriteLine($"Layer:{layer}"); Console.WriteLine("------"); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeight
{
    public class CandyFactory
    {
        private Dictionary<string, Candy> _candies = new();
        // the pattern is about saving memory
        public Candy GetCandy(string color, string shape)
        {
            //create a key from the passed strings

            string key = $"{color}_{shape}";

            //add a candy instance for the key, if don't exists in the dictionary
            if(!_candies.ContainsKey(key))
            {
                _candies[key] = new Candy(color, shape);
            }
            //Otherwise return  the cached candy
            return _candies[key];
        }
    }
}

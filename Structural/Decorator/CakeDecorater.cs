using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class CakeDecorater
    {
        private readonly ICake _cake;
        public CakeDecorater(ICake cake)
        {
            _cake = cake;
        }
        public void Decorate(string message)
        {
            this._cake.AddLayer($"Message for the cake: {message}");
        }
    }
}

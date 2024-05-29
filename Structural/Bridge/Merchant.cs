using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Merchant : Character
    {
        public Merchant(IInteractionBehaviour interactionBehaviour) : base(interactionBehaviour) { }

        public override void Move()
        {
            Console.WriteLine("Merchant is moving");
        }
    }
}

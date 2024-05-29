using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Archer : Character
    {
        public Archer(IInteractionBehaviour behaviour) : base(behaviour) { }
        public override void Move()
        {
            Console.WriteLine("Archer is moving");
        }
    }
}

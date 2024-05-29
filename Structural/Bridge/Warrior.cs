using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Warrior : Character
    {
        public Warrior(IInteractionBehaviour behaviour) : base(behaviour)
        {

        }
        public override void Move()
        {
            Console.WriteLine("Warrior is moving");
        }
    }
}

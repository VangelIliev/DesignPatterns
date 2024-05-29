using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class AttackBehaviour : IInteractionBehaviour
    {
        public void Interact()
        {
            Console.WriteLine("I am attacking");
        }
    }
}

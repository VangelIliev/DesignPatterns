﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class TradeBehaviour : IInteractionBehaviour
    {
        public void Interact()
        {
            Console.WriteLine("I am trading");
        }
    }
}

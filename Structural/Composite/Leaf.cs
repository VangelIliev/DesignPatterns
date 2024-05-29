﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    internal class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public class Ticket
    {
        public Severity Severity { get; set; }
        // Other ticket properties
    }

    public enum Severity
    {
        Low,
        Medium,
        High
    }
}

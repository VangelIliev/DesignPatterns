using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public class Level1SupportHandler : SupportHandlerBase
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.Low;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 1 Support handles the ticket.");
            // Handle the ticket at Level 1 Support
        }

    }
}

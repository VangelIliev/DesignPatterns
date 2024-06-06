using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public abstract class SupportHandlerBase
    {
        private ISupportHandler _nextHandler;

    public void SetNextHandler(ISupportHandler handler)
    {
        _nextHandler = handler;
        }

    public virtual void HandleTicket(Ticket ticket)
    {
        // If this handler can handle the ticket, do the handling
        if (CanHandleTicket(ticket))
        {
            Handle(ticket);
        }
        // If there is a next handler, pass the ticket to it
        else if (_nextHandler != null)
        {
            _nextHandler.HandleTicket(ticket);
        }
        // No handler in the chain can handle the ticket
        else
        {
            Console.WriteLine("Ticket cannot be handled.");
            }
        }

    protected abstract bool CanHandleTicket(Ticket ticket);
    protected abstract void Handle(Ticket ticket);
    }
}

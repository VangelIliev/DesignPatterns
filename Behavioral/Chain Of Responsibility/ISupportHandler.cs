using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public interface ISupportHandler
    {
        void SetNextHandler(ISupportHandler handler);
        void HandleTicket(Ticket ticket);
    }
}

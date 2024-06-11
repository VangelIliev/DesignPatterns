using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IUser
    {
        int ChatId { get; }

        void SendMessage(string message);

        void RecieveMessage(string message);
    }
}

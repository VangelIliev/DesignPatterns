using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ChatMediator : IMediator
    {
        private readonly Dictionary<int, IUser> _users;

        public ChatMediator()
        {
             _users = new Dictionary<int, IUser>();
        }

        public void RegisterChatUser(IUser user)
        {
            if (!_users.ContainsKey(user.ChatId))
            {
                _users.Add(user.ChatId, user);
            }
        }

        public void SendMessage(string message, int chatId)
        {
            foreach (var user in _users.Where(x=>x.Key != chatId))
            {
                user.Value.RecieveMessage(message);
            }
        }
    }
}

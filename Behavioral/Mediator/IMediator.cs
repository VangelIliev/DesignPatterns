﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        public void SendMessage(string message, int chatId);

        public void RegisterChatUser(IUser user);
    }
}

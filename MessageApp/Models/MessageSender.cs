using System;
using System.Collections.Generic;
using System.Text;

namespace MessageApp.Models
{
    abstract class MessageSender
    {
        public abstract string SendMessage(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MessageApp.Models
{
    internal class SmsSender : MessageSender
    {
        public override string SendMessage(string message)
        {
            return $"sms {message}";
        }
    }
}

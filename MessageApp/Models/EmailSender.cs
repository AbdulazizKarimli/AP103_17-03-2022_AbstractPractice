using System;
using System.Collections.Generic;
using System.Text;

namespace MessageApp.Models
{
    internal class EmailSender : MessageSender
    {
        public override string SendMessage(string message)
        {
            return $"email: {message}";
        }
    }
}

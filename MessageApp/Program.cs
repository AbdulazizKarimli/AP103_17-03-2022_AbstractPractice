using MessageApp.Models;
using System;

namespace MessageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. Sms");
            Console.WriteLine("0. Quit");

            string choice = Console.ReadLine();

            string message;
            switch (choice)
            {
                case "1":
                    message = Console.ReadLine();

                    EmailSender emailSender = new EmailSender();
                    Console.WriteLine(emailSender.SendMessage(message));
                    break;
                case "2":
                    message = Console.ReadLine();

                    SmsSender smsSender = new SmsSender();
                    Console.WriteLine(smsSender.SendMessage(message));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("not found");
                    break;
            }
        }
    }
}

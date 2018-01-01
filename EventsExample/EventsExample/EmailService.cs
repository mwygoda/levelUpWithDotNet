using System;
using System.Threading;

namespace EventsExample
{
    public class EmailService
    {
        public void OnPasswordChanged(object source, PasswordEventArgs args)
        {
            Console.WriteLine("Sending an email... For account called: " + args.Credentials.Username);
            Thread.Sleep(1000);
        }
    }
}

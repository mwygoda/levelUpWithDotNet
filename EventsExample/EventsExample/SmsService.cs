using System;
using System.Threading;

namespace EventsExample
{
    public class SmsService
    {
        public void OnPasswordChanged(object source, PasswordEventArgs args)
        {
            Console.WriteLine("Sending text message on users cellphone.. For account named: " +
                              args.Credentials.Username);
            Thread.Sleep(1000);
        }
    }
}

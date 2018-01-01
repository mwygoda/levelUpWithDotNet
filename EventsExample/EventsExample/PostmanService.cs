using System;
using System.Threading;

namespace EventsExample
{
    public class PostmanService
    {
        public void OnPasswordChanged(object source, PasswordEventArgs args)
        {
            Console.WriteLine("Ordering postman to deliver parcel with confirmation.. For account named: " +
                              args.Credentials.Username);
            Thread.Sleep(1000);
        }
    }
}

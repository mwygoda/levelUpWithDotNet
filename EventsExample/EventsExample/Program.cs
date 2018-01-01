using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new Credentials()
            {
                Username = "Mateuszek",
                Password = "Qwerty@123"
            };
            var changingPasswordProcessor = new ChangingPasswordLogic();
            var mailService = new EmailService();
            var smsService = new SmsService();
            var postmanService = new PostmanService();

            changingPasswordProcessor.PasswordChanged += mailService.OnPasswordChanged;
            changingPasswordProcessor.PasswordChanged += smsService.OnPasswordChanged;
            changingPasswordProcessor.PasswordChanged += postmanService.OnPasswordChanged;

            changingPasswordProcessor.ProcessPasswordChange(credentials);

            Console.ReadLine();
        }

        public class EmailService
        {
            public void OnPasswordChanged(object source, EventArgs args)
            {
                Console.WriteLine("Sending an email...");
                Thread.Sleep(1000);
            }
        }

        public class SmsService
        {
            public void OnPasswordChanged(object source, EventArgs args)
            {
                Console.WriteLine("Sending text message on users cellphone..");
                Thread.Sleep(1000);
            }
        }

        public class PostmanService
        {
            public void OnPasswordChanged(object source, EventArgs args)
            {
                Console.WriteLine("Ordering postman to deliver parcel with confirmation..");
                Thread.Sleep(1000);
            }
        }
    }
}

using System;

namespace EventsExample
{
    partial class Program
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
    }
}

using System;
using System.Threading;

namespace EventsExample
{
    public class PasswordEventArgs : EventArgs
    {
        public Credentials Credentials { get; set; }
    }

    public class ChangingPasswordLogic
    {
        public delegate void ChangingPasswordEventHandler(object source, PasswordEventArgs args);

        public event ChangingPasswordEventHandler PasswordChanged;

        public void ProcessPasswordChange(Credentials credentials)
        {
            Console.WriteLine("Processing and verifing new credentials...");
            Thread.Sleep(5000);

            OnPasswordChanged(credentials);
        }

        protected virtual void OnPasswordChanged(Credentials credentials)
        {
            if (PasswordChanged != null)
                PasswordChanged(this, new PasswordEventArgs {Credentials = credentials});
        }
    }
}
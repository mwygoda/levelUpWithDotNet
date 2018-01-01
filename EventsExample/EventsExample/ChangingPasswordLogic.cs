using System;
using System.Threading;

namespace EventsExample
{
    public class ChangingPasswordLogic
    {
        public delegate void ChangingPasswordEventHandler(object source, EventArgs args);
        public event ChangingPasswordEventHandler PasswordChanged;

        public void ProcessPasswordChange(Credentials credentials)
        {
            Console.WriteLine("Processing and verifing new credentials...");
            Thread.Sleep(5000);

            OnPasswordChanged();
        }

        protected virtual void OnPasswordChanged()
        {
            if (PasswordChanged != null)
            {
                PasswordChanged(this, EventArgs.Empty);
            }
        }
    }
}

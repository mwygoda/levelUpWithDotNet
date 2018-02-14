using DesignPatterns.CommandProject1.Command;

namespace DesignPatterns.CommandProject1.Receiver
{
    public class Pizzeria
    {
        private ICommand _command;

        public ICommand Command
        {
            set { _command = value; }
        }

        public void StartCooking()
        {
            _command.Execute();
        }
    }
}

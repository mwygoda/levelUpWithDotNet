using DesignPatterns.CommandProject1.Command;
using DesignPatterns.CommandProject1.Invoker;

namespace DesignPatterns.CommandProject1.ConcreteCommand
{
    public class MakePasta : ICommand
    {
        private readonly Pasta _pasta;

        public MakePasta(Pasta pasta)
        {
            _pasta = pasta;
        }

        public void Execute()
        {
            _pasta.Bake();
        }
    }
}

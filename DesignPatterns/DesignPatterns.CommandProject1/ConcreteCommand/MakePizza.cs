using DesignPatterns.CommandProject1.Command;
using DesignPatterns.CommandProject1.Invoker;

namespace DesignPatterns.CommandProject1.ConcreteCommand
{
    public class MakePizza : ICommand
    {
        private readonly Pizza _pizza;

        public MakePizza(Pizza pizza)
        {
            _pizza = pizza;
        }

        public void Execute()
        {
            _pizza.Make();
        }
    }
}

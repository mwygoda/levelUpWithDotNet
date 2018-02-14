using System;
using DesignPatterns.CommandProject1.ConcreteCommand;
using DesignPatterns.CommandProject1.Invoker;
using DesignPatterns.CommandProject1.Receiver;

namespace DesignPatterns.CommandProject1
{
    public class Client
    {
        public void StartCommandExample()
        {
            var pizzeria = new Pizzeria();
            var pizza = new Pizza();
            var makePizzaCommand = new MakePizza(pizza);
            pizzeria.Command = makePizzaCommand;
            pizzeria.StartCooking();

            var pasta = new Pasta(PastaType.Lasagna);
            var makePastaCommand = new MakePasta(pasta);
            pizzeria.Command = makePastaCommand;
            pizzeria.StartCooking();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandProject1;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ------------------------------- Abstract Factory Example -------------------------\\\\
            var abstractFactory = new AbstractFactoryClient();
            abstractFactory.StartApp();

            //// ------------------------------- Strategy Example -------------------------\\\\
            var strategyExample = new StrategyClient();
            strategyExample.StartApp();

            //// ------------------------------- Command Example -------------------------\\\\
            var commandExample = new Client();
            commandExample.StartCommandExample();


            //// ------------------------------- Singleton Example -------------------------\\\\
            var firstSingleton = MySingleton.GetInstance;
            firstSingleton.SayHello("Hello from First Singleton!");

            var secondSingleton = MySingleton.GetInstance;
            secondSingleton.SayHello("Hello from Second(??) Singleton");

            Console.ReadLine();

        }
    }
}

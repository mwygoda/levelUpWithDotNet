using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CommandProject1;
using DesignPatterns.Factory;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstractFactory = new AbstractFactoryClient();
            abstractFactory.StartApp();

            var strategyExample = new StrategyClient();
            strategyExample.StartApp();

            var commandExample = new Client();
            commandExample.StartCommandExample();
        }
    }
}

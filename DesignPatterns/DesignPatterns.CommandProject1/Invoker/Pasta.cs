using System;
using System.Collections.Generic;
using System.Linq;
namespace DesignPatterns.CommandProject1.Invoker
{
    public class Pasta
    {
        public PastaType TypeOfPasta { get; set; }

        public Pasta(PastaType pastaType)
        {
            TypeOfPasta = pastaType;
        }

        public void Bake()
        {
            Console.WriteLine("I'm making {0} pasta for you! :)", TypeOfPasta);
        }
    }

    public enum PastaType
    {
        Spaghetti,
        Lasagna
    }
}

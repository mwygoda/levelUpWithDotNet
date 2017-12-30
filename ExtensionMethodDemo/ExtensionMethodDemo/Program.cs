using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var initString = "whatever";
            var result = initString.ChangeFirstLetterToSeven();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DisposeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = {"This is LoremIpsumLine1", "This is LoremIpsumLine2", "This is LoremIpsumLine3", "This is LoremIpsumLine4" };
            const string path = @"name.txt";

            var writer = new MyStreamWriter(path);
            try
            {
                foreach (var line in lines)
                {
                    writer.WriteTextToFile(line);
                }
                writer.Dispose();

                var fileContent = ReadResult(path);
                Console.WriteLine(fileContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }

        public static string ReadResult(string path)
        {
            using (var reader = new StreamReader(path))
            {
                var result = reader.ReadToEnd();

                return result;
            }
        }
    }
}

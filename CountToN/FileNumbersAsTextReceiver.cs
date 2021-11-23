using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToN
{
    class FileNumbersAsTextReceiver : INumbersAsTextRetriever
    {
        public string Get()
        {
            return File.ReadAllText("numbers.txt");
        }
    }

    class ConsoleNumbersAsTextReceiver : INumbersAsTextRetriever
    {
        public string Get()
        {
            Console.Write("Skriv tall med komma i mellom: ");
            return Console.ReadLine();
        }
    }
}

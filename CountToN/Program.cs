using System;

namespace CountToN
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new SimpleCountToN(5);
            while (!counter.Count())
            {
                Console.ReadKey();
            }
        }
    }
}

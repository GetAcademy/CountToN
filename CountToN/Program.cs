using System;
using System.Net.Mime;

namespace CountToN
{
    class Program : ICountedHandler
    {
        public static void Main(string[] args)
        {
            //var counter = new SimpleCountToN(5);
            //while (!counter.Count())
            //{
            //    Console.ReadKey();
            //}

            var program = new Program();
            program.Run();

        }

        private void Run()
        {
            var counter = new CallbackCountToN(this, 5);
            while (true)
            {
                counter.Count();
                Console.ReadKey();
            }
        }

        public void HandleCounted()
        {
            Environment.Exit(0);
        }
    }
}

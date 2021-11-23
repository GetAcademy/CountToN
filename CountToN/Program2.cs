using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToN
{
    class Program2 : ICountedHandler
    {
        void Run()
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
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToN
{
    public class Magic
    {
        public void Method(int number)
        {
            Console.WriteLine("Hei");
            if (number < 10)
            {
                Console.WriteLine("Hadet");
            }
            else
            {
                int i = 10 / number;
                Console.WriteLine("skedg");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("partall");
            }
            else
            {
                Console.WriteLine("oddetall");
            }

            Console.WriteLine("Hallo");
        }
    }
}

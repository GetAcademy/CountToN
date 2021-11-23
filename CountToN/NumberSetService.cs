using System;
using System.Collections.Generic;
using System.IO;

namespace CountToN
{
    class NumberSetService
    {
        private INumbersAsTextRetriever _numbersAsTextRetriever;

        public NumberSetService(INumbersAsTextRetriever numbersAsTextRetriever)
        {
            _numbersAsTextRetriever = numbersAsTextRetriever;
        }

        public HashSet<int> GetAll()
        {
            //var text = File.ReadAllText("numbers.txt");
            var text = _numbersAsTextRetriever.Get();
            var numbersStrings = text.Split(',');
            var set = new HashSet<int>();
            foreach (var numbersString in numbersStrings)
            {
                set.Add(Convert.ToInt32(numbersString));
            }
            return set;
        }
    }
}

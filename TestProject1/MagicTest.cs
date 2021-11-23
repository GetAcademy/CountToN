using CountToN;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var magic = new Magic();
            magic.Method(5);
        }

        [Test]
        public void Test2()
        {
            var magic = new Magic();
            magic.Method(14);
        }
    }
}
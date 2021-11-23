namespace CountToN
{
    class SimpleCountToN
    {
        private readonly int _n;
        private int _count;

        public SimpleCountToN(int n)
        {
            _n = n;
        }

        public bool Count()
        {
            _count++;
            return _count == _n;
        }
    }
}

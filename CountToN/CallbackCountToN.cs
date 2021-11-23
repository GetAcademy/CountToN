namespace CountToN
{
    class CallbackCountToN
    {
        private readonly int _n;
        private int _count;
        private ICountedHandler _program;

        public CallbackCountToN(
            ICountedHandler program, int n)
        {
            _program = program;
            _n = n;
        }

        public void Count()
        {
            _count++;
            if (_count == _n)
            {
                _program.HandleCounted();
            }
        }
    }
}

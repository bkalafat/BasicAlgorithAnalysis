using DataStructures;

namespace Problems
{
    public class Median
    {
        private readonly Heap _lowers;
        private readonly Heap _highers;

        public Median()
        {
            _lowers = new Heap(false);
            _highers = new Heap();
        }

        public void AddNumber(int number)
        {
            var smallerSizeHeap = GetSmallerSizeHeap();
            smallerSizeHeap.AddNumber(number);
            BalanceHeaps();
        }

        private void BalanceHeaps()
        {
            while (_lowers.Arr.Count > _highers.Arr.Count + 1 || _lowers.Peek() > _highers.Peek())
            {
                var lowersMax = _lowers.Poll();
                _highers.AddNumber(lowersMax);
            }
            while (_lowers.Arr.Count < _highers.Arr.Count - 1)
            {
                var highersMin = _highers.Poll();
                _lowers.AddNumber(highersMin);
            }
        }

        private Heap GetSmallerSizeHeap()
        {
            return _lowers.Arr.Count > _highers.Arr.Count ? _highers : _lowers;
        }

        public double GetMedian()
        {
            if (_lowers.Arr.Count > _highers.Arr.Count)
            {
                return _lowers.Poll();
            }

            if (_lowers.Arr.Count < _highers.Arr.Count)
            {
                return _highers.Poll();
            }

            return (_highers.Poll() + _lowers.Poll()) / 2.0;

        }
    }
}
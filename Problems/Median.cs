using DataStructures;

namespace Problems
{
    public class Median
    {
        private Heap _lowers;
        private Heap _highers;

        public Median()
        {
            _lowers = new Heap(false);
            _highers = new Heap();
        }

        public void AddNumber(int number)
        {
            Heap smallerSizeHeap = GetSmallerSizeHeap(number);
            smallerSizeHeap.AddNumber(number);
            BalanceHeaps();
        }

        private void BalanceHeaps()
        {
            while (_lowers.Arr.Count > _highers.Arr.Count + 1 || _lowers.Peek() > _highers.Peek())
            {
                int lowersMax = _lowers.Poll();
                _highers.AddNumber(lowersMax);
            }
            while (_lowers.Arr.Count < _highers.Arr.Count - 1)
            {
                int highersMin = _highers.Poll();
                _lowers.AddNumber(highersMin);
            }
        }

        private Heap GetSmallerSizeHeap(int number)
        {
            if (_lowers.Arr.Count > _highers.Arr.Count) return _highers;
            return _lowers;
        }

        public double GetMedian()
        {
            if (_lowers.Arr.Count > _highers.Arr.Count)
            {
                return _lowers.Poll();
            }
            else if (_lowers.Arr.Count < _highers.Arr.Count)
            {
                return _highers.Poll();
            }
            else
            {
                return (_highers.Poll() + _lowers.Poll()) / 2.0;
            }

        }
    }
}
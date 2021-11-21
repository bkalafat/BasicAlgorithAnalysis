using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class Heap
    {
        public List<int> Arr {get;}

        private readonly bool _minHeap;

        public Heap(bool minHeap = true)
        {
            Arr = new List<int>();
            _minHeap = minHeap;
        }

        public void AddNumber(int number)
        {
            Arr.Add(number);
            if (_minHeap)
                HeapifyUp();
            else
                HeapifyMaxUp();
        }

        public int Poll()
        {
            int rootValue = Arr[0];
            Arr[0] = Arr.LastOrDefault();
            Arr.RemoveAt(Arr.Count - 1);
            if (_minHeap)
                HeapifyDown();
            else
                HeapifyMaxDown();

            return rootValue;
        }

        public int Peek()
        {
            return Arr != null && Arr.Count > 0 ? Arr[0] : -1;
        }

        private void HeapifyUp()
        {
            int currentIndex = Arr.Count - 1;

            while (currentIndex > 0 && Arr[currentIndex] < GetParentValue(currentIndex))
            {
                Swap(currentIndex, GetParentIndex(currentIndex));
                currentIndex = GetParentIndex(currentIndex);
            }
        }

        private void HeapifyMaxUp()
        {
            int currentIndex = Arr.Count - 1;

            while (currentIndex > 0 && Arr[currentIndex] > GetParentValue(currentIndex))
            {
                Swap(currentIndex, GetParentIndex(currentIndex));
                currentIndex = GetParentIndex(currentIndex);
            }
        }

        private void HeapifyDown()
        {
            int currentIndex = 0;

            int smallerChildIndex = GetSmallerChildIndex(currentIndex);

            while (currentIndex < Arr.Count && smallerChildIndex > -1 && smallerChildIndex < Arr.Count && Arr[currentIndex] > Arr[smallerChildIndex])
            {
                Swap(currentIndex, smallerChildIndex);
                currentIndex = smallerChildIndex;
                smallerChildIndex = GetSmallerChildIndex(currentIndex);
            }

        }
        private void HeapifyMaxDown()
        {
            int currentIndex = 0;

            int biggerChildIndex = GetBiggerChildIndex(currentIndex);

            while (currentIndex < Arr.Count && biggerChildIndex > -1 && biggerChildIndex < Arr.Count && Arr[currentIndex] < Arr[biggerChildIndex])
            {
                Swap(currentIndex, biggerChildIndex);
                currentIndex = biggerChildIndex;
                biggerChildIndex = GetBiggerChildIndex(currentIndex);
            }

        }

        private static int GetLeftChildIndex(int currentIndex)
        {
            return currentIndex * 2 + 1;
        }
        private static int GetRightChildIndex(int currentIndex)
        {
            return currentIndex * 2 + 2;
        }
        private static int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        private int GetParentValue(int currentIndex)
        {
            return Arr[GetParentIndex(currentIndex)];
        }

        private void Swap(int indexOne, int indexTwo)
        {
            (Arr[indexOne], Arr[indexTwo]) = (Arr[indexTwo], Arr[indexOne]);
        }

        private int GetSmallerChildIndex(int currentIndex)
        {
            var leftIndex = GetLeftChildIndex(currentIndex);
            var rightIndex = GetRightChildIndex(currentIndex);
            if (leftIndex >= Arr.Count)
                return -1;
            if (rightIndex >= Arr.Count)
                return leftIndex;
            return Arr[GetLeftChildIndex(currentIndex)] <= Arr[GetRightChildIndex(currentIndex)] ? GetLeftChildIndex(currentIndex) : GetRightChildIndex(currentIndex);
        }

        private int GetBiggerChildIndex(int currentIndex)
        {
            var leftIndex = GetLeftChildIndex(currentIndex);
            var rightIndex = GetRightChildIndex(currentIndex);
            if (leftIndex >= Arr.Count)
                return -1;
            if (rightIndex >= Arr.Count)
                return leftIndex;
            return Arr[GetLeftChildIndex(currentIndex)] >= Arr[GetRightChildIndex(currentIndex)] ? GetLeftChildIndex(currentIndex) : GetRightChildIndex(currentIndex);
        }
    }
}
namespace Sort
{
    public static class SortingAlgorithms
    {
        public static void InsertionSort(IList<int> inputList)
        {
            for (var i = 1; i < inputList.Count; i++)
            {
                for (var j = i - 1; j >= 0; j--)
                {
                    if (inputList[j + 1] < inputList[j])
                    {
                        Swap(inputList, j, j + 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void BubbleSort(IList<int> inputList)
        {
            for (var i = 0; i < inputList.Count; i++)
            {
                var isSorted = true;
                for (var j = 0; j < inputList.Count - 1 - i; j++)
                {
                    if (inputList[j] <= inputList[j + 1]) continue;
                    Swap(inputList, j, j + 1);
                    isSorted = false;
                }
                if (isSorted)
                {
                    return;
                }
            }
        }

        public static void QuickSort(IList<int> inputList)
        {
            var pivotIndex = inputList.Count - 1;
            const int startIndex = 0;
            Partition(inputList, startIndex, pivotIndex);
        }

        private static void Partition(IList<int> inputList, int startIndex, int pivotIndex)
        {
            while (true)
            {
                var endIndex = pivotIndex - 1;
                if (startIndex >= endIndex) return;

                var smallerIndex = startIndex;

                for (var i = startIndex; i <= endIndex; i++)
                {
                    if (inputList[pivotIndex] <= inputList[i]) continue;
                    Swap(inputList, smallerIndex, i);
                    smallerIndex++;
                }

                Swap(inputList, smallerIndex, pivotIndex);
                Partition(inputList, 0, smallerIndex - 1); //left
                startIndex = smallerIndex + 1;
            }
        }

        private static void Swap(IList<int> inputList, int indexOne, int indexTwo)
        {
            (inputList[indexOne], inputList[indexTwo]) = (inputList[indexTwo], inputList[indexOne]);
        }
    }
}
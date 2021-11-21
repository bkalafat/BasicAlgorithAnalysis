namespace Sort
{
    public static class SortingAlgorithms
    {
        public static void InsertionSort(List<int> inputList)
        {
            for (int i = 1; i < inputList.Count; i++)
            {
                for (int j = i - 1; j >= 0; j--)
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

        public static void BubbleSort(List<int> inputList)
        {
            bool isSorted;
            for (int i = 0; i < inputList.Count; i++)
            {
                isSorted = true;
                for (int j = 0; j < inputList.Count - 1 - i; j++)
                {
                    if (inputList[j] > inputList[j + 1])
                    {
                        Swap(inputList, j, j + 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    return;
                }
            }
        }

        public static void QuickSort(List<int> inputList)
        {
            int pivotIndex = inputList.Count - 1;
            int startIndex = 0;
            Partition(inputList, startIndex, pivotIndex);
        }

        private static void Partition(List<int> inputList, int startIndex, int pivotIndex)
        {
            int endIndex = pivotIndex - 1;
            if (startIndex >= endIndex) return;

            int smallerIndex = startIndex;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (inputList[pivotIndex] > inputList[i])
                {
                    Swap(inputList, smallerIndex, i);
                    smallerIndex++;
                }
            }
            Swap(inputList, smallerIndex, pivotIndex);
            Partition(inputList, 0, smallerIndex - 1);//left
            Partition(inputList, smallerIndex + 1, pivotIndex);//right
        }

        private static void Swap(List<int> inputList, int indexOne, int indexTwo)
        {
            int temp = inputList[indexOne];
            inputList[indexOne] = inputList[indexTwo];
            inputList[indexTwo] = temp;
        }
    }
}
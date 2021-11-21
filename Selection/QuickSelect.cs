namespace Selection
{
    public static class QuickSelect
    {
        public static int Find(List<int> inputList, int kthElement)
        {
            int pivotIndex = inputList.Count - 1;
            int startIndex = 0;
            return Partition(inputList, startIndex, pivotIndex, kthElement - 1);
        }

        private static int Partition(List<int> inputList, int startIndex, int pivotIndex, int searchIndex)
        {
            int endIndex = pivotIndex - 1;
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
            if (searchIndex == smallerIndex)
                return inputList[smallerIndex];
            if (searchIndex < smallerIndex)
                return Partition(inputList, 0, smallerIndex - 1, searchIndex);//left
            else
                return Partition(inputList, smallerIndex + 1, pivotIndex, searchIndex);//right
        }

        private static void Swap(List<int> inputList, int indexOne, int indexTwo)
        {
            int temp = inputList[indexOne];
            inputList[indexOne] = inputList[indexTwo];
            inputList[indexTwo] = temp;
        }
    }
}
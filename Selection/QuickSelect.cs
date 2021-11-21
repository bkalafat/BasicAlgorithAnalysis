namespace Selection;

public static class QuickSelect
{
    public static int Find(List<int> inputList, int kthElement)
    {
        var pivotIndex = inputList.Count - 1;
        const int startIndex = 0;
        return Partition(inputList, startIndex, pivotIndex, kthElement - 1);
    }

    private static int Partition(IList<int> inputList, int startIndex, int pivotIndex, int searchIndex)
    {
        while (true)
        {
            var endIndex = pivotIndex - 1;
            var smallerIndex = startIndex;

            for (var i = startIndex; i <= endIndex; i++)
            {
                if (inputList[pivotIndex] <= inputList[i]) continue;
                Swap(inputList, smallerIndex, i);
                smallerIndex++;
            }

            Swap(inputList, smallerIndex, pivotIndex);
            if (searchIndex == smallerIndex) return inputList[smallerIndex];
            if (searchIndex < smallerIndex)
            {
                startIndex = 0;
                pivotIndex = smallerIndex - 1;
                continue;
            }

            startIndex = smallerIndex + 1;
        }
    }

    private static void Swap(IList<int> inputList, int indexOne, int indexTwo)
    {
        (inputList[indexOne], inputList[indexTwo]) = (inputList[indexTwo], inputList[indexOne]);
    }
}
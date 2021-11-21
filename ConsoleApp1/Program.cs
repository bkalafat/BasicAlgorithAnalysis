using DataStructures;
using Selection;

// Driver Code

int[] array = { 10, 4, 5, 8, 6, 11, 26 };
int[] arraycopy = { 10, 4, 5, 8, 6, 11, 26 };

int kPosition = 3;
int length = array.Length;

if (kPosition > length)
{
    Console.WriteLine("Index out of bound");
}
else
{
    // find kth smallest value
    Console.WriteLine( kPosition + "-th smallest element in array : " +
                        QuickSelect.kthSmallest(arraycopy, 0, length - 1,
                                                kPosition - 1));
}




static void PrintArray(List<int> inputList)
{
    foreach (int i in inputList)
    {
        Console.WriteLine(i);
    }
}

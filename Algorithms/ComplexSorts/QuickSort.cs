namespace Algorithms.ComplexSorts
{
    public class QuickSort
    {
        public static void Process(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(arr, start, end);
                Process(arr, start, pivotIndex - 1);
                Process(arr, pivotIndex + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int indexForSwap = start - 1;
            for (int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    indexForSwap++;
                    (arr[indexForSwap], arr[i]) = (arr[i], arr[indexForSwap]);
                }
            }

            indexForSwap++;
            (arr[indexForSwap], arr[end]) = (arr[end], arr[indexForSwap]);
            return indexForSwap;
        }
    }
}
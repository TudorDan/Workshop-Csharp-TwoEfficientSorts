namespace Algorithms.SimpleSorts
{
    public class InsertionSort
    {
        public static void Process(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int consideredSorted = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > consideredSorted)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = consideredSorted;
            }
        }
    }
}
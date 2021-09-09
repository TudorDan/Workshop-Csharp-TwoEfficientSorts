namespace Algorithms.SimpleSorts
{
    public class SelectionSort
    {
        public static void Process(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        (arr[j], arr[i]) = (arr[i], arr[j]);
                    }
                }
            }
        }
    }
}
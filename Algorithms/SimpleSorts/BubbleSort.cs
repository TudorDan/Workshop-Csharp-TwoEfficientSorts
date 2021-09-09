namespace Algorithms.SimpleSorts
{
    public class BubbleSort
    {
        public static void Process(int[] arr)
        {
            bool isComplete;
            int n = arr.Length;
            do
            {
                isComplete = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                        isComplete = false;
                    }
                }
            } while (!isComplete);
        }
    }
}
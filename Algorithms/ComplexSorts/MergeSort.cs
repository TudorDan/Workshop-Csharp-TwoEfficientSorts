namespace Algorithms.ComplexSorts
{
    public class MergeSort
    {
        /// <summary>
        /// Merge sort that sorts the given array.
        /// </summary>
        /// <param name="arr">the given array</param>
        /// <param name="first">index of the first element</param>
        /// <param name="last">index of the last element</param>
        public static void Process(int[] arr, int first, int last)
        {
            if (last - first >= 1)
            {
                int middle = (first + last) / 2;
                Process(arr, first, middle);
                Process(arr, middle + 1, last);
                Merge(arr, first, middle, last);
            }
        }

        /// <summary>
        /// Merge of a given array from 2 sub arrays:
        /// 1) the given array's first half;
        /// 2) the given array's second half.
        /// </summary>
        /// <param name="arr">the given array</param>
        /// <param name="left">given array start element index</param>
        /// <param name="middle">given array middle element index</param>
        /// <param name="right">given array end element index</param>
        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] resultArr = new int[right - left + 1];
            int firstSubArrIndex = left; //first subarray start element index
            int secondSubArrIndex = middle + 1; //second subarray start element index
            int i = 0;

            while (firstSubArrIndex <= middle && secondSubArrIndex <= right)
            {
                if (arr[firstSubArrIndex] < arr[secondSubArrIndex])
                {
                    resultArr[i] = arr[firstSubArrIndex];
                    firstSubArrIndex++;
                }
                else
                {
                    resultArr[i] = arr[secondSubArrIndex];
                    secondSubArrIndex++;
                }

                i++;
            }

            while (firstSubArrIndex <= middle)
            {
                resultArr[i] = arr[firstSubArrIndex];
                firstSubArrIndex++;
                i++;
            }

            while (secondSubArrIndex <= right)
            {
                resultArr[i] = arr[secondSubArrIndex];
                secondSubArrIndex++;
                i++;
            }

            for (int j = 0, k = left; k <= right; k++, j++)
            {
                arr[k] = resultArr[j];
            }
        }
    }
}
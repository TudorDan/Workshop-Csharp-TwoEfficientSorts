using System;
using System.Diagnostics;
using Algorithms.ComplexSorts;
using Algorithms.SimpleSorts;

namespace Algorithms
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const int size = 1_000;
            var arrTest1 = new int[size];
            var arrTest2 = new int[size];
            var arrTest3 = new int[size];
            var arrTest4 = new int[size];
            var arrTest5 = new int[size];
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                arrTest1[i] = random.Next(0, 10_000);
                arrTest2[i] = arrTest1[i];
                arrTest3[i] = arrTest1[i];
                arrTest4[i] = arrTest1[i];
                arrTest5[i] = arrTest1[i];
            }

            /*Console.WriteLine($"arr1 unsorted: [{string.Join(", ", arrTest1)}]");
            Console.WriteLine($"arr2 unsorted: [{string.Join(", ", arrTest2)}]");
            Console.WriteLine($"arr3 unsorted: [{string.Join(", ", arrTest3)}]");
            Console.WriteLine($"arr4 unsorted: [{string.Join(", ", arrTest4)}]");
            Console.WriteLine($"arr5 unsorted: [{string.Join(", ", arrTest5)}]");*/

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort.Process(arrTest1);
            stopwatch.Stop();
            var timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Bubble Sort running time: {ProcessTimeSpan(timeSpan)}");

            stopwatch.Reset();
            stopwatch.Start();
            InsertionSort.Process(arrTest2);
            stopwatch.Stop();
            timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Insertion Sort running time: {ProcessTimeSpan(timeSpan)}");
            
            stopwatch.Reset();
            stopwatch.Start();
            SelectionSort.Process(arrTest3);
            stopwatch.Stop();
            timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Selection Sort running time: {ProcessTimeSpan(timeSpan)}");
            
            stopwatch.Reset();
            stopwatch.Start();
            MergeSort.Process(arrTest4, 0, arrTest4.Length - 1);
            stopwatch.Stop();
            timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Merge Sort running time: {ProcessTimeSpan(timeSpan)}");
            
            stopwatch.Reset();
            stopwatch.Start();
            QuickSort.Process(arrTest5, 0, arrTest5.Length - 1);
            stopwatch.Stop();
            timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Quick Sort running time: {ProcessTimeSpan(timeSpan)}");
            
            /*Console.WriteLine($"arr1 sorted: [{string.Join(", ", arrTest1)}]");
            Console.WriteLine($"arr2 sorted: [{string.Join(", ", arrTest2)}]");
            Console.WriteLine($"arr3 sorted: [{string.Join(", ", arrTest3)}]");
            Console.WriteLine($"arr4 sorted: [{string.Join(", ", arrTest4)}]");
            Console.WriteLine($"arr5 sorted: [{string.Join(", ", arrTest5)}]");*/
        }

        private static string ProcessTimeSpan(TimeSpan span)
        {
            return $"{span.Hours:00} hours : {span.Minutes:00} minutes : "+
                   $"{span.Seconds:00} seconds : {span.Milliseconds:00} milliseconds.";
        }
    }
}
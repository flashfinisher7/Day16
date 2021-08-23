using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Bubble Sort Problem");
            int[] arr = { 77, 7, 17, 37, 57, 27, 67 };
            Sorting bubbleSort = new Sorting();
            bubbleSort.Sort(arr);
            bubbleSort.Display(arr);
        }
    }
}

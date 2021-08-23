using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Insertion Sort Problem");
            int[] arr = { 66, 81, 93, 75, 36 };
            Sorting obj = new Sorting();
            obj.sort(arr);
            obj.printArray(arr);
        }
    }
}

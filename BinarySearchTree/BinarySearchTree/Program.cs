﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinarySearch");
            String[] arr = { "apple", "banana", "orange", "grap", "kiwi" };
            String x = "banana";
            Binary obj = new Binary();
            int result = Binary.binarySearch(arr, x);

            if (result >= 0)
                Console.WriteLine("The word " + x + " is present at index : " + result);
            else

                Console.WriteLine(x + " is not present in list");
        }
    }
}

using System;
using System.Collections.Generic;

namespace SortAlgorithmsUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t Use Generics for Search and Sort Algorithms");
            Anagram.StringAnagram();
            List<int> list = PrimeRange.FindPrime();
            PrimeRange.Print(list);
            AnagramPrimePalindrome anagramAndPalindrome = new AnagramPrimePalindrome();
            anagramAndPalindrome.CheckPrimeAnagramAndPalindrome();
        }
    }
}

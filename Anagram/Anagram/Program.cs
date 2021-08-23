using System;

namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t This is Anagram problem");
            Word word = new Word();
            word.Anagram("anil", "lina");
        }
    }
}

using System;
using static Hashingsorting.Hashing;

namespace Hashingsorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tThis is Hashproblem");
            HashingSlots<string> hashtable = new HashingSlots<string>();
            hashtable.CheckNumber();
        }
    }
}

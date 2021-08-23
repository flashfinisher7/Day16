using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CashCounter<string> BC1 = new CashCounter<string>();
            BC1.CashCounter();
        }
    }
}

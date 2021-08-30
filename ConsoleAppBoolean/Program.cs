using System;

namespace BooleanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int x = 10;
            result = (!(x == 10));
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
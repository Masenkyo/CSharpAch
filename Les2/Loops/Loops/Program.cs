using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] even = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
            for (int i = 0; i < even.Length; i += 2)
            {
                Console.WriteLine(even[i]);
            }
        }
    }
}

using System;

namespace Arrays
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] A = { 10, 20, 30, 40, 50, 60 };
            int[] B = new int[6];

            int index = 0;

            for (int i = A.Length - 1; i > -1; i--)
            {
                B[index] = A[i];
                index++;
            }
            Console.WriteLine("A " + String.Join(" ", A));
            Console.WriteLine("B " + String.Join(" ", B));
            Console.Read();
        }
    }
}

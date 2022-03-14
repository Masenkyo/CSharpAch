using System;
using System.Threading;

namespace FunctiesReturn
{
    class Program
    {
        static float Naam()
        {
            Random rand = new Random();
            float rnd = rand.Next(0, 20);
            return rnd;
        }
        static void Main(string[] args)
        { 
            Naam();
            Console.WriteLine(Naam());
        }
    }
}

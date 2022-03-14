using System;
using System.Threading;

namespace Tijd_Op_Het_Scherm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            Random random = new Random();

            ConsoleColor[] kleur = new ConsoleColor[4];
            kleur[0] = ConsoleColor.Red;
            kleur[1] = ConsoleColor.Blue;
            kleur[2] = ConsoleColor.Green;
            kleur[3] = ConsoleColor.Yellow;

            while (true)
            {
                if (i == 10)
                {
                    i = 0;
                    ConsoleColor lastcolor = Console.ForegroundColor;

                    while (Console.ForegroundColor == lastcolor)
                    {
                        Console.ForegroundColor = kleur[random.Next(0, 4)];
                    }
                }
                i++;

                Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
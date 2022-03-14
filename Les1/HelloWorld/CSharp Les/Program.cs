using System;
using System.Threading;

    Console.ForegroundColor = ConsoleColor.Green;
    Print("Hello, World!");

static void Print(string text, int speed = 1000)
{
    foreach (char c in text)
    {
        Console.Write(c);
        System.Threading.Thread.Sleep(speed);
    }
    Console.WriteLine();
}

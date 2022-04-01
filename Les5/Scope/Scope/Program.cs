using System;

namespace Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scope();
        }
        static void Scope()
        {
            for (int i = 0; i < 100; i++) ;
            {
                if (true)
                {

                }
            }
        }
    }
}

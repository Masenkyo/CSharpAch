using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            float Number1 = 1;
            float Number2 = 2;

            Rekenmachine rekenmachine = new Rekenmachine();
            rekenmachine.Keer(Number1, Number2);
            rekenmachine.Delen(Number1, Number2);
            rekenmachine.Plus(Number1, Number2);
            rekenmachine.Min(Number1, Number2);

            Console.WriteLine(Number1 + " x " + Number2 + " = " + rekenmachine.Keer(Number1, Number2));
            Console.WriteLine(Number1 + " / " + Number2 + " = " + rekenmachine.Delen(Number1, Number2));
            Console.WriteLine(Number1 + " + " + Number2 + " = " + rekenmachine.Plus(Number1, Number2));
            Console.WriteLine(Number1 + " - " + Number2 + " = " + rekenmachine.Min(Number1, Number2));


        }
    }
}

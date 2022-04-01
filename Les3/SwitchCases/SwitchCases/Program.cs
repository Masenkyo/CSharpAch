using System;

namespace Switch_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            try
            {
                number = Int32.Parse(input);
                switch (number)
                {
                    case 69:
                        Console.WriteLine("69 Nice, dit is een grappig getal :]");
                        Console.ReadLine();
                        return;
                    case 420:
                        Console.WriteLine("420 Nice, dit is wel een goed getal.");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Je hebt het getal " + number + " ingevoerd o.o");
                        Console.ReadLine();
                        return;
                }
            }
            catch
            {
                Console.WriteLine("Geen Getal");
            }
            Console.Read();
        }
    }
}

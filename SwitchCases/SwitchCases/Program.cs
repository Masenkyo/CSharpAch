using System;

namespace Switch_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int Getal))
                {
                    switch (Getal)
                    {
                        case 0:
                            Console.WriteLine("Je hebt een 0 ingevoerd");
                            break;
                        case 1:
                            Console.WriteLine("Je hebt een 1 ingevoerd");
                            break;
                        default:
                            Console.WriteLine("Dit is de default case baka: " + Getal);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Voer een nummer in niet symbolen of letters doepie");
                }

                Console.WriteLine("");
            }
        }
    }
}

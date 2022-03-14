using System;

namespace Calculator
{
    class Rekenmachine
    {
        static void Main(string[] args)
        {

            float Number1;
            float Number2;
            string Calculation;
            float Antwoord;

            Console.WriteLine("Calculator");
            Console.Write("Eerste nummer : ");
            Number1 = Convert.ToInt32(Console.ReadLine());

            //User input for equation
            Console.Write("Tweede nummer : ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type berekening : ( x , : , +, -) ");
            Calculation = Console.ReadLine();

            if (Calculation == "x")
            {
                Antwoord = Number1 * Number2;
                Console.WriteLine(Number1 + " x " + Number2 + " = " + Antwoord);
                Console.ReadLine();
            }
            else if (Calculation == ":")
            {
                Antwoord = Number1 / Number2;
                Console.WriteLine(Number1 + " / " + Number2 + " = " + Antwoord);
                Console.ReadLine();
            }
            //Getting answers
            else if (Calculation == "+")
            {
                Antwoord = Number1 + Number2;
                Console.WriteLine(Number1 + " + " + Number2 + " = " + Antwoord);
                Console.ReadLine();
            }
            else if (Calculation == "-")
            {
                Antwoord = Number1 - Number2;
                Console.WriteLine(Number1 + " - " + Number2 + " = " + Antwoord);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dat kan niet");
                Console.Write("Type berekening : ( x , : , +, -) ");
                Calculation = Console.ReadLine();
                Console.ReadLine();
            }
        }
    }
}
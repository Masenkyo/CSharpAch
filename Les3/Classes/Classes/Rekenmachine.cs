using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Rekenmachine
    {
        public float Keer(float Number1, float Number2)
        {
            float Antwoord;
            Antwoord = Number1 * Number2;
            return Antwoord;
        }
        public float Delen(float Number1, float Number2)
        {
            float Antwoord;
            Antwoord = Number1 / Number2;
            return Antwoord;
        }
        public float Plus(float Number1, float Number2)
        {
            float Antwoord;
            Antwoord = Number1 + Number2;
            return Antwoord;
        }
        public float Min(float Number1, float Number2)
        {
            float Antwoord;
            Antwoord = Number1 - Number2;
            return Antwoord;
        }
    }
}

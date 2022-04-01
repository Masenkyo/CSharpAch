using System;

namespace Overerving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal whitehorse = new Horse();
            Animal blackhorse = new Horse();
            Console.WriteLine(whitehorse.MeasureFatness());
            whitehorse.Feed(5);
            Animal Gert = new Chicken();
            Chicken a = Gert as Chicken;
            a.LayEgg();
        }
    }
    class Animal
    {
        protected int hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                if (value > hungermax)
                    value = hungermax;
                _hunger = value;
            }
        }
        private int _hunger;
        protected int hungermax
        {
            get; set;
        }
        public void Feed(int v)
        {
            hunger -= 1;
        }
        public void Starve(int ammount)
        {
            hunger -= ammount;
        }
        public int MeasureFatness()
        {
            return hunger;
        }
    }
    class Horse : Animal
    {
        public Horse()
        {
            hungermax = 100;
            hunger = 100;
        }
        public void Feed(int ammount)
        {
            hunger += ammount;
        }
    }
    class Chicken : Animal
    {
        public Chicken()
        {
            hungermax = 10;
            hunger = 10;
        }
        public void LayEgg()
        {
            Console.WriteLine("I just shit out an egg mate!");
        }
    }
}


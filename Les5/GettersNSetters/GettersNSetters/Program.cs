using System;

namespace getters_en_setters_trello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Ball rodebal = new Ball("de rode bal");
            Ball gelebal = new Ball("de gele bal");
            Ball kleinebal = new Ball("de kleine bal");
            Ball grotebal = new Ball("de grote bal");
            dog.FetchBall(kleinebal);
            Console.WriteLine(dog.GiveBall().naam);
            dog.FetchBall(rodebal);
            Console.WriteLine(dog.GiveBall().naam);

            Ball huidigeBall = dog.GiveBall();
        }
    }
    class Dog
    {
        private Ball BallInHondBek;
        public void FetchBall(Ball ball) //veranderd de bal
        {
            this.BallInHondBek = ball;
        }
        public Ball GiveBall()//return de bal zodat je er iets mee kan
        {
            return BallInHondBek;
        }
    }
    class Ball
    {
        public string naam;
        public Ball(string naam)
        {
            this.naam = naam;
        }
    }
}
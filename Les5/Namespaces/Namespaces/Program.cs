using System;

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
namespace Namespaces1
{
    internal class Namespaceclass
    {
        Namespaces2.Vector2 bruh = new Namespaces2.Vector2(3, 6);
    }
}
namespace Namespaces2
{
    public struct Vector2
    {
        public int x;
        public int y;
        public Vector2(int vx, int vy)
        {
            this.x = vx;
            this.y = vy;
        }
    }
}

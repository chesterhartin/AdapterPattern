using System;

namespace Adapters
{
    /// <summary>
    /// An 'Adaptee' class
    /// </summary>
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}

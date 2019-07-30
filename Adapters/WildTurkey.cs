using System;

namespace Adapters
{
    /// <summary>
    /// An 'Adaptee' class
    /// </summary>
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }
    }
}

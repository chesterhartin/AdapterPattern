using System;

namespace Adapters
{
    /// <summary>
    /// An 'Adapter' class, adapts ducks to turkeys
    /// </summary>
    public class DuckToTurkeyAdapter : ITurkey
    {
        private IDuck _duck;
        private Random _random = new Random();

        // Constructor
        public DuckToTurkeyAdapter(IDuck duck)
        {
            this._duck = duck;
        }

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            if (_random.Next(5) == 0)
            {
                _duck.Fly();
            }
        }
    }
}

namespace Adapters
{
    /// <summary>
    /// An 'Adapter' class, adapts turkeys to ducks
    /// </summary>
    public class TurkeyToDuckAdapter : IDuck
    {
        private ITurkey _turkey;

        // Constructor
        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            this._turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}

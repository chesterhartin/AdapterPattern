using System;

namespace Adapters
{
    /// <summary>
    /// The 'Adaptee' class, Classic structure example
    /// </summary>
    public class Adaptee : IAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}

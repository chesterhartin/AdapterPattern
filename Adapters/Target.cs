using System;

namespace Adapters
{
    /// <summary>
    /// The 'Target' class, Classic structure example
    /// </summary>
    public class Target : ITarget
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}

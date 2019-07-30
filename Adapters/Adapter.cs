namespace Adapters
{
    /// <summary>
    /// The 'Adapter' class, Classic structure example
    /// </summary>
    public class Adapter : Target
    {
        private IAdaptee adaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work
            //   and then call SpecificRequest
            adaptee.SpecificRequest();
        }
    }
}

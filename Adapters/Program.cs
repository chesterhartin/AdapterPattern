using System;

namespace Adapters
{
    /// <summary>
    /// This will function as the 'Client'
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            //*** STRUCTURE EXAMPLE ***/
            // Create adapter and place a request
            var target = new Adapter();
            target.Request();


            //*** REAL WORLD EXAMPLE ***/
            // Chemical compound 
            var unknown = new Compound();
            unknown.Display();

            // Adapted chemical compounds
            var water = new RichCompound(Chemical.Water);
            water.Display();

            var benzene = new RichCompound(Chemical.Benzene);
            benzene.Display();

            var ethanol = new RichCompound(Chemical.Ethanol);
            ethanol.Display();


            //*** REAL WORLD EXAMPLE ***/
            // Ducks and Turkeys
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyToDuckAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            Console.WriteLine("The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            // Test 2: Turkey test drive

            ITurkey duckAdapter = new DuckToTurkeyAdapter(duck);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The DuckAdapter says...");
                duckAdapter.Gobble();
                duckAdapter.Fly();
            }

        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}

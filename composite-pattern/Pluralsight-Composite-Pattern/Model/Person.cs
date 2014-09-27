using System;

namespace Pluralsight_Composite_Pattern.Model
{
    public class Person : IParty
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} gets {1} gold for killing the Giant IE6 Monster!", Name, Gold);
        }
    }
}
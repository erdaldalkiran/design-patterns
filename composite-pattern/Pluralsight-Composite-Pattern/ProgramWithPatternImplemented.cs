using System;
using Pluralsight_Composite_Pattern.Model;

namespace Pluralsight_Composite_Pattern
{
    internal static class ProgramWithPatternImplemented
    {
        internal static void Run(string[] args)
        {
            const int goldForKill = 1023;

            Console.WriteLine("You have killed the Giant IE6 Monstoer and gained {0} gold!", goldForKill);

            var joe = new Person { Name = "Joe" };

            var jake = new Person { Name = "Jake" };

            var emily = new Person { Name = "Emily" };

            var sophia = new Person { Name = "Sophia" };

            var brian = new Person { Name = "Brian" };

            var oldBob = new Person { Name = "Old Bob" };

            var newBob = new Person { Name = "New Bob" };

            var bobs = new Group { Name = "Bobs", Members = { oldBob, newBob } };

            var developers = new Group { Name = "Developers", Members = { joe, jake, emily, bobs } };

            var party = new Group { Name = "All", Members = { sophia, brian, developers } };

            party.Gold += goldForKill;

            party.Stats();

            Console.ReadKey();
        }
    }
}
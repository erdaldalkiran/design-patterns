using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Pluralsight_Composite_Pattern.Model;
using Group = Pluralsight_Composite_Pattern.Model.Group;

namespace Pluralsight_Composite_Pattern
{
    internal static class ProgramWithOutPatternImplemented
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

            var developers = new Group { Name = "Developers", Members = { joe, jake, emily } };

            var indivuals = new List<Person> { sophia, brian };

            var groups = new List<Group> { developers };

            var totalToSplitBy = indivuals.Count + groups.Count;

            var amountForEach = goldForKill / totalToSplitBy;

            var leftover = goldForKill % totalToSplitBy;

            foreach (var indivual in indivuals)
            {
                indivual.Gold += amountForEach + leftover;
                leftover = 0;
                indivual.Stats();
            }

            foreach (var group in groups)
            {
                var amountForEachGroupMember = amountForEach / group.Members.Count;
                var leftOverForGroup = amountForEach % group.Members.Count;

                foreach (var member in group.Members)
                {
                    member.Gold += amountForEachGroupMember + leftOverForGroup;
                    leftOverForGroup = 0;
                    member.Stats();
                }
            }

            Console.ReadKey();
        }
    }
}

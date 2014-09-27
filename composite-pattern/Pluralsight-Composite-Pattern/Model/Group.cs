using System.Collections.Generic;
using System.Linq;

namespace Pluralsight_Composite_Pattern.Model
{
    public class Group : IParty
    {
        public Group()
        {
            Members = new List<IParty>();
        }
        public string Name { get; set; }

        public List<IParty> Members { get; set; }

        public int Gold
        {
            get
            {
                return Members.Sum(member => member.Gold);
            }
            set
            {
                var amountForEachGroupMember = value / Members.Count;
                var leftOverForGroup = value % Members.Count;

                foreach (var member in Members)
                {
                    member.Gold += amountForEachGroupMember + leftOverForGroup;
                    leftOverForGroup = 0;
                }
            }
        }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}
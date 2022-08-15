using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR5Tracker
{
    public class Initiative
    {
        public Character Character { get; set; }
        public string Name { get; set; }
        public InitiativeType Type { get; set; }
        public int Value { get; set; }
    }
}

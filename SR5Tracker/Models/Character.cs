using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR5Tracker
{
    public class Character
    {
        public string Name { get; set; }
        public bool IsEnemy { get; set; }
        public int PhysicalHealth { get; set; }
        public int PhysicalHealthMax { get; set; }
        public int StunHealth { get; set; }
        public int StunHealthMax { get; set; }
    }
}

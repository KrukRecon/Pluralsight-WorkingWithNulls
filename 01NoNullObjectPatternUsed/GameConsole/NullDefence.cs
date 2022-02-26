using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class NullDefence : SpecialDefence
    {
        public override int CalculateDamageReduction() => 0;
    }
}

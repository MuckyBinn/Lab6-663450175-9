using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Wartortle : Pokemon
    {
        public Wartortle()
        {
            name = "Wartortle";
            id = "8";
            level = 1;
            type = Type.Water;
            pic = Properties.Resources.Wartortle;
        }
    }
}

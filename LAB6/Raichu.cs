using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    internal class Raichu : Pokemon
    {
        public Raichu()
        {
            name = "Raichu";
            id = "26";
            level = 1;
            type = Type.Electr;
            pic = Properties.Resources.Raichu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB6
{
    internal class Blastoise : Pokemon
    {
        public Blastoise()
        {
            name = "Blastoise";
            id = "9";
            level = 1;
            type = Type.Water;
            pic = Properties.Resources.Blastoise;
        }
    }
}

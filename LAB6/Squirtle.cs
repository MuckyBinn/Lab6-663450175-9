using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB6
{
    internal class Squirtle : Pokemon
    {
        public Squirtle()
        {
            name = "Squirtle";
            id = "7";
            level = 1;
            type = Type.Water;
            pic = Properties.Resources.Squirtle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB6
{
    internal class Pikachu : Pokemon
    {
        public Pikachu()
        {
            name = "Pikachu";
            id = "25";
            level = 1;
            type = Type.Electr;
            pic = Properties.Resources.Pikachu;
        }
    }
}

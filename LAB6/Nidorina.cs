using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB6
{
    internal class Nidorina : Pokemon
    {
        public Nidorina()
        {
            name = "Nidorina";
            id = "30";
            level = 1;
            type = Type.Poison;
            pic = Properties.Resources.Nidorina;
            //663450175-9 ธนบดี ภาคภูมิ
        }
    }
}

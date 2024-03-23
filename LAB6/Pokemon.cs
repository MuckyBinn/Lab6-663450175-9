using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    public enum Abilities
    {
        Poison_Point, Rivalry, Hustle, Torrent_Rain_Dish, Static_Lightning_Rod
    }
    public enum Type
    {
        Poison, Electr, Water
    }
    internal class Pokemon
    {
        public string id;
        public string name;
        public Image pic;
        public int level = 1;
        public Type type;
        public Abilities abilities;
    }
}

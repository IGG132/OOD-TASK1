using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
    public abstract class Item
    {
        public char Symbol { get; set; }
        public string Name { get; set; }
        public abstract string GetName();
        public abstract bool IsEquiabble();
        public abstract bool Is2Handed();
        public abstract void Pickup(player player);

    }
}

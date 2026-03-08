using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
    public abstract class unusableI:Item
    {
        public override bool IsEquiabble() => false;
        public override bool Is2Handed() => false;
        public override string GetName()
        {
            return $"{Name}";
        }
        public override void Pickup(player player)
        {
            player.AddToInventory(this);
            
        }
    }
    public class Stone:unusableI
    {
       public Stone()
        {
            Name = "Stone";
            Symbol = 'T';

        }
    }
    public class Plank : unusableI
    {
     public   Plank()
        {
            Name = "Plank";
            Symbol = 'P';

        }
    }
    public class Water : unusableI
    {
        public Water()
        {
            Name = "Water";
            Symbol = 'W';

        }
    }
    //add the 3 thingies;
}

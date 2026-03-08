using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace OOBProject
{
    public abstract class weapon:Item
    {
        public int damage {  get; set; }
        public bool twohanded { get; set; }
        public override bool Is2Handed() => twohanded;
        public override bool IsEquiabble() => true;
        public override void Pickup(player player)
        {
            player.AddToInventory(this);
           // return true;
        }
        public override string GetName()
        {
            string handy;
            if(twohanded)
            {
                handy = "TwoHanded";
            }
            else
            {
                handy = "OneHanded";
            }
            return $"{Name} : {handy} : {damage}";
        }
        //add the 3 weapons;
    }
    public class Sword : weapon
    {
        public Sword()
        {
            Name = "Sword";
            Symbol = 'S';
            damage = 16;
            twohanded = false;
        }
    }

    public class Dagger : weapon
    {
        public Dagger()
        {
            Name = "Dagger";
            Symbol = 'D';
            damage = 12;
            twohanded = false;
        }
    }

    public class BIGAxe : weapon
    {
        public BIGAxe()
        {
            Name = "BIGAxe";
            Symbol = 'G';
            damage = 24;
            twohanded = true;
        }
    }
}




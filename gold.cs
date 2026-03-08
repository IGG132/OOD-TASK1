using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
    public  class gold:currency
    {
        public gold()
        {
            Name = "Gold";
            Symbol = 'g';
        }
        public override string GetName() => "Gold";
        public override void Pickup(player player) => player.gold=player.gold+1;
    }
}

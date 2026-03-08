using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
    internal class coin:currency
    {
        public coin()
        {
            Name = "Coin";
            Symbol = 'c';
        }
        public override string GetName() => "Coin";
        public override void Pickup(player player) => player.coins++;
    }
}

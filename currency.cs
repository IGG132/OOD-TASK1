using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
   public abstract class currency:Item
    {
        public override bool IsEquiabble() => false;
        public override bool Is2Handed() => false;
      //  public abstract bool Pickup();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
    public class cell
    {
        public bool isitWall;
        public List<Item> Items;
        public bool isWall()
        {
            if (isitWall)
            {
                return true;
            }
            return false;
        }
        public cell()
        {
            Items = new List<Item>();
            isitWall = false;
        }
        public cell(List<Item> itemki, bool isitWall1)
        {
            Items = itemki;
            isitWall = isitWall1;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);

        }
        public Item RemoveItem(Item item)
        {
            Items.Remove(item);
            return item;
        }
        public char GettheSymbol()
        {
            if (isitWall) { return '|'; }
            if (Items.Count >= 1) { return Items[0].Symbol; }
            else
            {
                return ' ';
            }
        }

    }
}
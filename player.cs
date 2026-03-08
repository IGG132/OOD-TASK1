using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
    public class player
    {

        public int r { get; set; }
        public int c { get; set; }
        public int Health { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Dexterity { get; set; } = 10;
        public int Inteligence { get; set; } = 10;
        public int Wisdom { get; set; } = 10;
        public int Luck { get; set; } = 10;
        public int Agility { get; set; } = 10;
        public Item? RHand { get; set; }
        public Item? LHand { get; set; }
        public int gold { get; set; }
        public int coins { get; set; }
        public List<Item>? Inventory { get; set; }
        public player(int r1, int c1)
        {
            r = r1;
            c = c1;
            Inventory = new List<Item>();
        }
        public void Movement(int horizontal, int vertical, szachownica szachownica)
        {
            int newr = r + vertical;
            int newc = c + horizontal;
            if (szachownica.NoEscape(newr, newc) && !szachownica.Getthecell(newr, newc).isWall())
            {
                r = newr;
                c = newc;
            }
        }
        public void AddToInventory(Item item) => Inventory.Add(item);
        public void PickUpszach(szachownica szachownica)
        {
            cell cell = szachownica.Getthecell(r, c);
            if (cell.Items.Count > 0)
            {
                Item item1 = cell.Items[0];
                cell.Items.Remove(item1);
                item1.Pickup(this);
            }
        }
        public void DropI(Item item, szachownica szachownica)
        {
            if (Inventory.Remove(item))
            {
                szachownica.Getthecell(r, c).AddItem(item);
            }
        }
        public void DropH(szachownica szachownica)
        {
            if (LHand == null)
            {
             
                if (RHand != null)
                {
                    Item item = RHand;
                    if (item.Is2Handed())
                    {
                        LHand = null;
                    }
                    szachownica.Getthecell(r, c).AddItem(item);
                    RHand = null;
                }
            }
            if(LHand != null)
            {
                Item item1 = LHand;
                if (item1.Is2Handed())
                {
                    RHand = null;
                }
                szachownica.Getthecell(r, c).AddItem(item1);
                LHand = null;
                return;
            }
        }
        public bool Equip(Item item)
        {
            if (!item.IsEquiabble())
                return false;

            if (item.Is2Handed())
            {
                if (LHand != null || RHand != null)
                    return false;

                LHand = item;
                RHand = item;
                Inventory.Remove(item);
                return true;
            }

            if (LHand == null)
            {
                LHand = item;
                Inventory.Remove(item);
                return true;
            }

            if (RHand == null)
            {
                RHand = item;
                Inventory.Remove(item);
                return true;
            }

            return false;
        }
    }
}

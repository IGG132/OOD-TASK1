using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBProject
{
    public class szachownica
    {
        public const int Rows = 20;
        public const int Cols = 40;

        public cell[,] _szachownica;
        public szachownica()
        {
            _szachownica = new cell[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    _szachownica[i, j] = new cell();
                }
            }
            SetUp();
        }
        private void MakeWall(int r, int c)
        {
            _szachownica[r, c].isitWall = true;
        }
        private void MakeItem(int r, int c, Item item)
        {
            _szachownica[r, c].AddItem(item);
        }
        public cell Getthecell(int r, int c)
        {
            return _szachownica[r, c];
        }
        public bool NoEscape(int r, int c)
        {
            if (r > Rows-1 || r < 0 || c > Cols-1 || c < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void SetUp()
        {


            // small top-left obstacle
            MakeWall(2, 5);
            MakeWall(2, 6);
            MakeWall(2, 7);
            MakeWall(3, 7);
            MakeWall(4, 7);

            // middle L-shaped wall
            MakeWall(6, 10);
            MakeWall(7, 10);
            MakeWall(8, 10);
            MakeWall(8, 11);
            MakeWall(8, 12);
            MakeWall(8, 13);

            // right-side block
            MakeWall(3, 25);
            MakeWall(3, 26);
            MakeWall(3, 27);
            MakeWall(4, 27);
            MakeWall(5, 27);
            MakeWall(6, 27);

            // lower-left corner obstacle
            MakeWall(14, 4);
            MakeWall(15, 4);
            MakeWall(16, 4);
            MakeWall(16, 5);
            MakeWall(16, 6);

            // lower-middle horizontal wall
            MakeWall(13, 15);
            MakeWall(13, 16);
            MakeWall(13, 17);
            MakeWall(13, 18);
            MakeWall(13, 19);

            // bottom-right obstacle
            MakeWall(15, 30);
            MakeWall(16, 30);
            MakeWall(17, 30);
            MakeWall(17, 31);
            MakeWall(17, 32);

            // weapons
            MakeItem(1, 2, new Sword());
            MakeItem(5, 3, new Dagger());
            MakeItem(10, 20, new BIGAxe());

            // unusable items
            MakeItem(3, 12, new Stone());
            MakeItem(7, 18, new Plank());
            MakeItem(11, 6, new Water());

            // currency
            MakeItem(2, 15, new coin());
            MakeItem(2, 16, new coin());
            MakeItem(6, 22, new gold());
            MakeItem(12, 8, new coin());
            MakeItem(18, 35, new gold());
        }
    }
}


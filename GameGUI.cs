using System;
using System.Collections.Generic;

namespace OOBProject
{
    public class GameGUI
    {
        private const int SidebarCol = 50;
        private const int SidebarWidth = 30;

        public void Make(szachownica szachownica, player player, int selectedIndex = -1)
        {
            Console.CursorVisible = false;

            DrawMap(szachownica, player);
            DrawSidebar(szachownica, player, selectedIndex);/////////////

            Console.SetCursorPosition(0, szachownica.Rows + 2);
        }

        private void DrawMap(szachownica szachownica, player player)
        {
            DrawBorderLine(0, szachownica.Cols, '┌', '┐');

            for (int r = 0; r < szachownica.Rows; r++)
            {
                Console.SetCursorPosition(0, r + 1);
                Console.Write('│');

                for (int c = 0; c < szachownica.Cols; c++)
                {
                    if (r == player.r && c == player.c)
                    {
                        Console.Write('¶');
                    }
                    else
                    {
                        Console.Write(szachownica.Getthecell(r, c).GettheSymbol());
                    }
                }

                Console.Write('│');
            }

            DrawBorderLine(szachownica.Rows + 1, szachownica.Cols, '└', '┘');
        }

        private void DrawBorderLine(int row, int width, char left, char right)
        {
            Console.SetCursorPosition(0, row);
            Console.Write(left);
            Console.Write(new string('─', width));
            Console.Write(right);
        }

        private void DrawSidebar(szachownica szachownica, player player, int selectedIndex)
        {
            List<string> sidebarLines = BuildSidebar(szachownica, player, selectedIndex);/////////////

            for (int i = 0; i < sidebarLines.Count; i++)
            {
                Console.SetCursorPosition(SidebarCol, i);
                Console.Write(sidebarLines[i].PadRight(SidebarWidth));
            }

            for (int i = sidebarLines.Count; i < szachownica.Rows + 15; i++)
            {
                Console.SetCursorPosition(SidebarCol, i);
                Console.Write(new string(' ', SidebarWidth));
            }
        }

        private List<string> BuildSidebar(szachownica szachownica, player player, int selectedIndex)
        {
            var lines = new List<string>();

            lines.Add("=== PLAYER ===");
            lines.Add($"HP : {player.Health}");
            lines.Add($"AGI: {player.Agility}");
            lines.Add($"STR: {player.Strength}");
            lines.Add($"DEX: {player.Dexterity}");
            lines.Add($"INT: {player.Inteligence}");
            lines.Add($"WIS: {player.Wisdom}");
            lines.Add($"LCK: {player.Luck}");
            lines.Add("");

            lines.Add("=== EQUIPMENT ===");
            lines.Add($"Left : {player.LHand?.GetName() ?? "empty"}");
            lines.Add($"Right: {player.RHand?.GetName() ?? "empty"}");
            lines.Add("");

            lines.Add("=== INVENTORY ===");
            if (player.Inventory.Count == 0)////////
            {
                lines.Add("  (empty)");
            }
            else
            {
                for (int i = 0; i < player.Inventory.Count; i++)
                {
                    string marker = i == selectedIndex ? "*" : "-";
                    lines.Add($"{marker} {i + 1}. {player.Inventory[i].GetName()}");
                }
            }

            var cell = szachownica.Getthecell(player.r, player.c);
            if (cell.Items.Count > 0)
            {
                lines.Add("");
                lines.Add("=== GROUND ===");
                foreach (var item in cell.Items)
                {
                    lines.Add($"- {item.GetName()}");
                }
            }

            lines.Add("");
            lines.Add("=== MONEY ===");
            lines.Add($"Coins: {player.coins}");
            lines.Add($"Gold : {player.gold}");

            return lines;
        }
    }
}

using OOBProject;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.BufferHeight = 60;
Console.BufferWidth = 120;

var szachownica = new szachownica();
var player = new player(0, 0);
var renderer = new GameGUI();
int selectedIndex = -1;

Console.Clear();
renderer.Make(szachownica, player, selectedIndex);

while (true)
{
    var key = Console.ReadKey(true).Key;

    switch (key)
    {
        case ConsoleKey.W: player.Movement(0, -1, szachownica); break;
        case ConsoleKey.S: player.Movement(0, 1, szachownica); break;
        case ConsoleKey.D: player.Movement(1, 0, szachownica); break;
        case ConsoleKey.A: player.Movement(-1, 0, szachownica); break;

        case ConsoleKey.E:
            player.PickUpszach(szachownica);
            selectedIndex = -1;
            break;

        case ConsoleKey.D1: case ConsoleKey.NumPad1: selectedIndex = 0; break;
        case ConsoleKey.D2: case ConsoleKey.NumPad2: selectedIndex = 1; break;
        case ConsoleKey.D3: case ConsoleKey.NumPad3: selectedIndex = 2; break;
        case ConsoleKey.D4: case ConsoleKey.NumPad4: selectedIndex = 3; break;
        case ConsoleKey.D5: case ConsoleKey.NumPad5: selectedIndex = 4; break;
        case ConsoleKey.D6: case ConsoleKey.NumPad6: selectedIndex = 5; break;
        case ConsoleKey.D7: case ConsoleKey.NumPad7: selectedIndex = 6; break;
        case ConsoleKey.D8: case ConsoleKey.NumPad8: selectedIndex = 7; break;
        case ConsoleKey.D9: case ConsoleKey.NumPad9: selectedIndex = 8; break;

        case ConsoleKey.Q:
            if (selectedIndex >= 0 && selectedIndex < player.Inventory.Count)
                player.Equip(player.Inventory[selectedIndex]);
            selectedIndex = -1;
            break;

        case ConsoleKey.F:
            if (selectedIndex >= 0 && selectedIndex < player.Inventory.Count)
                player.DropI(player.Inventory[selectedIndex],szachownica);
            selectedIndex = -1;
            break;
        case ConsoleKey.G:
           player.DropH(szachownica);
            break;
    }

    renderer.Make(szachownica, player, selectedIndex);
}
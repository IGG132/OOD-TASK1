namespace OOBProject    
{
    public abstract class GameTile
    {
        public char symbol;
        public int positionx;
        public int positiony;
    }
    public class Room  
    {
        public GameTile[][] plane;

    }
    public class Player
    {
        public bool w;
        public bool a;
        public bool s;
        public bool d;
        public int positionx { get; set; }
        public int positiony { get; set; }
        public int Health { get; set; }
        public int Strength {  get; set; }
        public int Dexterity { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Luck { get; set; }
        public int Agility { get; set; }
        public bool RHandstate;
        public IItem RHand;
        public bool LHandstate;
        public string LHand;



    }
    public interface IItem
    {
        char Getchar();
    }
    public abstract class Item : IItem
    {
        public abstract bool handiness { get; }
        public abstract char Getchar();
    }
   public  class Gold : Item
    {
        public override bool handiness => false;
        public override char Getchar() => 'G';
    }
    public class Coin : Item
    {
        public override bool handiness => false;
        public override char Getchar() => 'C';
    }
    public abstract class Weapon : Item
    {
       public abstract int WeaponDamage {  get; }//false - one hand ;true - 2 hand
        public override char Getchar() => 'W';
    }
    public class ShortSword : Weapon
    {
        public override int WeaponDamage => 6;
        public override bool handiness =>false ;
        public override char Getchar() => 's';
    }
    public class LongSword : Weapon
    {
        public override int WeaponDamage => 10;
        public override bool handiness => true;
        public override char Getchar() => 'S';
    }
    public class Spear : Weapon
    {
        public override int WeaponDamage => 8;
        public override bool handiness => true;
        public override char Getchar() => 'P';
    }
    public class UNIteam : Item
    {
        public override char Getchar() => 'U';
        public override bool handiness => false;
    }
    public class Ingot : UNIteam
    {
        public override char Getchar() => 'I';
        public override bool handiness => false;
    }
    public class Plank : UNIteam
    {
        public override char Getchar() => 'p';
        public override bool handiness =>true;
    }
    public class Torch : UNIteam
    {
        public override char Getchar() => 'T';
        public override bool handiness => false;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

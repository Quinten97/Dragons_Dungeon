using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Items
    {
        public static List<object> healthPotion = new List<object> {"Health Potion", "Heals you for a fourth of your health",.25, 0 };
    
    
        public static void UseItem(string itemName)
        {
            switch(itemName)
            {
                case "Health Potion":
                    {
                        UseHealthPotion();
                        break;
                    }
            }
        }

        public static void UseHealthPotion()
        {
            if ((int)healthPotion[3] == 0)
            {
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("No potions left.");
                Thread.Sleep(1000);
                return;
            }
            if (Player.currentHp == Player.maxHp)
            {
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Hp is full.");
                Thread.Sleep(1000);
                return;
            }
            if (Player.currentHp >= Player.maxHp - (Player.maxHp * .25) && (int)healthPotion[3] >= 1)
            {
                Player.currentHp = Player.maxHp;
                healthPotion[3] = (int)healthPotion[3] - 1;
                return;

            }
            if (Player.currentHp <= Player.maxHp - (Player.maxHp * .25) && (int)healthPotion[3] >= 1)
            {
                Player.currentHp = Player.currentHp + (int)Math.Floor(Player.maxHp * .25);
                healthPotion[3] = (int)healthPotion[3] - 1;
                return;
            }
        }
    }
}
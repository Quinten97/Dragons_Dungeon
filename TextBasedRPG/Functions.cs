using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Functions
    {
        //Base UI Function for most Rooms
        public static void DrawUI()
        {
            int index = 1;
            Console.WriteLine("  ____________________________________________________________________________________________________________________  ");

            while (index < 28)
            {
                Console.SetCursorPosition(1, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(118, index);
                Console.WriteLine("|");
                index++;
            }
            Console.SetCursorPosition(1, 22);
            Console.WriteLine("|____________________________________________________________________________________________________________________|");

            Console.SetCursorPosition(4, 24);
            Console.WriteLine("HP: {0}/{1}", Player.currentHp, Player.maxHp);

            Console.SetCursorPosition(4, 25);
            Console.WriteLine("MP: {0}/{1}", Player.currentMana, Player.maxMana);

            Console.SetCursorPosition(4, 26);
            Console.WriteLine("EXP: {0}/{1}", Player.currentExp, Player.maxExp);

            Console.SetCursorPosition(95, 26);
            Console.WriteLine("(I)nventory");
            Console.SetCursorPosition(110, 26);
            Console.WriteLine("(E)xit");

            Console.SetCursorPosition(1, 27);
            Console.WriteLine("|____________________________________________________________________________________________________________________|");

        }

        public static void DrawEnemys(string enemyName)
        {
            Console.SetCursorPosition(80,1);
            Console.WriteLine("--------------------------------");
            Console.SetCursorPosition(80,18);
            Console.WriteLine("--------------------------------");

            int index = 2;
            while (index < 18) 
            {
                Console.SetCursorPosition(79, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(112, index);
                Console.WriteLine("|");
                index++;
            }
            Console.SetCursorPosition(82, 19);
            Console.WriteLine(Combat.currentEnemy[0]);
            switch (enemyName)
            {
                case "kobold":
                    {
                        break;
                    }
            }
        }

        //Save current roomString for drawing of submenus, EX: Inventory

        public static void saveRoomString()
        {
            Screens.savedRoomString = Screens.roomString;
        }

        public static void combatSaveRoomString()
        {
            Screens.combatSaveRoomString = Screens.roomString;
        }
    }
}
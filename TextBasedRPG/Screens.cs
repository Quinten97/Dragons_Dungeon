using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Screens
    {

        public static string roomString = "title-screen";
        public static string savedRoomString = "";
        public static string combatSaveRoomString = "";

        public static void TitleScreen()
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



            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("  ____                                    ____                                     ");
            Console.SetCursorPosition(20, 11);
            Console.WriteLine(" |  _ \\ _ __ __ _  __ _  ___  _ __  ___  |  _ \\ _   _ _ __   __ _  ___  ___  _ __  ");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine(" | | | | '__/ _` |/ _` |/ _ \\| '_ \\/ __| | | | | | | | '_ \\ / _` |/ _ \\/ _ \\| '_ \\ ");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine(" | |_| | | | (_| | (_| | (_) | | | \\__ \\ | |_| | |_| | | | | (_| |  __/ (_) | | | |");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine(" |____/|_|  \\__,_|\\__, |\\___/|_| |_|___/ |____/ \\__,_|_| |_|\\__, |\\___|\\___/|_| |_|");
            Console.SetCursorPosition(20, 15);
            Console.WriteLine("                  |___/                                     |___/                  ");

            Console.SetCursorPosition(53, 20);
            Console.WriteLine("(S)tart");
            Console.SetCursorPosition(53, 22);
            Console.WriteLine("(E)xit");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("|____________________________________________________________________________________________________________________|");


            ConsoleKeyInfo keyInfo;

            do
            {

                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.S:
                        {
                            roomString = "class-screen";
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            Environment.Exit(-1);
                            break;
                        }
                }
            }
            while (keyInfo.Key != ConsoleKey.S);
        } // End of TitleScreen()

        
//---------------------------------------------------------------------------------------------------------------------------------------------------      
        
        public static void ClassScreen()
        {
            Console.Clear();

            roomString = "";

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

            Console.SetCursorPosition(47, 5);
            Console.WriteLine("Choose your class...");

            Console.SetCursorPosition(25, 12);
            Console.WriteLine("(B)arbarian");
            Console.SetCursorPosition(26, 14);
            Console.WriteLine("Hp: 25");
            Console.SetCursorPosition(26, 15);
            Console.WriteLine("Mana: 10");
            Console.SetCursorPosition(26, 16);
            Console.WriteLine("Strength: 3");
            Console.SetCursorPosition(26, 17);
            Console.WriteLine("Magic: 1");
            Console.SetCursorPosition(26, 18);
            Console.WriteLine("Dexterity: 2");

            Console.SetCursorPosition(54, 12);
            Console.WriteLine("(M)age");
            Console.SetCursorPosition(55, 14);
            Console.WriteLine("Hp: 12");
            Console.SetCursorPosition(55, 15);
            Console.WriteLine("Mana: 25");
            Console.SetCursorPosition(55, 16);
            Console.WriteLine("Strength: 1");
            Console.SetCursorPosition(55, 17);
            Console.WriteLine("Magic: 3");
            Console.SetCursorPosition(55, 18);
            Console.WriteLine("Dexterity: 2");

            Console.SetCursorPosition(80, 12);
            Console.WriteLine("(R)ouge");
            Console.SetCursorPosition(81, 14);
            Console.WriteLine("Hp: 15");
            Console.SetCursorPosition(81, 15);
            Console.WriteLine("Mana: 15");
            Console.SetCursorPosition(81, 16);
            Console.WriteLine("Strength: 1");
            Console.SetCursorPosition(81, 17);
            Console.WriteLine("Magic: 2");
            Console.SetCursorPosition(81, 18);
            Console.WriteLine("Dexterity: 3");

            Console.SetCursorPosition(110, 26);
            Console.WriteLine("(E)xit");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("|____________________________________________________________________________________________________________________|");

            ConsoleKeyInfo keyInfo;
            bool loopExit = false;

            do
            {

                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.B:
                        {
                            Player.InitializeStats(25, 10, 3, 1, 2);
                            Armor.EquipArmor(Armor.barbarianArmor);
                            Weapons.EquipWeapon(Weapons.battleAxe);
                            Player.currentHp = Player.maxHp;
                            Player.currentMana = Player.maxMana;
                            Player.inventoryArmor.Add(Armor.barbarianArmor);
                            Player.inventoryArmor.Add(Armor.mageArmor);
                            Player.inventoryWeapons.Add(Weapons.battleAxe);
                            roomString = "player-name-screen";
                            loopExit = true;
                            break;
                        }
                    case ConsoleKey.M:
                        {
                            Player.InitializeStats(12, 25, 1, 3, 2);
                            Armor.EquipArmor(Armor.mageArmor);
                            Weapons.EquipWeapon(Weapons.mageStaff);
                            Player.currentHp = Player.maxHp;
                            Player.currentMana = Player.maxMana;
                            Player.inventoryArmor.Add(Armor.mageArmor);
                            Player.inventoryWeapons.Add(Weapons.mageStaff);
                            roomString = "player-name-screen";
                            loopExit = true;
                            break;
                        }
                    case ConsoleKey.R:
                        {
                            Player.InitializeStats(15, 15, 1, 2, 3);
                            Armor.EquipArmor(Armor.rougeArmor);
                            Weapons.EquipWeapon(Weapons.twinDaggers);
                            Player.currentHp = Player.maxHp;
                            Player.currentMana = Player.maxMana;
                            Player.inventoryArmor.Add(Armor.rougeArmor);
                            Player.inventoryWeapons.Add(Weapons.twinDaggers);
                            roomString = "player-name-screen";
                            loopExit = true;
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            Environment.Exit(-1);
                            break;
                        }
                }
            }
            while (loopExit == false);
        } // End of ClassScreen()

//--------------------------------------------------------------------------------------------------------------------------------------------------------

        public static string nameTooLong = "";

        public static void PlayerNameScreen()
        {
            Console.Clear();

            roomString = "";

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

            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Enter a name...");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(30, 14);
            Console.WriteLine(nameTooLong);
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(110, 26);
            Console.WriteLine("(E)xit");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("|____________________________________________________________________________________________________________________|");

            bool breakLoop = true;

            while (breakLoop == true)
            {
                Console.SetCursorPosition(54, 12);
                string tempString = Console.ReadLine();


                if (tempString.Length <= 0 || tempString == null)
                {
                    nameTooLong = "The name you enter must be at least one character...";
                    PlayerNameScreen();
                }
                if (tempString.Length > 16)
                {
                    nameTooLong = "The name you enter must be less than 16 characters...";
                    PlayerNameScreen();
                }
                else
                {
                    Console.WriteLine("made it");
                    Player.playerName = tempString;
                    roomString = "cutscene-one";
                    breakLoop = false;
                }
            } 
        } //End of PlayerNameScreen()

//---------------------------------------------------------------------------------------------------------------------------------------
        public static void CutSceneOne()
        {
            Console.Clear();
            roomString = "";

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
            Console.SetCursorPosition(95, 26);
            Console.WriteLine("(C)ontinue");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("|____________________________________________________________________________________________________________________|");

            Console.SetCursorPosition(40, 12);
            Console.WriteLine("You awaken in a dark room, above you");
            Console.SetCursorPosition(40, 13);
            Console.WriteLine("shines moonlight through a damaged ceiling.");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine("standing, you take a look around you...");

            ConsoleKeyInfo keyInfo;

            bool loopExit = true;
            do
            {

                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.C:
                        {
                            roomString = "room-1-A";
                            loopExit = false;
                            break;
                        }
                }
            }
            while (loopExit == true);
        }// end of CutSceneOne()

        public static bool RoomOneAItem = true;

        public static void RoomOneA()
        {
            Console.Clear();
            Functions.combatSaveRoomString();
            Functions.saveRoomString();
            roomString = "";

            Functions.DrawUI();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("(S)earch Room");
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("(F)ight");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("(N)ext Room");


            ConsoleKeyInfo keyInfo;

            bool loopExit = true;
            do
            {

                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.S:
                        {
                            if (RoomOneAItem == true)
                            {
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("You found a health potion");
                                Player.consumables.Add(Items.healthPotion);
                                Player.keys.Add(Keys.Key1);
                                Items.healthPotion[3] =+ 1;
                                RoomOneAItem = false;
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("you find nothing else in this room");
                            }
                            break;
                        }
                    case ConsoleKey.F:
                        {
                            Combat.selectEnemy(Enemies.orc);
                            roomString = "combat";
                            Screens.savedRoomString = "combat";
                            loopExit = false;
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            roomString = "inventory";
                            loopExit=false;
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            Environment.Exit(-1);
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            roomString = "room-2-A";
                            loopExit = false;
                            break;
                        }
                }
            }
            while (loopExit == true);

        }// end of RoomOneA()

        public static void RoomTwoA()
        {
            Console.Clear();
            Functions.combatSaveRoomString();
            Functions.saveRoomString();
            roomString = "";

            Functions.DrawUI();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("(S)earch Room");
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("(F)ight");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("This is a new room");


            ConsoleKeyInfo keyInfo;
            bool loopBreak = true;
            do
            {

                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.S:
                        {
                            if (RoomOneAItem == true)
                            {
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("You found a health potion");
                                Player.consumables.Add(Items.healthPotion);
                                Player.keys.Add(Keys.Key1);
                                Items.healthPotion[3] = +1;
                                RoomOneAItem = false;
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 10);
                                Console.WriteLine("you find nothing else in this room");
                            }
                            break;
                        }
                    case ConsoleKey.F:
                        {
                            Combat.selectEnemy(Enemies.orc);
                            roomString = "combat";
                            Screens.savedRoomString = "combat";
                            loopBreak = false;
                            break;
                        }
                    case ConsoleKey.I:
                        {
                            roomString = "inventory";
                            loopBreak = false;
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            Environment.Exit(-1);
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            roomString = "room-1-A";
                            loopBreak = false;
                            break;
                        }
                }
            } 
            while (loopBreak == true);

        }// end of RoomTwoA()
    }
}
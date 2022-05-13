using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Inventory
    {
        public static int invPage = 0;
        public static int invLine = 7;
        public static int invItemCount;
        public static int selectedIndex = 0;
        public static List<object> selectedItem = new List<object>();
        public static int equipedArmorLine = 0;
        public static int equipedWeaponLine = 0;
        public static bool isArmorEquiped = true;
        public static bool isWeaponEquiped = true;

        public static void DrawInventory()
        {
           
         int[] equipedArmorIndex = { Player.equipedArmor[8].ToString().Count() + 44, 7 + equipedArmorLine };
         int[] equipedWeaponIndex = { Player.equipedWeapon[9].ToString().Count() + 44, 7 + equipedWeaponLine };

        Console.Clear();

            Screens.roomString = "";
            int index = 1;
            Console.WriteLine("  ____________________________________________________________________________________________________________________  ");

            while (index < 28)
            {
                Console.SetCursorPosition(1, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(118, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(40, index);
                Console.WriteLine("|");
                index++;
            }

            Console.SetCursorPosition(1, 24);
            Console.WriteLine("|                                      |_____________________________________________________________________________");


            Console.SetCursorPosition(17, 3);
            Console.WriteLine("Stats:");

            Console.SetCursorPosition(5, 6);
            Console.WriteLine("HP: {0}/{1}", Player.currentHp, Player.maxHp);
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("MP: {0}/{1}", Player.currentMana, Player.maxMana);
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("EXP: {0}/{1}", Player.currentExp, Player.maxExp);

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Strength: {0}", Player.strength);
            Console.SetCursorPosition(5, 11);
            Console.WriteLine("Magic: {0}", Player.magic);
            Console.SetCursorPosition(5, 12);
            Console.WriteLine("Dexterity: {0}", Player.dexterity);

            Console.SetCursorPosition(5, 14);
            Console.WriteLine("Armor: {0}", Player.armorClass);
            Console.SetCursorPosition(5, 15);
            Console.WriteLine("Magic Resistance: {0}", Player.magicResistance);
            Console.SetCursorPosition(5, 16);
            Console.WriteLine("Fire Resistance: {0}", Player.fireResistance);
            Console.SetCursorPosition(5, 17);
            Console.WriteLine("Ice Resistance: {0}", Player.iceResistance);
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("Lightning Resistance: {0}", Player.lightningResistance);
            Console.SetCursorPosition(5, 19);
            Console.WriteLine("Bleed Resistance: {0}", Player.bleedResistance);

            Console.SetCursorPosition(5, 21);
            Console.WriteLine("Physical Damage: {0}", Player.physicalDamage);
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("Magic Damage: {0}", Player.magicDamage);
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("Fire Damage: {0}", Player.fireDamage);
            Console.SetCursorPosition(5, 24);
            Console.WriteLine("Ice Damage: {0}", Player.iceDamage);
            Console.SetCursorPosition(5, 25);
            Console.WriteLine("Lightning Damage: {0}", Player.lightningDamage);
            Console.SetCursorPosition(5, 26);
            Console.WriteLine("Bleed Damage: {0}", Player.bleedDamage);

            Console.SetCursorPosition(47, 2);
            Console.WriteLine("Consumables");
            Console.SetCursorPosition(67, 2);
            Console.WriteLine("Weapons");
            Console.SetCursorPosition(87, 2);
            Console.WriteLine("Armor");
            Console.SetCursorPosition(107, 2);
            Console.WriteLine("Keys");

            Console.SetCursorPosition(42, 26);
            Console.WriteLine("(A)ctivate item");
            Console.SetCursorPosition(60, 26);
            Console.WriteLine("(E)quip");
            Console.SetCursorPosition(70, 26);
            Console.WriteLine("(U)nequip");

            Console.SetCursorPosition(90, 26);
            Console.WriteLine("▲▼ ◄ ►");
            Console.SetCursorPosition(110, 26);
            Console.WriteLine("(C)lose");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("|______________________________________|_____________________________________________________________________________");

            if (invPage == 0)
            {
                DrawConsumablesPanel();
                Console.SetCursorPosition(47, 3);
                Console.WriteLine("-----------");
            }
            if (invPage == 1)
            {
                DrawWeaponsPanel();
                Console.SetCursorPosition(67, 3);
                Console.WriteLine("-------");
            }
            if (invPage == 2)
            {
                DrawArmorPanel();
                Console.SetCursorPosition(87, 3);
                Console.WriteLine("-----");
            }
            else if (invPage == 3)
            {
                DrawKeysPanel();
                Console.SetCursorPosition(107, 3);
                Console.WriteLine("----");
            }

            try
            {
                if (invPage == 0)
                {
                    selectedItem = Player.consumables[selectedIndex];
                }
                if (invPage == 1)
                {
                    selectedItem = Player.inventoryWeapons[selectedIndex];
                }
                if (invPage == 2)
                {
                    selectedItem = Player.inventoryArmor[selectedIndex];
                }
                if (invPage == 3)
                {
                    selectedItem = Player.keys[selectedIndex];
                }
            }
            catch { }

            if (isWeaponEquiped == true && invPage == 1)
            {
                Console.SetCursorPosition(equipedWeaponIndex[0],equipedWeaponIndex[1]);
                Console.WriteLine("~");
            }
            if (isArmorEquiped == true && invPage == 2)
            {
                Console.SetCursorPosition(equipedArmorIndex[0], equipedArmorIndex[1]);
                Console.WriteLine("~");
            }


            DrawCursor();

            ConsoleKeyInfo keyInfo;
            bool loopBreak = true;


            while (loopBreak == true)
            {
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                        {
                            Items.UseItem((string)selectedItem[0]);
                            loopBreak = false;
                            Inventory.DrawInventory();
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            switch (invPage)
                            {
                                case 0:
                                    {
                                        break;
                                    }
                                case 1:
                                    {
                                        Weapons.EquipWeapon(Player.inventoryWeapons[selectedIndex]);
                                        equipedWeaponLine = selectedIndex;
                                        isWeaponEquiped = true;
                                        loopBreak = false;
                                        DrawInventory();
                                        break;
                                    }
                                case 2:
                                    {
                                        Armor.EquipArmor(Player.inventoryArmor[selectedIndex]);
                                        equipedArmorLine = selectedIndex;
                                        isArmorEquiped = true;
                                        loopBreak = false;
                                        DrawInventory();
                                        break;
                                    }
                                case 3:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case ConsoleKey.U:
                        {
                            switch (invPage)
                            {
                                case 0:
                                    {
                                        break;
                                    }
                                case 1:
                                    {
                                        if (selectedIndex == equipedWeaponLine)
                                        {
                                            Weapons.UnEquipWeapon();
                                            isWeaponEquiped = false;
                                            loopBreak = false;
                                            DrawInventory();
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        if (selectedIndex == equipedArmorLine)
                                        {
                                            Armor.UnEquipArmor();
                                            isArmorEquiped = false;
                                            loopBreak = false;
                                            DrawInventory();
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (invPage > 0)
                            {
                                selectedIndex = 0;
                                invLine = 7;
                                invPage--; ;
                                loopBreak = false;
                                DrawInventory();
                            }
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (invPage < 3)
                            {
                                selectedIndex = 0;
                                invLine = 7;
                                invPage++;
                                loopBreak = false;
                                DrawInventory();
                            }
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (selectedIndex > 0)
                            {
                                selectedIndex--;
                            }
                            if (invLine > 7)
                            {
                                invLine = invLine - 1;
                                loopBreak = false;
                                DrawInventory();
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (selectedIndex < invItemCount - 1)
                            {
                                selectedIndex++;
                            }
                            if (invLine < 6 + invItemCount)
                            {
                                invLine = invLine + 1;
                                loopBreak = false;
                                DrawInventory();
                            }
                            break;
                        }
                    case ConsoleKey.C:
                        {
                                Screens.roomString = Screens.savedRoomString;
                                loopBreak = false;
                                break;
                        }
                }

            }


        }// End of Draw Inventory

        public static void DrawWeaponsPanel()
        {
            Console.SetCursorPosition(46, 5);
            Console.WriteLine("Name");
            Console.SetCursorPosition(58, 5);
            Console.WriteLine("DMG");
            Console.SetCursorPosition(64, 5);
            Console.WriteLine("Str Req");
            Console.SetCursorPosition(73, 5);
            Console.WriteLine("Mag Req");
            Console.SetCursorPosition(83, 5);
            Console.WriteLine("Dex Req");
            Console.SetCursorPosition(93, 5);
            Console.WriteLine("M");
            Console.SetCursorPosition(97, 5);
            Console.WriteLine("F");
            Console.SetCursorPosition(101, 5);
            Console.WriteLine("I");
            Console.SetCursorPosition(105, 5);
            Console.WriteLine("L");
            Console.SetCursorPosition(109, 5);
            Console.WriteLine("B");
            Console.SetCursorPosition(41, 6);
            Console.WriteLine("-----------------------------------------------------------------------------");

            invItemCount = Player.inventoryWeapons.Count;
            int index = 7;
            while (index < 24)
            {
                Console.SetCursorPosition(56, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(62, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(71, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(81, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(91, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(95, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(99, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(103, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(107, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(111, index);
                Console.WriteLine("|");
                index++;
            }

            for (int i = 0; i < Player.inventoryWeapons.Count; i++)
           {
               Console.SetCursorPosition(43, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][9]);
               Console.SetCursorPosition(59, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][0]);
               Console.SetCursorPosition(67, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][1]);
               Console.SetCursorPosition(76, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][2]);
               Console.SetCursorPosition(86, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][3]);
               Console.SetCursorPosition(93, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][4]);
               Console.SetCursorPosition(97, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][5]);
               Console.SetCursorPosition(101, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][6]);
               Console.SetCursorPosition(105, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][7]);
               Console.SetCursorPosition(109, 7 + i);
               Console.WriteLine(Player.inventoryWeapons[i][8]);
           }
        }

        public static void DrawArmorPanel()
        {
            Console.SetCursorPosition(46, 5);
            Console.WriteLine("Name");
            Console.SetCursorPosition(82, 5);
            Console.WriteLine("HP");
            Console.SetCursorPosition(87, 5);
            Console.WriteLine("MP");
            Console.SetCursorPosition(92, 5);
            Console.WriteLine("Armor");
            Console.SetCursorPosition(99, 5);
            Console.WriteLine("MR");
            Console.SetCursorPosition(103, 5);
            Console.WriteLine("FR");
            Console.SetCursorPosition(107, 5);
            Console.WriteLine("IR");
            Console.SetCursorPosition(111, 5);
            Console.WriteLine("LR");
            Console.SetCursorPosition(115, 5);
            Console.WriteLine("BR");
            Console.SetCursorPosition(41, 6);
            Console.WriteLine("-----------------------------------------------------------------------------");

            invItemCount = Player.inventoryArmor.Count;
            int index = 7;
            while (index < 24)
            {
                Console.SetCursorPosition(80, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(84, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(90, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(98, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(102, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(106, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(110, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(114, index);
                Console.WriteLine("|");
                index++;
            }

            for (int i = 0; i < Player.inventoryArmor.Count; i++)
           {
               Console.SetCursorPosition(43, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][8]);
               Console.SetCursorPosition(82, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][0]);
               Console.SetCursorPosition(87, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][1]);
               Console.SetCursorPosition(94, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][2]);
               Console.SetCursorPosition(100, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][3]);
               Console.SetCursorPosition(104, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][4]);
               Console.SetCursorPosition(108, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][5]);
               Console.SetCursorPosition(112, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][6]);
               Console.SetCursorPosition(116, 7 + i);
               Console.WriteLine(Player.inventoryArmor[i][7]);
           }
        }

        public static void DrawConsumablesPanel()
        {
            {
                Console.SetCursorPosition(46, 5);
                Console.WriteLine("Name");
                Console.SetCursorPosition(59, 5);
                Console.WriteLine("Description");
                Console.SetCursorPosition(110, 5);
                Console.WriteLine("Quantity");
                Console.SetCursorPosition(41, 6);
                Console.WriteLine("-----------------------------------------------------------------------------");

                invItemCount = Player.consumables.Count;
                int index = 7;
                while (index < 24)
                {
                    Console.SetCursorPosition(56, index);
                    Console.WriteLine("|");
                    Console.SetCursorPosition(109, index);
                    Console.WriteLine("|");
                    index++;
                }

                try
                {
                    for (int i = 0; i < Player.consumables.Count; i++)
                   {
                       Console.SetCursorPosition(43, 7 + i);
                       Console.WriteLine(Player.consumables[i][0]);
                       Console.SetCursorPosition(59, 7 + i);
                       Console.WriteLine(Player.consumables[i][1]);
                       Console.SetCursorPosition(114, 7 + i);
                       Console.WriteLine("x" + Player.consumables[i][3]);
                   }
                }
                catch { }
            }
        }

        public static void DrawKeysPanel()
        {
            Console.SetCursorPosition(46, 5);
            Console.WriteLine("Name");
            Console.SetCursorPosition(59, 5);
            Console.WriteLine("Description");
            Console.SetCursorPosition(110, 5);
            Console.WriteLine("Quantity");
            Console.SetCursorPosition(41, 6);
            Console.WriteLine("-----------------------------------------------------------------------------");

            invItemCount = Player.keys.Count;
            int index = 7;
            while (index < 24)
            {
                Console.SetCursorPosition(56, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(109, index);
                Console.WriteLine("|");
                index++;

                try
                {
                    for (int i = 0; i < Player.keys.Count; i++)
                   {
                       Console.SetCursorPosition(43, 7 + i);
                       Console.WriteLine(Player.keys[i][0]);
                       Console.SetCursorPosition(59, 7 + i);
                       Console.WriteLine(Player.keys[i][1]);
                       Console.SetCursorPosition(114, 7 + i);
                       Console.WriteLine("x" + Player.keys[i][2]);
                   }
                }
                catch { }
            }
        }

        public static void DrawCursor()
        {
            Console.SetCursorPosition(41, invLine);
            Console.WriteLine(">");
        }
    }
}
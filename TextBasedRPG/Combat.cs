using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Combat
    {
        public static List<object> currentEnemy = new List<object>();

        public static List<object> playerDamageArray = new List<object> { 0, 0, 0, 0, 0 };
        public static List<object> enemyDamageArray = new List<object> { 0, 0, 0, 0, 0 };

        public static int pMagDmgTotal;
        public static int eMagDmgTotal;

        public static void CombatRoom()
        {
            Functions.saveRoomString();
            Console.Clear();
            Screens.roomString = "";
            Functions.DrawUI();

            Console.SetCursorPosition(65, 26);
            Console.WriteLine("(A)ttack");
            Console.SetCursorPosition(75, 26);
            Console.WriteLine("(M)agic");
            Console.SetCursorPosition(85, 26);
            Console.WriteLine("(D)efend");

            ConsoleKeyInfo keyInfo;
            bool loopExit = true;
            do
            {
                //Players Turn
                keyInfo = Console.ReadKey();
                while (Player.currentHp > 0 && (int)currentEnemy[1] > 0)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.A:
                            {
                                int hitChance = d100();

                                if (hitChance < 20)
                                {
                                    Console.SetCursorPosition(10, 15);
                                    Console.WriteLine("Attack Missed");
                                    Thread.Sleep(1000);
                                    CombatRoom();
                                    break;
                                }
                                if (hitChance >= 20)
                                {
                                    Console.SetCursorPosition(10, 15);
                                    Console.WriteLine("attack hits for {0} damage", Player.physicalDamage - (int)currentEnemy[3]);

                                    currentEnemy[1] = (int)currentEnemy[1] - Player.physicalDamage + (int)currentEnemy[3];
                                    Thread.Sleep(1000);
                                    CombatRoom();
                                    break;
                                }
                                break;
                            }
                        case ConsoleKey.M:
                            {
                                int hitChance = d100();

                                if (hitChance < 20)
                                {
                                    Console.SetCursorPosition(10, 15);
                                    Console.WriteLine("Attack Missed");
                                    Thread.Sleep(1000);
                                    CombatRoom();
                                    break;
                                }
                                if (hitChance >= 20)
                                {
                                    if (Player.currentMana > 2)
                                    {
                                        Console.SetCursorPosition(10, 15);
                                        Console.WriteLine("attack hits for {0} damage", pMagDmgTotal + Player.physicalDamage);
                                        currentEnemy[1] = (int)currentEnemy[1] - pMagDmgTotal - Player.physicalDamage;
                                        Player.currentMana = Player.currentMana - 2;
                                        Thread.Sleep(1000);
                                        CombatRoom();
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(10, 16);
                                        Console.WriteLine("Not enough mana");
                                        Thread.Sleep(1000);
                                        CombatRoom();
                                    }
                                }
                                break;
                            }
                        case ConsoleKey.D:
                            {

                                break;
                            }
                        case ConsoleKey.I:
                            {
                                Screens.roomString = "inventory";
                                loopExit = false;
                                break;
                            }
                        case ConsoleKey.E:
                            {
                                Environment.Exit(-1);
                                break;
                            }
                    }

                    //Enemies Turn
                }
            }
            while (loopExit == true);
        }

        public static void selectEnemy(dynamic enemy)
        {
            currentEnemy.Clear();
            currentEnemy.AddRange(enemy);

            playerDamageArray[0] = (int)Player.equipedWeapon[4] - (int)currentEnemy[4];
            playerDamageArray[1] = (int)Player.equipedWeapon[5] - (int)currentEnemy[5];
            playerDamageArray[2] = (int)Player.equipedWeapon[6] - (int)currentEnemy[6];
            playerDamageArray[3] = (int)Player.equipedWeapon[7] - (int)currentEnemy[7];
            playerDamageArray[4] = (int)Player.equipedWeapon[8] - (int)currentEnemy[8];

            enemyDamageArray[0] = ((int)currentEnemy[10] - (int)Player.equipedArmor[3]);
            enemyDamageArray[1] = ((int)currentEnemy[11] - (int)Player.equipedArmor[4]);
            enemyDamageArray[2] = ((int)currentEnemy[12] - (int)Player.equipedArmor[5]);
            enemyDamageArray[3] = ((int)currentEnemy[13] - (int)Player.equipedArmor[6]);
            enemyDamageArray[4] = ((int)currentEnemy[14] - (int)Player.equipedArmor[7]);

            pMagDmgTotal = (int)playerDamageArray[0] + 
                           (int)playerDamageArray[1] + 
                           (int)playerDamageArray[2] + 
                           (int)playerDamageArray[3] + 
                           (int)playerDamageArray[4];

            eMagDmgTotal = (int)enemyDamageArray[0] +
                           (int)enemyDamageArray[1] +
                           (int)enemyDamageArray[2] +
                           (int)enemyDamageArray[3] +
                           (int)enemyDamageArray[4];
        }

        public static int d100()
        {
            Random rand = new Random();
            return rand.Next(100);
        }
    }
}

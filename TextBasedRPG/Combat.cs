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

        public static string enemyAbility;
        public static int enemyAbilityCost;

        public static double playerDefend = 1;
        public static double enemyDefend = 1;
        public static bool loopBreak = true;


        public static void CombatRoom()
        {
            Console.Clear();
            Screens.roomString = "";
            Functions.DrawUI();
            Functions.DrawEnemys((string)currentEnemy[0]);

            Console.SetCursorPosition(65, 26);
            Console.WriteLine("(A)ttack");
            Console.SetCursorPosition(75, 26);
            Console.WriteLine("(M)agic");
            Console.SetCursorPosition(85, 26);
            Console.WriteLine("(D)efend");

            Console.SetCursorPosition(82, 20);
            Console.WriteLine("Enemy HP: {0}", currentEnemy[1]);

            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey();
            while (Player.currentHp > 0 && (int)currentEnemy[1] > 0 && loopBreak == true)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.I:
                        {
                            Screens.roomString = "inventory";
                            loopBreak = false;
                            break;
                        }
                    case ConsoleKey.A:
                    {
                        int hitChance = d100();

                        if (hitChance < 20)
                        {
                            Console.SetCursorPosition(10, 15);
                            Console.WriteLine("Attack Missed");
                            Thread.Sleep(1500);
                            break;
                        }
                        if (hitChance >= 20)
                        {
                            Console.SetCursorPosition(10, 15);
                            Console.WriteLine("attack hits for {0} damage", (int)Math.Ceiling(PlayerDmg() * enemyDefend));
                            currentEnemy[1] = (int)currentEnemy[1] - (int)Math.Ceiling(PlayerDmg() * enemyDefend);
                            enemyDefend = 1;
                            Thread.Sleep(1500);
                            break;
                        }
                            //loopBreak = false;
                        break;
                    }
                    case ConsoleKey.M:
                    {
                        int hitChance = d100();
                        if (hitChance < 20)
                        {
                                if (Player.currentMana >= 2)
                                {
                                    Console.SetCursorPosition(10, 15);
                                    Console.WriteLine("Attack Missed");
                                    Player.currentMana = Player.currentMana - 2;
                                    Thread.Sleep(1500);
                                }
                                else
                                {
                                    Console.SetCursorPosition(10, 16);
                                    Console.WriteLine("Not enough mana");
                                    Thread.Sleep(1500);
                                }
                            //loopBreak = false;
                            break;
                        }
                        if (hitChance >= 20)
                        {
                            if (Player.currentMana >= 2)
                            {
                                Console.SetCursorPosition(10, 15);
                                Console.WriteLine("attack hits for {0} damage", (int)Math.Ceiling(PlayerMagDmg() * enemyDefend));
                                currentEnemy[1] = (int)currentEnemy[1] - (int)Math.Ceiling(PlayerMagDmg() * enemyDefend);
                                Player.currentMana = Player.currentMana - 2;
                                enemyDefend = 1;
                                Thread.Sleep(1500);
                            }
                            else
                            {
                                Console.SetCursorPosition(10, 16);
                                Console.WriteLine("Not enough mana");
                                Thread.Sleep(1500);
                            }
                        }
                        //loopBreak = false;
                        break;
                    }
                    case ConsoleKey.D:
                    {
                            playerDefend = .50;
                            int hitChance = d100();

                            if (hitChance < 20)
                            {
                                Console.SetCursorPosition(10, 15);
                                Console.WriteLine("Defending, Attack Missed");
                                Thread.Sleep(1500);
                                break;
                            }
                            if (hitChance >= 20)
                            {
                                Console.SetCursorPosition(10, 15);
                                Console.WriteLine("Defending, Attack hits for {0} damage", (int)Math.Ceiling(PlayerDmg() * enemyDefend * playerDefend));
                                currentEnemy[1] = (int)currentEnemy[1] - (int)Math.Ceiling(PlayerDmg() * enemyDefend * playerDefend);
                                enemyDefend = 1;
                                Thread.Sleep(1500);
                                break;
                            }
                            //loopBreak = false;
                            break;
                    }
                    case ConsoleKey.E:
                    {
                        Environment.Exit(-1);
                        break;
                    }
                }

                if (loopBreak == true)
                {
                    //Enemy turn
                    if ((int)currentEnemy[1] > 0 && Player.currentHp > 0)
                    {
                        int enemyMove = d3();
                        int hitChance = d100();
                        switch (enemyMove)
                        {
                            case 0:
                                {
                                    if (hitChance >= 20)
                                    {
                                        Console.SetCursorPosition(40, 5);
                                        Console.WriteLine("Enemy attacks for {0}", (int)Math.Ceiling(EnemyDmg() * playerDefend));
                                        Player.currentHp = Player.currentHp - (int)Math.Ceiling(EnemyDmg() * playerDefend);
                                        Thread.Sleep(1000);
                                        CombatRoom();
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(40, 5);
                                        Console.WriteLine("Enemy attack misses");
                                        Thread.Sleep(1000);
                                        CombatRoom();
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (hitChance >= 20 && (int)currentEnemy[2] > 2)
                                    {
                                        Console.SetCursorPosition(40, 5);
                                        Console.WriteLine("Enemy uses {0} for {1} damage", enemyAbility, Math.Ceiling(EnemyMagDMG() * playerDefend));
                                        currentEnemy[2] = (int)currentEnemy[2] - 2;
                                        Player.currentHp = Player.currentHp - (int)Math.Ceiling(EnemyMagDMG() * playerDefend);
                                        Thread.Sleep(1000);
                                        CombatRoom();
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(40, 5);
                                        Console.WriteLine("Enemy attack misses");
                                        Thread.Sleep(1000);
                                        CombatRoom();
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (enemyMove == 2)
                                    {
                                        enemyDefend = .50;
                                        if (hitChance >= 20)
                                        {
                                            Console.SetCursorPosition(40, 5);
                                            Console.WriteLine("Enemy defends, Enemy attacks for {0}", (int)Math.Ceiling(EnemyDmg() * playerDefend * enemyDefend));
                                            Player.currentHp = Player.currentHp - (int)Math.Ceiling(EnemyDmg() * playerDefend * enemyDefend);
                                            Thread.Sleep(1000);
                                            CombatRoom();
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(40, 5);
                                            Console.WriteLine("Enemy Defending, Attack Missed");
                                            Thread.Sleep(1000);
                                            CombatRoom();
                                        }
                                    }
                                    break;
                                }
                        }

                    }
                    if (Player.currentHp <= 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(42, 15);
                        Console.WriteLine("You Died, Press any key to close");
                        Console.ReadKey();
                        Environment.Exit(-1);
                    }
                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(42, 15);
                        Console.WriteLine("Victory! Press any key to return.");
                        Console.ReadKey();
                        Screens.roomString = Screens.combatSaveRoomString;
                    }
                }
            }
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

            enemyAbility = (string)currentEnemy[15];
            enemyAbilityCost = (int)currentEnemy[16];
        }

        public static int d100()
        {
            Random rand = new Random();
            return rand.Next(100);
        }
        public static int d3()
        {
            Random rand = new Random();
            return rand.Next(3);
        }

        public static int PlayerDmg()
        {
            if (Player.physicalDamage - (int)currentEnemy[3] >= 1)
            {
                return Player.physicalDamage - (int)currentEnemy[3];
            }
            else
            {
                return 1;
            }
        }

        public static int PlayerMagDmg()
        {
            if (pMagDmgTotal + Player.physicalDamage >= 1)
            {
                return pMagDmgTotal + Player.physicalDamage;
            }
            else
            {
                return 1;
            }
        }
        public static int EnemyDmg()
        {
            if ((int)currentEnemy[9] - Player.armorClass >= 1)
            {
                return (int)currentEnemy[9] - Player.armorClass;
            }
            else
            {
                return 1;
            }
        }

        public static int EnemyMagDMG()
        {
            if (eMagDmgTotal + (int)currentEnemy[9] >= 1)
            {
                return eMagDmgTotal + (int)currentEnemy[9];
            }
            else
            {
                return 1;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Enemies
    {
        /* Name, HP, MP, Armor, magRes, 
         * firRes, iceRes, ligRes, bleRes, 
         * damage, magDmg, firDmg, iceDmg, 
         * ligDmg, bleDmg */

        public static List<object> orc = new List<object> {
            /*Name 0*/ "kobold",
            /*HP 1*/ 5, 
            /*MP 2*/ 10, 
            /*Armor 3*/ 3, 
            /*magRes 4*/ 1,
            /*firRes 5*/ -1,
            /*iceRes 6*/ 0,
            /*ligRes 7*/ 0,
            /*bleRes 8*/ -1,
            /*Dmg 9*/ 4,
            /*magDmg 10*/ 0,
            /*firDmg 11*/ 3,
            /*iceDmg 12*/ 0,
            /*ligDmg 13*/ 0,
            /*bleDmg 14*/ 0,
            /*Magic Name 15*/ "Fire Breath",
            /*MP Cost 16*/ 2
        };

        public static void EnemyAttack()
        {
            if ((int)Combat.currentEnemy[1] > 0 && Player.currentHp > 0)
            {
                int enemyMove = Combat.d3();
                int hitChance = Combat.d100();
                switch (enemyMove)
                {
                    case 0:
                        {
                            if (hitChance >= 20)
                            {
                                Console.SetCursorPosition(40, 5);
                                Console.WriteLine("Enemy attacks for {0}", (int)Math.Ceiling(EnemyDmg() * Combat.playerDefend));
                                Player.currentHp = Player.currentHp - (int)Math.Ceiling(EnemyDmg() * Combat.playerDefend);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.SetCursorPosition(40, 5);
                                Console.WriteLine("Enemy attack misses");
                                Thread.Sleep(1000);
                            }

                            break;
                        }
                    case 1:
                        {
                            if (hitChance >= 20 && (int)Combat.currentEnemy[2] > 2)
                            {
                                Console.SetCursorPosition(40, 5);
                                Console.WriteLine("Enemy uses {0} for {1} damage", Combat.enemyAbility, Math.Ceiling(EnemyMagDMG() * Combat.playerDefend));
                                Combat.currentEnemy[2] = (int)Combat.currentEnemy[2] - 2;
                                Player.currentHp = Player.currentHp - (int)Math.Ceiling(EnemyMagDMG() * Combat.playerDefend);
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                Console.SetCursorPosition(40, 5);
                                Console.WriteLine("Enemy attack misses");
                                Thread.Sleep(1000);
                            }

                            break;
                        }
                    case 2:
                        {
                            if (enemyMove == 2)
                            {
                                Combat.enemyDefend = .50;
                                if (hitChance >= 20)
                                {
                                    Console.SetCursorPosition(40, 5);
                                    Console.WriteLine("Enemy defends, Enemy attacks for {0}", (int)Math.Ceiling(EnemyDmg() * Combat.playerDefend * Combat.enemyDefend));
                                    Player.currentHp = Player.currentHp - (int)Math.Ceiling(EnemyDmg() * Combat.playerDefend * Combat.enemyDefend);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.SetCursorPosition(40, 5);
                                    Console.WriteLine("Enemy Defending, Attack Missed");
                                    Thread.Sleep(1000);
                                }
                            }

                            break;
                        }
                }
            }
        }
        public static int EnemyDmg()
        {
            if ((int)Combat.currentEnemy[9] - Player.armorClass >= 1)
            {
                return (int)Combat.currentEnemy[9] - Player.armorClass;
            }
            else
            {
                return 1;
            }
        }

        public static int EnemyMagDMG()
        {
            if (Combat.eMagDmgTotal + (int)Combat.currentEnemy[9] >= 1)
            {
                return Combat.eMagDmgTotal + (int)Combat.currentEnemy[9];
            }
            else
            {
                return 1;
            }
        }
    }
}

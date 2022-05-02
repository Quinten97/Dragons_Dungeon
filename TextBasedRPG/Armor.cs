using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Armor
    {
        // Armor Sets hpBonus, manaBonus, armorBonus, magRes, firRes, iceRes, ligRes, bleRes, Name
        public static object[] barbarianArmor = { 3, 1, 3, 0, 2, 0, 0, 0, "Barbarian Cloths" };
        public static object[] mageArmor = { 1, 3, 1, 2, 0, 0, 0, 0, "Mage Robes" };
        public static object[] rougeArmor = { 2, 2, 2, 0, 0, 0, 0, 2, "Rouge Leather" };
    }
}
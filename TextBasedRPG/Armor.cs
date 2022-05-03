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
        public static List<object> barbarianArmor = new List<object> { 3, 1, 3, 0, 2, 0, 0, 0, "Barbarian Cloths" };
        public static List<object> mageArmor = new List<object> { 1, 3, 1, 2, 0, 0, 0, 0, "Mage Robes" };
        public static List<object> rougeArmor = new List<object> { 2, 2, 2, 0, 0, 0, 0, 2, "Rouge Leather" };
    }
}
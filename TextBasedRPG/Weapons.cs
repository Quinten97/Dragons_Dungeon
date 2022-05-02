using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Weapons
    { 
 // Weapons baseDamage,strRequirement, magRequirement, dexRequirement, magDmg, firDmg, iceDmg, ligDmg, bleDmg, Name
        public static object[] battleAxe = { 4, 3, 0, 1, 0, 0, 0, 0, 0, "Battle Axe" };
        public static object[] mageStaff = { 1, 0, 3, 1, 3, 0, 0, 0, 0, "Mage Staff" };
        public static object[] twinDaggers = { 2, 1, 1, 1, 0, 0, 0, 0, 2, "Twin Daggers" };
    }
}